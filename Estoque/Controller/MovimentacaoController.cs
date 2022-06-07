using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Controller {
    public class MovimentacaoController: TB_MOVIMENTACAO {
        public static MovimentacaoController GetDadosMovimentacao(int prHandle) {
            using(var dbContext = new EntidadeEstoque()) {
                var entMovimentacao = dbContext.TB_MOVIMENTACAO.Find(prHandle);

                if(entMovimentacao != null) {
                    MovimentacaoController Movimentacao = new MovimentacaoController {
                        HANDLE = entMovimentacao.HANDLE,
                        CODIGO = entMovimentacao.CODIGO,
                        CLIENTE = entMovimentacao.CLIENTE,
                        PESOLIQUIDO = entMovimentacao.PESOLIQUIDO,
                        PESOBRUTO = entMovimentacao.PESOBRUTO,
                        VALORTOTAL = entMovimentacao.VALORTOTAL,
                        VALORUNITARIO = entMovimentacao.VALORUNITARIO,
                        DATA = entMovimentacao.DATA,
                        ITEM = entMovimentacao.ITEM,
                        TIPOMOVIMENTACAO = entMovimentacao.TIPOMOVIMENTACAO,
                        ORDEM = entMovimentacao.ORDEM,
                        QUANTIDADE = entMovimentacao.QUANTIDADE,
                        UNIDADESIGLA = entMovimentacao.UNIDADESIGLA,
                    };

                    return Movimentacao;

                } else {
                    return null;
                }
            }
        }

        public static List<MovimentacaoController> GetMovimentacaoByCodigo(string prCodigo = "0") {
            using(var dbContext = new EntidadeEstoque()) {
                string sql = " SELECT A.*, " +
                             "        B.NOME CLIENTENOME, " +
                             "        C.CODIGO CODIGOORDEM, " +
                             "        D.NOME ITEMNOME " +
                             "   FROM TB_MOVIMENTACAO A " +
                             "  INNER JOIN TB_PESSOA  B ON B.HANDLE = A.CLIENTE " +
                             "  INNER JOIN TB_ORDEM   C ON C.HANDLE = A.ORDEM " +
                             "  INNER JOIN TB_ITEM    D ON D.HANDLE = A.ITEM ";

                if(!String.IsNullOrWhiteSpace(prCodigo)) {
                    sql += " WHERE A.CODIGO = " + prCodigo;
                }

                List<MovimentacaoController> listaMovimentacao = dbContext.Database.SqlQuery<MovimentacaoController>(sql).OrderByDescending(o => o.HANDLE).ToList();

                for(int i = 0; i < listaMovimentacao.Count; i++) {
                    for(int j = 1; j <= Enum.GetNames(typeof(TipoMovimentacao)).Length; j++) {
                        if(listaMovimentacao[i].TIPOMOVIMENTACAO == (int)(TipoMovimentacao)j) {
                            listaMovimentacao[i].TIPOMOVIMENTACAONOME = ((TipoMovimentacao)j).ToString();
                        }
                    }

                    for(int j = 1; j <= Enum.GetNames(typeof(UnidadeMedida)).Length; j++) {
                        if(listaMovimentacao[i].UNIDADEMEDIDA == (int)(UnidadeMedida)j) {
                            listaMovimentacao[i].UNIDADESIGLA = ((UnidadeMedida)j).ToString();
                        }
                    }
                }
                return listaMovimentacao;
            }
        }

        public bool Salvar(TB_MOVIMENTACAO prMovimentacao) {
            using(var dbContext = new EntidadeEstoque()) {
                try {
                    dbContext.TB_MOVIMENTACAO.Add(prMovimentacao);
                    dbContext.SaveChanges();
                    return true;

                } catch(Exception) {
                    return false;
                }
            }
        }

    }

    public enum TipoMovimentacao: int {
        Entrada = 1,
        Saida = 2
    }
}
