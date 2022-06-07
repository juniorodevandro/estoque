using Estoque.Controller;
using Estoque.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.View {
    public partial class FormUsuario: FormController {
        public FormUsuario(int prHandle = 0, bool prEditando = false) {

            InitializeComponent();

            Sistema.Handle = prHandle;
            PreencherInformacoes();
            AtualizarPermissaoFormulario(prEditando);  
        }

        private void buttonGravarUsuario_Click(object sender, EventArgs e) {
            if (CheckCampoObrigatorio()) {
                Salvar();
            }
            AtualizarPermissaoBotao(true);
        }

        private bool CheckCampoObrigatorio() {
            if(String.IsNullOrEmpty(textBoxLoginUsuario.Text)) {
                MessageBox.Show("O campo usuário é obrigatorio");
                textBoxLoginUsuario.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxSenhaUsuario.Text)) {
                MessageBox.Show("O campo senha é obrigatorio");
                textBoxSenhaUsuario.Focus();
                return false;

            } else {
                return true;
            }
        }

        private void Salvar() {
            try {
                LoginController Usuario = new LoginController {
                    HANDLE = Sistema.Handle,
                    CODIGO = Convert.ToInt32("0" + textBoxCodigoUsuario.Text),
                    USUARIO = textBoxLoginUsuario.Text,
                    SENHA = textBoxSenhaUsuario.Text
                };

                TB_USUARIO UsuarioRetorno = Usuario.Salvar(Usuario);
                textBoxCodigoUsuario.Text = UsuarioRetorno.HANDLE.ToString();
                Sistema.Handle = UsuarioRetorno.HANDLE;
                MessageBox.Show("Registro salvo com sucesso!");                

            } catch(Exception ex) {
                MessageBox.Show("Erro ao gravar o registro" + ex.Message);                
            }
        }

        private void buttonExcluirUsuario_Click(object sender, EventArgs e) {
            if(Convert.ToInt32("0" + textBoxCodigoUsuario.Text) > 0) {
                DialogResult resposta = MessageBox.Show("Deseja excluir o registro?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if(resposta == DialogResult.Yes) {
                    LoginController Usuario = new LoginController();
                    Usuario.Excluir(Sistema.Handle);   
                    
                    this.Close();
                }
            }
        }

        private void PreencherInformacoes() {
            if (Sistema.Handle != 0) {
                LoginController Usuario = LoginController.GetDadosUsuario(Sistema.Handle);

                textBoxCodigoUsuario.Text = Usuario.HANDLE.ToString();
                textBoxLoginUsuario.Text = Usuario.USUARIO;
                textBoxSenhaUsuario.Text = Usuario.SENHA;
            }
        }

        private void buttonLimparUsuario_Click(object sender, EventArgs e) {
            LimparFormulario(this);

            this.textBoxCodigoUsuario.Text = "0";

            PreencherInformacoes();
            this.textBoxLoginUsuario.Focus();
        }
    }
}
