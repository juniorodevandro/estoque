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
    public partial class FormOrdem: FormController {
        private decimal PesoLiquido = 0;
        private decimal PesoBruto = 0;

        public FormOrdem(int prHandle = 0, bool prEditando = false) {
            InitializeComponent();

            Sistema.Handle = prHandle;

            PreencherInformacoes();
            AtualizarPermissaoFormulario(prEditando);
            AtualizarPermissaoBotaoMovimentacao(prEditando);
        }

        private void buttonGravarItem_Click(object sender, EventArgs e) {
            if(CheckCampoObrigatorio()) {
                Salvar();
            }
        }

        private void PreencherInformacoes() {
            if(Sistema.Handle != 0) {
                OrdemController Ordem = OrdemController.GetDadosOrdem(Sistema.Handle);

                using(var dbContext = new EntidadeEstoque()) {
                    var pessoa = from Pessoa in dbContext.TB_PESSOA
                                 where Pessoa.HANDLE == Ordem.CLIENTE
                                 select Pessoa;

                    comboBoxClienteOrdem.DataSource = pessoa.ToList();
                    comboBoxClienteOrdem.DisplayMember = "NOME";
                    comboBoxClienteOrdem.ValueMember = "HANDLE";
                    comboBoxClienteOrdem.SelectedIndex = 0;
                   
                    var item = from Item in dbContext.TB_ITEM
                              where Item.HANDLE == Ordem.ITEM
                             select Item;

                    comboBoxItemOrdem.DataSource = item.ToList();
                    comboBoxItemOrdem.DisplayMember = "NOME";
                    comboBoxItemOrdem.ValueMember = "HANDLE";
                    comboBoxItemOrdem.SelectedIndex = 0;

                    comboBoxTipoMovimentacaoOrdem.DataSource = Enum.GetValues(typeof(TipoMovimentacao));
                    comboBoxTipoMovimentacaoOrdem.SelectedIndex = (int)(TipoMovimentacao)Ordem.TIPOMOVIMENTACAO - 1;

                }

                textBoxNumeroPedidoOrdem.Text = Ordem.NUMEROPEDIDO;
                dataOrdem.Text = Ordem.DATA.ToString();
                comboBoxTipoMovimentacaoOrdem.SelectedItem = Ordem.TIPOMOVIMENTACAO;
                textBoxCodigoOrdem.Text = Ordem.HANDLE.ToString();
                textBoxQuantidadeOrdem.Text = Ordem.QUANTIDADE.ToString();
                textBoxNumeroPedidoOrdem.Text = Ordem.NUMEROPEDIDO;
                textBoxPesoBrutoOrdem.Text = Ordem.PESOBRUTO.ToString();
                textBoxPesoLiquidoOrdem.Text = Ordem.PESOLIQUIDO.ToString();
                textBoxValorTotalOrdem.Text = Ordem.VALORTOTAL.ToString();
                textBoxValorUnitarioOrdem.Text = Ordem.VALORUNITARIO.ToString();
                texBoxObservacao.Text = Ordem.OBSERVACAO;
            }
        }

        private bool CheckCampoObrigatorio() {
            if(comboBoxClienteOrdem.SelectedIndex == -1) {
                MessageBox.Show("O campo cliente é obrigatório");
                comboBoxClienteOrdem.Focus();
                return false;

            } else if(comboBoxTipoMovimentacaoOrdem.SelectedIndex == -1) {
                MessageBox.Show("O campo tipo de movimentação é obrigatório");
                comboBoxTipoMovimentacaoOrdem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(dataOrdem.Text)) {
                MessageBox.Show("O campo data é obrigatório");
                dataOrdem.Focus();
                return false;

            } else if(comboBoxItemOrdem.SelectedIndex == -1) {
                MessageBox.Show("O campo item é obrigatório");
                comboBoxItemOrdem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxQuantidadeOrdem.Text)) {
                MessageBox.Show("O campo quantidade é obrigatório");
                textBoxQuantidadeOrdem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxValorUnitarioOrdem.Text)) {
                MessageBox.Show("O campo valor unitário é obrigatório");
                textBoxValorUnitarioOrdem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxValorTotalOrdem.Text)) {
                MessageBox.Show("O campo valor total é obrigatório");
                textBoxValorUnitarioOrdem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxPesoLiquidoOrdem.Text)) {
                MessageBox.Show("O campo peso líquido é obrigatório");
                textBoxPesoLiquidoOrdem.Focus();
                return false;

            } else if(String.IsNullOrEmpty(textBoxPesoBrutoOrdem.Text)) {
                MessageBox.Show("O campo peso bruto é obrigatório");
                textBoxPesoLiquidoOrdem.Focus();
                return false;

            } else {
                return true;
            }
        }

        private void Salvar() {
            OrdemController Ordem = new OrdemController {
                HANDLE = Sistema.Handle,
                CODIGO = Convert.ToInt32("0" + textBoxCodigoOrdem.Text),
                NUMEROPEDIDO = textBoxNumeroPedidoOrdem.Text,
                QUANTIDADE = Convert.ToDecimal("0" + textBoxQuantidadeOrdem.Text),
                PESOLIQUIDO = Convert.ToDecimal("0" + textBoxPesoLiquidoOrdem.Text),
                PESOBRUTO = Convert.ToDecimal("0" + textBoxPesoBrutoOrdem.Text),
                VALORTOTAL = Convert.ToDecimal("0" + textBoxValorTotalOrdem.Text),
                VALORUNITARIO = Convert.ToDecimal("0" + textBoxValorUnitarioOrdem.Text),
                OBSERVACAO = texBoxObservacao.Text,
                DATA = dataOrdem.Value,
                GEROUMOVIMENTACAO = "N"
            };

            if(comboBoxTipoMovimentacaoOrdem.SelectedValue != null) {
                Ordem.TIPOMOVIMENTACAO = (int)comboBoxTipoMovimentacaoOrdem.SelectedValue;
            }

            if(comboBoxClienteOrdem.SelectedValue != null) {
                Ordem.CLIENTE = (int)comboBoxClienteOrdem.SelectedValue;
            }

            if(comboBoxItemOrdem.SelectedValue != null) {
                Ordem.ITEM = (int)comboBoxItemOrdem.SelectedValue;
            }

            try {
                TB_ORDEM OrdemRetorno = Ordem.Salvar(Ordem);
                textBoxCodigoOrdem.Text = OrdemRetorno.HANDLE.ToString();
                Sistema.Handle = OrdemRetorno.HANDLE;

                MessageBox.Show("Registro salvo com sucesso!");

                AtualizarPermissaoBotao(true);
                AtualizarPermissaoBotaoMovimentacao(true);

            } catch(Exception ex) {
                MessageBox.Show("Erro ao gravar o registro" + ex.Message);
            }
        }

        private void comboBoxItemOrdem_DropDown(object sender, EventArgs e) {
            using(var dbContext = new EntidadeEstoque()) {
                int Cliente = 0;

                if (comboBoxClienteOrdem.SelectedValue != null) {
                    Cliente = (int)comboBoxClienteOrdem.SelectedValue;                    
                }

                var item = from Item in dbContext.TB_ITEM
                           where Item.CLIENTE == Cliente
                           select Item;

                comboBoxItemOrdem.DataSource = item.ToList();
                comboBoxItemOrdem.DisplayMember = "NOME";
                comboBoxItemOrdem.ValueMember = "HANDLE";
            }
        }

        private void comboBoxTipoMovimentacaoOrdem_DropDown(object sender, EventArgs e) {
            comboBoxTipoMovimentacaoOrdem.DataSource = Enum.GetValues(typeof(TipoMovimentacao));
        }

        private void comboBoxClienteOrdem_DropDown(object sender, EventArgs e) {
            using(var dbContext = new EntidadeEstoque()) {
                var pessoa = from Pessoa in dbContext.TB_PESSOA
                             select Pessoa;

                comboBoxClienteOrdem.DataSource = pessoa.ToList();
                comboBoxClienteOrdem.DisplayMember = "NOME";
                comboBoxClienteOrdem.ValueMember = "HANDLE";
            }
        }

        private void buttonExcluirOrdem_Click(object sender, EventArgs e) {
            if(Convert.ToInt32("0" + textBoxCodigoOrdem.Text) > 0) {
                DialogResult resposta = MessageBox.Show("Deseja excluir o registro?",
                                                        "Excluir",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question,
                                                        MessageBoxDefaultButton.Button2);

                if(resposta == DialogResult.Yes) {
                    OrdemController Ordem = new OrdemController();
                    if(!Ordem.Excluir(Sistema.Handle)) {
                        MessageBox.Show("O registro não pode estar vinculado a outros registros");
                    } else {
                        this.Close();
                    }
                }
            }
        }

        private void comboBoxItemOrdem_SelectedIndexChanged(object sender, EventArgs e) {
            int ItemHandle = 0;

            if(comboBoxItemOrdem.SelectedItem != null) {
                ItemHandle = ((TB_ITEM)comboBoxItemOrdem.SelectedItem).HANDLE;
            }

            if(ItemHandle > 0) {
                ItemController Item = ItemController.GetDadosItem(ItemHandle);

                this.PesoLiquido = Convert.ToDecimal("0" + Item.PESOLIQUIDO);
                this.PesoBruto = Convert.ToDecimal("0" + Item.PESOBRUTO);

                textBoxPesoLiquidoOrdem.Text = PesoLiquido.ToString();
                textBoxPesoBrutoOrdem.Text = PesoBruto.ToString();

                if(PesoLiquido > 0) {
                    textBoxPesoLiquidoOrdem.ReadOnly = true;
                } else {
                    textBoxPesoLiquidoOrdem.ReadOnly = false;
                }

                if(PesoBruto > 0) {
                    textBoxPesoBrutoOrdem.ReadOnly = true;
                } else {
                    textBoxPesoBrutoOrdem.ReadOnly = false;
                }
            }
        }

        private void buttonLimparItem_Click(object sender, EventArgs e) {
            LimparFormulario(this);

            this.textBoxCodigoOrdem.Text = "0";
            this.textBoxPesoBrutoOrdem.Text = "0.00";
            this.textBoxPesoLiquidoOrdem.Text = "0.00";
            this.textBoxValorUnitarioOrdem.Text = "0,00";
            this.textBoxValorTotalOrdem.Text = "0,00";

            PreencherInformacoes();

            this.comboBoxClienteOrdem.Focus();
        }

        private void buttonGerarMovimentacao_Click(object sender, EventArgs e) {
            if(Sistema.Handle != 0) {
                if(OrdemController.GerarMovimentacao(Sistema.Handle)) {
                    AtualizarPermissaoFormulario(false);
                    AtualizarPermissaoBotaoMovimentacao();
                    MessageBox.Show("Movimentação gerada!");
                }
                else {
                    MessageBox.Show("Ocorreu um erro ao gerar a movimentação!");
                }
            }
        }
        
        private void AtualizarPermissaoBotaoMovimentacao(bool prEditando = false) {
            bool Movimentacao = OrdemController.GerouMovimentacao(Sistema.Handle);

            if(!Movimentacao && Sistema.Handle > 0 && prEditando) {
                buttonGerarMovimentacao.Enabled = true;
            } else {
                buttonGerarMovimentacao.Enabled = false;
            }

            if(Movimentacao && Sistema.Handle > 0) {
                AtualizarPermissaoFormulario(false);
            }
        }

        private void textBoxQuantidadeOrdem_Leave(object sender, EventArgs e) {
            textBoxToCurrency(sender, e);

            decimal quantidade = Convert.ToDecimal("0" + textBoxQuantidadeOrdem.Text);
            decimal valorUnitario = Convert.ToDecimal("0" + textBoxValorUnitarioOrdem.Text);
            decimal pesoLiquido = PesoLiquido > 0 ? PesoLiquido : Convert.ToDecimal("0" + textBoxPesoLiquidoOrdem.Text);
            decimal pesoBruto = PesoLiquido > 0 ? PesoLiquido : Convert.ToDecimal("0" + textBoxPesoBrutoOrdem.Text);

            textBoxValorTotalOrdem.Text = (quantidade * valorUnitario).ToString();

            textBoxPesoLiquidoOrdem.Text = (quantidade * pesoLiquido).ToString();
            textBoxPesoBrutoOrdem.Text = (quantidade * pesoBruto).ToString();
        }

        private void textBoxValorUnitarioOrdem_Leave(object sender, EventArgs e) {
            textBoxToCurrency(sender, e);

            decimal quantidade = Convert.ToDecimal("0" + textBoxQuantidadeOrdem.Text);
            decimal valorUnitario = Convert.ToDecimal("0" + textBoxValorUnitarioOrdem.Text);

            textBoxValorTotalOrdem.Text = (quantidade * valorUnitario).ToString();
        }

        private void textBoxValorTotalOrdem_Leave(object sender, EventArgs e) {
            textBoxToCurrency(sender, e);

            decimal quantidade = Convert.ToDecimal("0" + textBoxQuantidadeOrdem.Text);
            decimal valorTotal = Convert.ToDecimal("0" + textBoxValorTotalOrdem.Text);

            if(quantidade > 0) {
                textBoxValorUnitarioOrdem.Text = (valorTotal / quantidade).ToString();
            }
        }
    }
}
