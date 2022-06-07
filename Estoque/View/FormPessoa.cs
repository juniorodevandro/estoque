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
    public partial class FormPessoa: FormController {
        public FormPessoa(int prHandle = 0, bool prEditando = false) {
            InitializeComponent();

            Sistema.Handle = prHandle;
            PreencherInformacoes();
            AtualizarPermissaoFormulario(prEditando);
        }

        private void buttonLimparPesssoa_Click(object sender, EventArgs e) {
            LimparFormulario(this);

            this.textBoxCodigoPessoa.Text = "0";
            PreencherInformacoes();

            this.textBoxNomePessoa.Focus();
        }

        private void PreencherInformacoes() {
            if(Sistema.Handle != 0) {
                PessoaController Pessoa = PessoaController.GetDadosPessoa(Sistema.Handle);

                textBoxNomePessoa.Text = Pessoa.NOME;
                textBoxCodigoPessoa.Text = Pessoa.HANDLE.ToString();
                textBoxEndereco.Text = Pessoa.ENDERECO.ToString();
                maskedTextBoxTelefonePessoa.Text = Pessoa.TELEFONE;
                maskedTextBoxCpf.Text = Pessoa.CPF;
                textBoxObservacao.Text = Pessoa.OBSERVACAO;
            }
        }

        private void buttonGravarPesssoa_Click(object sender, EventArgs e) {
            if(CheckCampoObrigatorio()) { 
                Salvar();                                
            }
        }

        private bool CheckCampoObrigatorio() {
            if (String.IsNullOrEmpty(textBoxNomePessoa.Text)) {
                MessageBox.Show("O campo nome é obrigatório");
                textBoxNomePessoa.Focus();
                return false;

            } else if (String.IsNullOrEmpty(textBoxEndereco.Text)) {
                MessageBox.Show("O campo CPF é obrigatório");
                textBoxEndereco.Focus();
                return false;

            } else {
                return true;
            }
        }

        private void Salvar() {
            try {
                PessoaController Pessoa = new PessoaController {
                    HANDLE = Sistema.Handle,
                    NOME = textBoxNomePessoa.Text.ToUpper(),
                    TELEFONE = maskedTextBoxTelefonePessoa.Text,
                    CPF = maskedTextBoxCpf.Text,
                    CODIGO = Convert.ToInt32("0" + textBoxCodigoPessoa.Text),
                    OBSERVACAO = textBoxObservacao.Text,
                    ENDERECO = textBoxEndereco.Text,
                };

                TB_PESSOA PessoaRetorno = Pessoa.Salvar(Pessoa);
                textBoxCodigoPessoa.Text = PessoaRetorno.HANDLE.ToString();
                Sistema.Handle = PessoaRetorno.HANDLE;
                
                MessageBox.Show("Registro salvo com sucesso!");
                AtualizarPermissaoBotao(true);

            } catch(Exception ex) {
                MessageBox.Show("Erro ao gravar o registro" + ex.Message);                
            }
        }

        private void buttonExcluirPessoa_Click(object sender, EventArgs e) {
            if(Sistema.Handle != 0) {
                DialogResult resposta = MessageBox.Show("Deseja excluir o registro?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if(resposta == DialogResult.Yes) {
                    PessoaController Pessoa = new PessoaController();
                    if(!Pessoa.Excluir(Sistema.Handle)) {
                        MessageBox.Show("O registro não pode estar vinculado a outros registros!");
                    } else {
                        this.Close();
                    }
                }
            }
        }
    }
}
