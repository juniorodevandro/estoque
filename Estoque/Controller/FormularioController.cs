using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque.Controller {
    public partial class FormController: Form {
        protected SistemaController Sistema = new SistemaController();
        private void InitializeComponent() {
        }

        protected virtual void AtualizarPermissaoBotao(bool prEditando = false) {
            for(int i = 0; i < this.Controls.Count; i++) {
                if(this.Controls[i] is Button) {
                    if(this.Controls[i].Text == "Excluir" && Sistema.Handle == 0) {
                        this.Controls[i].Enabled = false;
                    } else if(!prEditando) {
                        this.Controls[i].Enabled = false;
                    } else {
                        this.Controls[i].Enabled = true;
                    }
                }
            }
        }

        protected void AtualizarPermissaoFormulario(bool prEditando) {
            if(!prEditando) {
                for(int i = 0; i < this.Controls.Count; i++) {
                    if(this.Controls[i] is TextBox) {
                        this.Controls[i].Enabled = false;
                        this.Controls[i].BackColor = Color.White;
                    }

                    if(this.Controls[i] is ComboBox) {
                        this.Controls[i].Enabled = false;
                        this.Controls[i].BackColor = Color.White;
                    }

                    if(this.Controls[i] is MaskedTextBox) {
                        this.Controls[i].Enabled = false;
                        this.Controls[i].BackColor = Color.White;
                    }

                    if(this.Controls[i] is DateTimePicker) {
                        this.Controls[i].Enabled = false;
                        this.Controls[i].BackColor = Color.White;
                    }
                }
            }
            AtualizarPermissaoBotao(prEditando);
        }

        protected static void LimparFormulario(Control ctrl) {
            foreach(Control c in ctrl.Controls) {
                if(c is TextBox && c.Enabled) {
                    ((TextBox)c).Text = "";
                } else if(c is ComboBox) {
                    ((ComboBox)c).SelectedIndex = -1;
                } else if(c is MaskedTextBox) {
                    ((MaskedTextBox)c).Text = "";
                }
            }
        }

        protected bool GetExcluirOnClick() {
            if (Sistema.Handle != 0 ) {
                DialogResult resposta = MessageBox.Show("Deseja excluir o registro?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if(resposta == DialogResult.Yes) {
                    return true;
                } else {
                    return false;
                }
            }
            else {
                MessageBox.Show("Nenhum registro selecionado!");
                return false;
            }
        }

        protected void FormController_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
            }

            if(e.KeyCode == Keys.Enter || (e.KeyCode == Keys.Return)) {
                SendKeys.Send("{TAB}");
            }
        }

        protected void textBoxToMoney(object sender, EventArgs e) {
            if(sender != null) {
                TextBox textBox = sender as TextBox;
                if(!String.IsNullOrEmpty(textBox.Text)) {
                    textBox.Text = Convert.ToDecimal(textBox.Text).ToString("C");
                }
            }
        }

        protected void textBoxToCurrency(object sender, EventArgs e) {
            if (sender != null) {
                TextBox textBox = sender as TextBox;           

                if (!String.IsNullOrEmpty(textBox.Text)) {
                    var valor = Convert.ToDecimal(textBox.Text);
                    textBox.Text = String.Format("{0:N2}", valor);
                }
            }
        }

        protected void textBoxCurrency_KeyPress(object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',')) {
                e.Handled = true;
            }

            if((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1)) {
                e.Handled = true;
            }
        }

        protected enum ListaFormulario: int {
            ListaPessoa = 1,
            ListaUsuario = 2,
            ListaItem = 3,
            ListaOrdem = 4,
            ListaMovimentacao = 5
        }

        protected void textBox_Click(object sender, EventArgs e) {
            (sender as TextBoxBase).SelectAll();
        }
    }
}
