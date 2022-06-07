using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Controller {
    public class OrdemController: TB_ORDEM {

        public static bool GerouMovimentacao(int prHandle = 0) {
            using(var dbContext = new EntidadeEstoque()) {
                return dbContext.Database.SqlQuery<int>(" SELECT 1 " +
                                                         "   FROM TB_ORDEM " +
                                                         "  WHERE GEROUMOVIMENTACAO = " + "'S'" +
                                                         "    AND HANDLE = " + prHandle).Count() > 0;
                
            }
        }

        public static OrdemController GetDadosOrdem(int prOrdem) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaOrdem = dbContext.TB_ORDEM.Find(prOrdem);

                if(entListaOrdem != null) {
                    OrdemController Ordem = new OrdemController {
                        HANDLE = entListaOrdem.HANDLE,
                        CODIGO = entListaOrdem.CODIGO,
                        CLIENTE = entListaOrdem.CLIENTE,
                        DATA = entListaOrdem.DATA,
                        QUANTIDADE = entListaOrdem.QUANTIDADE,
                        ITEM = entListaOrdem.ITEM,
                        NUMEROPEDIDO = entListaOrdem.NUMEROPEDIDO,
                        PESOLIQUIDO = entListaOrdem.PESOLIQUIDO,
                        PESOBRUTO = entListaOrdem.PESOBRUTO,
                        VALORTOTAL = entListaOrdem.VALORTOTAL,
                        VALORUNITARIO = entListaOrdem.VALORUNITARIO,
                        OBSERVACAO = entListaOrdem.OBSERVACAO,
                        TIPOMOVIMENTACAO = entListaOrdem.TIPOMOVIMENTACAO,
                    };

                    return Ordem;
                } 
                else {
                    return null;
                }
            }
        }

        public static List<OrdemController> GetOrdemByNumeroPedido(string prNumeroPedido) {
            using(var dbContext = new EntidadeEstoque()) {
                string sql = " SELECT A.*, " +
                             "        B.NOME CLIENTENOME, " +
                             "        C.NOME ITEMNOME " +
                             "   FROM TB_ORDEM A " +
                             "  INNER JOIN TB_PESSOA B ON B.HANDLE = A.CLIENTE " +
                             "  INNER JOIN TB_ITEM   C ON C.HANDLE = A.ITEM ";

                if(!String.IsNullOrWhiteSpace(prNumeroPedido)) {
                    sql += " WHERE A.NUMEROPEDIDO = '" + prNumeroPedido + "'";
                }

                List<OrdemController> listaOrdem = dbContext.Database.SqlQuery<OrdemController>(sql).OrderByDescending(o => o.HANDLE).ToList();

                for(int i = 0; i < listaOrdem.Count; i++) {
                    for(int j = 1; j <= Enum.GetNames(typeof(TipoMovimentacao)).Length; j++) {
                        if(listaOrdem[i].TIPOMOVIMENTACAO == (int)(TipoMovimentacao)j) {
                            listaOrdem[i].TIPOMOVIMENTACAONOME = ((TipoMovimentacao)j).ToString();
                        }
                    }                 
                }

                if (listaOrdem != null) {
                    return listaOrdem;
                } else {
                    return null;
                }
            }
        }

        public static bool GerarMovimentacao(int prOrdem) {
            try {
                OrdemController DadosOrdem = OrdemController.GetDadosOrdem(prOrdem);
                using(var dbContext = new EntidadeEstoque()) {
                    dbContext.Database.ExecuteSqlCommand("UPDATE TB_ORDEM SET GEROUMOVIMENTACAO = 'S' WHERE HANDLE = " + prOrdem);
                }

                int unidadeMedida = ItemController.GetUnidadeMedida((int)DadosOrdem.ITEM);

                TB_MOVIMENTACAO entMovimentacao = new TB_MOVIMENTACAO {
                    HANDLE = prOrdem,
                    CODIGO = DadosOrdem.CODIGO,
                    CLIENTE = DadosOrdem.CLIENTE,
                    ITEM = DadosOrdem.ITEM,
                    PESOBRUTO = (decimal)DadosOrdem.PESOBRUTO,
                    PESOLIQUIDO = (decimal)DadosOrdem.PESOLIQUIDO,
                    VALORUNITARIO = (decimal)DadosOrdem.VALORUNITARIO,
                    VALORTOTAL = (decimal)DadosOrdem.VALORTOTAL,
                    DATA = DadosOrdem.DATA,
                    QUANTIDADE = (decimal)DadosOrdem.QUANTIDADE,
                    TIPOMOVIMENTACAO = DadosOrdem.TIPOMOVIMENTACAO,
                    ORDEM = DadosOrdem.HANDLE,
                    UNIDADEMEDIDA = unidadeMedida
                };

                if(entMovimentacao != null) {
                    MovimentacaoController Movimentacao = new MovimentacaoController();
                    return Movimentacao.Salvar(entMovimentacao);
                } else {
                    return false;
                }

            } catch(Exception) {
                return false;                
            }
        }

        public TB_ORDEM Salvar(OrdemController prOrdem) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_ORDEM entOrdem = new TB_ORDEM {
                    HANDLE = prOrdem.HANDLE,
                    CODIGO = prOrdem.CODIGO,
                    CLIENTE = prOrdem.CLIENTE,
                    ITEM = prOrdem.ITEM,
                    PESOBRUTO = (decimal)prOrdem.PESOBRUTO,
                    PESOLIQUIDO = (decimal)prOrdem.PESOLIQUIDO,
                    VALORUNITARIO = (decimal)prOrdem.VALORUNITARIO,
                    VALORTOTAL = (decimal)prOrdem.VALORTOTAL,
                    DATA = prOrdem.DATA,
                    QUANTIDADE = (decimal)prOrdem.QUANTIDADE,
                    OBSERVACAO = prOrdem.OBSERVACAO,
                    TIPOMOVIMENTACAO = prOrdem.TIPOMOVIMENTACAO,
                    NUMEROPEDIDO = prOrdem.NUMEROPEDIDO
                };

                if(entOrdem.HANDLE == 0) {
                    entOrdem.CODIGO = dbContext.TB_ORDEM.Max(e => e.CODIGO) + 1;

                    dbContext.TB_ORDEM.Add(entOrdem);

                } else {
                    dbContext.Entry(entOrdem).State = System.Data.Entity.EntityState.Modified;
                }

                dbContext.SaveChanges();

                return entOrdem;
            }
        }

        public bool Excluir(int prOrdem) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_ORDEM entOrdem = new TB_ORDEM();

                entOrdem.HANDLE = prOrdem;
                var entry = dbContext.Entry(entOrdem);

                if(entry.State == System.Data.Entity.EntityState.Detached) {
                    dbContext.TB_ORDEM.Attach(entOrdem);
                }

                int count = dbContext.TB_MOVIMENTACAO.Where(e => e.ORDEM == prOrdem).Count();

                if(count > 0) {
                    return false;
                } else {
                    dbContext.TB_ORDEM.Remove(entOrdem);
                    dbContext.SaveChanges();
                    return true;
                }
            }
        }
    }
}
