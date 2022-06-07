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
    public partial class FormMovimentacao: FormController {
        public FormMovimentacao(int prHandle = 0) {

            Sistema.Handle = prHandle;  
            InitializeComponent();

            PreencherInformacoes();
            AtualizarPermissaoFormulario(false);
        }

        private void PreencherInformacoes() {
            if(Sistema.Handle != 0) {
                MovimentacaoController Movimentacao = MovimentacaoController.GetDadosMovimentacao(Sistema.Handle);

                comboBoxTipoMovimentacaoMovimentacao.DataSource = Enum.GetValues(typeof(TipoMovimentacao));
                comboBoxTipoMovimentacaoMovimentacao.SelectedIndex = (int)(TipoMovimentacao)Movimentacao.TIPOMOVIMENTACAO - 1;

                using(var dbContext = new EntidadeEstoque()) {
                    var pessoa = from Pessoa in dbContext.TB_PESSOA
                                 where Pessoa.HANDLE == Movimentacao.CLIENTE
                                 select Pessoa;

                    comboBoxClienteMovimentacao.DataSource = pessoa.ToList();
                    comboBoxClienteMovimentacao.DisplayMember = "NOME";
                    comboBoxClienteMovimentacao.ValueMember = "HANDLE";
                    comboBoxClienteMovimentacao.SelectedIndex = 0;

                    var item = from Item in dbContext.TB_ITEM
                               where Item.HANDLE == Movimentacao.ITEM
                               select Item;

                    comboBoxItemMovimentacao.DataSource = pessoa.ToList();
                    comboBoxItemMovimentacao.DisplayMember = "NOME";
                    comboBoxItemMovimentacao.ValueMember = "HANDLE";
                    comboBoxItemMovimentacao.SelectedIndex = 0;

                    comboBoxOrdem.Text = Movimentacao.ORDEM.ToString();
                }

                dataMovimentacao.Text = Movimentacao.DATA.ToString();
                textBoxValorUnitairoMovimentacao.Text = Movimentacao.VALORUNITARIO.ToString();
                textBoxValorTotalMovimentacao.Text = Movimentacao.VALORTOTAL.ToString();
                textBoxQuantidade.Text = Movimentacao.QUANTIDADE.ToString();
                textBoxCodigo.Text = Movimentacao.HANDLE.ToString();
                textBoxPesoBrutoMovimentacao.Text = Movimentacao.PESOBRUTO.ToString();
                textBoxPesoLiquidoMovimentacao.Text = Movimentacao.PESOBRUTO.ToString();
                textBoxQuantidade.Text = Movimentacao.QUANTIDADE.ToString();
            }
        }
    }
}
