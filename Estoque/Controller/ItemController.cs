using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Controller {
    public class ItemController: TB_ITEM {

        public static ItemController GetDadosItem(int prItem) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaItem = dbContext.TB_ITEM.Find(prItem);

                if(entListaItem != null) {
                    ItemController Item = new ItemController {
                        HANDLE = entListaItem.HANDLE,
                        CODIGOREFERENCIA = entListaItem.CODIGOREFERENCIA,
                        CLIENTE = entListaItem.CLIENTE,
                        PESOLIQUIDO = entListaItem.PESOLIQUIDO,
                        PESOBRUTO = entListaItem.PESOBRUTO,
                        OBSERVACAO = entListaItem.OBSERVACAO,
                        UNIDADEMEDIDA = entListaItem.UNIDADEMEDIDA,
                        CLASSIFICACAO = entListaItem.CLASSIFICACAO,
                        NOME = entListaItem.NOME,
                        CODIGO = entListaItem.CODIGO
                    };

                    return Item;
                } else {
                    return null;
                }
            }
        }

        public static List<ItemController> GetItemByCodigoByCodigoReferencia(string prCodigoReferencia) {
            using(var dbContext = new EntidadeEstoque()) {
                string sql = " SELECT A.*, " +
                             "        B.NOME CLIENTENOME " +
                             "   FROM TB_ITEM A " +
                             "  INNER JOIN TB_PESSOA B ON B.HANDLE = A.CLIENTE ";

                if(!String.IsNullOrWhiteSpace(prCodigoReferencia)) {
                    sql += " WHERE A.CODIGOREFERENCIA = '" + prCodigoReferencia + "'";
                }

                sql += " ORDER BY A.HANDLE DESC";

                List<ItemController> listaItem = dbContext.Database.SqlQuery<ItemController>(sql).OrderByDescending(o => o.HANDLE).ToList();

                for(int i = 0; i < listaItem.Count; i++) {
                    for(int j = 1; j <= Enum.GetNames(typeof(Classificacao)).Length; j++) {
                        if(listaItem[i].CLASSIFICACAO == (int)(Classificacao)j) {
                            listaItem[i].CLASSIFICACAONOME = ((Classificacao)j).ToString();
                        }
                    }

                    for(int j = 1; j <= Enum.GetNames(typeof(UnidadeMedida)).Length; j++) {
                        if(listaItem[i].UNIDADEMEDIDA == (int)(UnidadeMedida)j) {
                            listaItem[i].UNIDADESIGLA = ((UnidadeMedida)j).ToString();
                        }
                    }
                }

                if(listaItem != null) {
                    return listaItem;
                } 
                else {
                    return null;
                }
            }
        }        

        public TB_ITEM Salvar(ItemController prItem) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_ITEM entItem = new TB_ITEM {
                    CODIGOREFERENCIA = prItem.CODIGOREFERENCIA,
                    CLIENTE = prItem.CLIENTE,
                    NOME = prItem.NOME,
                    PESOBRUTO = prItem.PESOBRUTO,
                    PESOLIQUIDO = prItem.PESOLIQUIDO,
                    OBSERVACAO = prItem.OBSERVACAO,
                    CLASSIFICACAO = prItem.CLASSIFICACAO,
                    UNIDADEMEDIDA = prItem.UNIDADEMEDIDA,
                    CODIGO = prItem.CODIGO,
                    HANDLE = prItem.HANDLE,
                };

                if (entItem.HANDLE == 0) {
                    entItem.CODIGO = dbContext.TB_ITEM.Max(e => e.CODIGO) + 1;

                    dbContext.TB_ITEM.Add(entItem);
                } else {
                    dbContext.Entry(entItem).State = System.Data.Entity.EntityState.Modified;
                }

                dbContext.SaveChanges();

                return entItem;
            }
        }

        public bool Excluir(int prItem) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_ITEM entItem = new TB_ITEM {
                    HANDLE = prItem
                };
                var entry = dbContext.Entry(entItem);

                if(entry.State == System.Data.Entity.EntityState.Detached) {
                    dbContext.TB_ITEM.Attach(entItem);
                }

                int count = dbContext.TB_MOVIMENTACAO.Where(e => e.ITEM == prItem).Count();
                    count += dbContext.TB_ORDEM.Where(e => e.ITEM == prItem).Count();

                if (count > 0) {
                    return false;
                } else {
                    dbContext.TB_ITEM.Remove(entItem);
                    dbContext.SaveChanges();
                    return true;
                }
            }
        }

        public static int GetUnidadeMedida(int prItem) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaItem = dbContext.TB_ITEM.Find(prItem);

                return (int)entListaItem.UNIDADEMEDIDA;
            }
        }
    }

    public enum Classificacao: int {
        A = 1,
        B = 2,
        C = 3
    }

    public enum UnidadeMedida: int {
        UN = 1,
        KG = 2,
        PCT = 3,
        CX = 4
    }

}
