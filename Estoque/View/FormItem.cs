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
    public partial class FormItem: FormController {
        public FormItem(int prHandle = 0, bool prEditando = false) {
            InitializeComponent();

            Sistema.Handle = prHandle;
            PreencherInformacoes();
            AtualizarPermissaoFormulario(prEditando);            
        }              

        private void comboBoxCliente_DropDown(object sender, EventArgs e) {
            using(var dbContext = new EntidadeEstoque()) {
                var pessoa = from Pessoa in dbContext.TB_PESSOA
                             select Pessoa;

                comboBoxCliente.DataSource = pessoa.ToList();
                comboBoxCliente.DisplayMember = "NOME";       
                comboBoxCliente.ValueMember = "HANDLE";
            }
        }

        private void comboBoxClassificacaoItem_DropDown(object sender, EventArgs e) {
            comboBoxClassificacaoItem.DataSource = Enum.GetValues(typeof(Classificacao));
        }

        private void comboBoxUnidadeMedidaItem_DropDown(object sender, EventArgs e) {
            comboBoxUnidadeMedidaItem.DataSource = Enum.GetValues(typeof(UnidadeMedida));
        }

        private void buttonLimparItem_Click(object sender, EventArgs e) {
            LimparFormulario(this);
            this.textBoxCodigoItem.Text = "0";
            this.textBoxPesoBrutoItem.Text = "0.00";
            this.textBoxPesoLiquidoItem.Text = "0.00";

            PreencherInformacoes();

            this.textBoxNomeItem.Focus();
        }        

        private void PreencherInformacoes() {
            if(Sistema.Handle != 0) {
                ItemController Item = ItemController.GetDadosItem(Sistema.Handle);
                
                comboBoxClassificacaoItem.DataSource = Enum.GetValues(typeof(Classificacao));
                comboBoxClassificacaoItem.SelectedIndex = (int)(Classificacao)Item.CLASSIFICACAO - 1;

                comboBoxUnidadeMedidaItem.DataSource = Enum.GetValues(typeof(Classificacao));
                comboBoxUnidadeMedidaItem.SelectedIndex = (int)(UnidadeMedida)Item.UNIDADEMEDIDA - 1;

                using(var dbContext = new EntidadeEstoque()) {
                    var pessoa = from Pessoa in dbContext.TB_PESSOA
                                 where Pessoa.HANDLE == Item.CLIENTE
                                 select Pessoa;

                    comboBoxCliente.DataSource = pessoa.ToList();
                    comboBoxCliente.DisplayMember = "NOME";
                    comboBoxCliente.ValueMember = "HANDLE";
                    comboBoxCliente.SelectedIndex = 0;
                }

                textBoxCodigoItem.Text = Item.HANDLE.ToString();
                textBoxCodigoReferenciaItem.Text = Item.CODIGOREFERENCIA;
                textBoxNomeItem.Text = Item.NOME;
                textBoxPesoBrutoItem.Text = Item.PESOBRUTO.ToString();
                textBoxPesoLiquidoItem.Text = Item.PESOBRUTO.ToString();
            }
        }            

        private void buttonGravarItem_Click(object sender, EventArgs e) {
            if (CheckCampoObrigatorio()) {
                Salvar();
            }            
        }

        private bool CheckCampoObrigatorio() {
            if(String.IsNullOrEmpty(textBoxNomeItem.Text)) {
                MessageBox.Show("O campo nome é obrigatório");
                textBoxNomeItem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxCodigoReferenciaItem.Text)) {
                MessageBox.Show("O campo código referência é obrigatório");
                textBoxCodigoReferenciaItem.Focus();
                return false;

            } else if(comboBoxCliente.SelectedIndex == -1) {
                MessageBox.Show("O campo cliente é obrigatório");
                comboBoxCliente.Focus();
                return false;

            } else {
                return true;
            }
        }

        private void Salvar() {
            try {
                ItemController Item = new ItemController {
                    HANDLE = Sistema.Handle,
                    NOME = textBoxNomeItem.Text,
                    CODIGOREFERENCIA = textBoxCodigoReferenciaItem.Text,
                    PESOBRUTO = Convert.ToDecimal("0" + textBoxPesoBrutoItem.Text),
                    PESOLIQUIDO = Convert.ToDecimal("0" + textBoxPesoLiquidoItem.Text),
                    CODIGO = Convert.ToInt32("0" + textBoxCodigoItem.Text)
                };

                if(comboBoxCliente.SelectedValue != null) {
                    Item.CLIENTE = (int)(comboBoxCliente.SelectedValue);
                }

                if(comboBoxUnidadeMedidaItem.SelectedItem != null) {
                    Item.UNIDADEMEDIDA = (int)comboBoxUnidadeMedidaItem.SelectedValue;
                }

                if(comboBoxClassificacaoItem.SelectedValue != null) {
                    Item.CLASSIFICACAO = (int)comboBoxClassificacaoItem.SelectedValue;
                }

                TB_ITEM ItemRetorno = Item.Salvar(Item);
                textBoxCodigoItem.Text = ItemRetorno.HANDLE.ToString();
                Sistema.Handle = ItemRetorno.HANDLE; 

                MessageBox.Show("Registro salvo com sucesso!"); 
                AtualizarPermissaoBotao(true);

            } catch(Exception ex) {
                MessageBox.Show("Erro ao gravar o registro" + ex.Message);                
            }
        }

        private void buttonExcluirItem_Click(object sender, EventArgs e) {
            if (Sistema.Handle != 0) {
                DialogResult resposta = MessageBox.Show("Deseja excluir o registro?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if(resposta == DialogResult.Yes) {
                    ItemController Item = new ItemController();
                    if(!Item.Excluir(Sistema.Handle)) {
                        MessageBox.Show("O registro não pode estar vinculado a outros registros");
                    } else {
                        this.Close();                    
                    }
                }                
            } else {
                MessageBox.Show("Nenhum registro selecionado");
            }
        }
    }
}
