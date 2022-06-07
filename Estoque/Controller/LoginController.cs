using Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Controller {
    public class LoginController: TB_USUARIO {

        public static LoginController GetDadosUsuario(int prUsuario) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaUsuario = dbContext.TB_USUARIO.Find(prUsuario);

                if(entListaUsuario != null) {
                    LoginController Usuario = new LoginController {
                        HANDLE = entListaUsuario.HANDLE,
                        SENHA = entListaUsuario.SENHA,
                        USUARIO = entListaUsuario.USUARIO,
                        CODIGO = entListaUsuario.CODIGO
                    };

                    return Usuario;

                } else {
                    return null;
                }
            }
        }

        public static List<LoginController> GetUsuarioByUsuario(string prUsuario) {
            using(var dbContext = new EntidadeEstoque()) {
                var entListaUsuario = dbContext.TB_USUARIO.Where(v => v.USUARIO.Contains(prUsuario)).OrderBy(o => o.USUARIO);

                if(entListaUsuario != null) {
                    List<LoginController> listaUsuario = new List<LoginController>();

                    foreach(var ent in entListaUsuario) {
                        listaUsuario.Add(new LoginController {
                            HANDLE = ent.HANDLE,
                            CODIGO = ent.CODIGO,
                            USUARIO = ent.USUARIO
                        });
                    }
                    return listaUsuario;

                } else {
                    return null;
                }
            }
        }

        public bool GetUsuarioLogin(string prLogin, string prSenha) {
            using(var dbContext = new EntidadeEstoque()) {
                return dbContext.Database.SqlQuery<int>("SELECT 1 " +
                                                        "  FROM TB_USUARIO" +
                                                        " WHERE USUARIO = " + "'" + prLogin + "'" +
                                                        "   AND SENHA = " + "'" + prSenha + "'"
                                                        ).Count() > 0;
            }
        }

        public TB_USUARIO Salvar(LoginController prUsuario) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_USUARIO entUsuario = new TB_USUARIO {
                    CODIGO = prUsuario.CODIGO,                    
                    SENHA = prUsuario.SENHA,
                    USUARIO = prUsuario.USUARIO,
                    HANDLE = prUsuario.HANDLE
                };

                if(entUsuario.HANDLE == 0) {
                    entUsuario.CODIGO = dbContext.TB_USUARIO.Max(e => e.CODIGO + 1);

                    dbContext.TB_USUARIO.Add(entUsuario);
                } else {
                    dbContext.Entry(entUsuario).State = System.Data.Entity.EntityState.Modified;
                }

                dbContext.SaveChanges();

                return entUsuario;
            }
        }

        public void Excluir(int prUsuario) {
            using(var dbContext = new EntidadeEstoque()) {
                TB_USUARIO entUsuario = new TB_USUARIO();

                entUsuario.HANDLE = prUsuario;
                var entry = dbContext.Entry(entUsuario);

                if(entry.State == System.Data.Entity.EntityState.Detached) {
                    dbContext.TB_USUARIO.Attach(entUsuario);
                }
                
                dbContext.TB_USUARIO.Remove(entUsuario);
                dbContext.SaveChanges();
            }
        }
    }    
}
