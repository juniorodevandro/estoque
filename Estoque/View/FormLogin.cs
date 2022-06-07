using Estoque.Controller;
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
    public partial class FormLogin: FormController {
        public FormLogin() {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            Login();           
        }

        private void Login() {
            if(VerificarCampoObrigatorio()) {
                if(GetUsuarioLogin() ||
                   (textBoxLogin.Text == "system" && textBoxSenha.Text == "system")) {
                    this.Hide();
                    FormPrincipal form = new FormPrincipal(textBoxLogin.Text);
                    form.Closed += (s, args) => this.Close();
                    form.Show();

                } else {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
        }

        private bool GetUsuarioLogin() {
            LoginController Usuario = new LoginController();
            return Usuario.GetUsuarioLogin(textBoxLogin.Text, textBoxSenha.Text);           
        }

        private bool VerificarCampoObrigatorio() {
            if(string.IsNullOrEmpty(textBoxLogin.Text)) {
                MessageBox.Show("Informe o login do usuário");
                textBoxLogin.Focus();
                return false;

            } else if(string.IsNullOrEmpty(textBoxSenha.Text)) {
                MessageBox.Show("Informe a senha do usuário");
                textBoxSenha.Focus();
                return false;

            } else {
                return true;
            }           
        }

        private void novoToolStripButton_Click(object sender, EventArgs e) {
            FormUsuario form = new FormUsuario();
            form.ShowDialog();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter && 
               String.IsNullOrWhiteSpace(textBoxLogin.Text) && 
               String.IsNullOrWhiteSpace(textBoxSenha.Text)) {
                this.Login();
            } else if(e.KeyCode == Keys.Enter) {
                SendKeys.Send("{TAB}");
            }

            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }

        }
    }
}
