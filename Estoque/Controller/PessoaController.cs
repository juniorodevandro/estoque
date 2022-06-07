using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque {
    public class PessoaController: TB_PESSOA {
        public static PessoaController GetDadosPessoa(int prPessoa) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaItem = dbContext.TB_PESSOA.Find(prPessoa);

                if(entListaItem != null) {
                    PessoaController Pessoa = new PessoaController();

                    Pessoa.HANDLE = entListaItem.HANDLE;
                    Pessoa.NOME = entListaItem.NOME;
                    Pessoa.CPF = entListaItem.CPF;
                    Pessoa.TELEFONE = entListaItem.TELEFONE;
                    Pessoa.ENDERECO = entListaItem.ENDERECO;
                    Pessoa.OBSERVACAO = entListaItem.OBSERVACAO;

                    return Pessoa;
                } else {
                    return null;
                }
            }
        }
        public static List<PessoaController>GetPessoaByNome(string prNome) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaPessoa = dbContext.TB_PESSOA.Where(v => v.NOME.Contains(prNome)).OrderBy(o => o.NOME);

                if(entListaPessoa != null) {
                    List<PessoaController> listaPessoa = new List<PessoaController>();

                    foreach(var ent in entListaPessoa) {
                        listaPessoa.Add(new PessoaController {
                            HANDLE = ent.HANDLE,
                            NOME = ent.NOME,
                            CODIGO = ent.CODIGO,
                            CPF = ent.CPF,
                            OBSERVACAO = ent.OBSERVACAO,
                            ENDERECO = ent.ENDERECO,
                            TELEFONE = ent.TELEFONE
                        });
                    }
                    return listaPessoa; 
                }
                else {
                    return null;
                }
            }
        }   

        public TB_PESSOA Salvar(PessoaController prPessoa) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_PESSOA entPessoa = new TB_PESSOA {
                    NOME = prPessoa.NOME,
                    TELEFONE = prPessoa.TELEFONE,
                    CPF = prPessoa.CPF,
                    CODIGO = prPessoa.CODIGO,
                    OBSERVACAO = prPessoa.OBSERVACAO, 
                    HANDLE = prPessoa.HANDLE,
                    ENDERECO = prPessoa.ENDERECO,
                };

                if(entPessoa.HANDLE == 0) {
                    entPessoa.CODIGO = dbContext.TB_PESSOA.Max(e => e.CODIGO) + 1;

                    dbContext.TB_PESSOA.Add(entPessoa);
                } else {
                    dbContext.Entry(entPessoa).State = System.Data.Entity.EntityState.Modified;
                }

                dbContext.SaveChanges();

                return entPessoa;
            }
        }

        public bool Excluir(int prPessoa) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_PESSOA entPessoa = new TB_PESSOA();

                entPessoa.HANDLE = prPessoa;
                var entry = dbContext.Entry(entPessoa);

                if(entry.State == System.Data.Entity.EntityState.Detached) {
                    dbContext.TB_PESSOA.Attach(entPessoa);
                }

                int count = dbContext.TB_MOVIMENTACAO.Where(e => e.CLIENTE == prPessoa).Count();
                    count += dbContext.TB_ORDEM.Where(e => e.CLIENTE == prPessoa).Count();
                    count += dbContext.TB_ITEM.Where(e => e.CLIENTE == prPessoa).Count();

                if(count > 0) {
                    return false;
                } else {
                    dbContext.TB_PESSOA.Remove(entPessoa);
                    dbContext.SaveChanges();
                    return true;

                }

            }
        }
    }
}
