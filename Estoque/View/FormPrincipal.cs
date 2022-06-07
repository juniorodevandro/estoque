using Estoque.Controller;
using Estoque.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque {
    public partial class FormPrincipal: FormController {
        int Formulario;

        public FormPrincipal(string prLogin) {            
            this.Formulario = 0;
            Sistema.Handle = 0;

            InitializeComponent();

            dataGrid.Columns[0].Visible = false;

            if(!String.IsNullOrEmpty(prLogin)) {
                this.Text += " - " + prLogin;
            }

            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void pictureBoxMovimentacao_DoubleClick(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaMovimentacao;
            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void pictureBoxOrdem_DoubleClick(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaOrdem;
            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void pictureBoxItem_DoubleClick(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaItem;
            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void pictureBoxPessoa_DoubleClick(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaPessoa;
            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void AbrirFormByFormulario(bool prEditando = false) {
            try {
                try {

                    switch(this.Formulario) {
                        //-- ListaPessoa
                        case 1:
                            var formPessoa = new FormPessoa(Sistema.Handle, prEditando);
                            formPessoa.ShowDialog();
                            break;

                        //-- ListaUsuario
                        case 2:
                            var formUsuario = new FormUsuario(Sistema.Handle, prEditando);
                            formUsuario.ShowDialog();
                            break;

                        //-- ListaItem
                        case 3:
                            var formItem = new FormItem(Sistema.Handle, prEditando);
                            formItem.ShowDialog();
                            break;

                        //-- ListaOrdem 
                        case 4:
                            var formOrdem = new FormOrdem(Sistema.Handle, prEditando);
                            formOrdem.ShowDialog();
                            break;

                        //-- ListaMovimentacao
                        case 5:
                            var formMovimentacao = new FormMovimentacao(Sistema.Handle);
                            formMovimentacao.ShowDialog();
                            break;
                    }

                    AbrirListagemByFormulario();
                
                } finally {
                    Sistema.Handle = 0;
                }
            } catch(Exception ex) {
                MessageBox.Show("Ocorreu um erro ao abri o formulário: " + ex.Message);
            }
        }

        private void AbrirListagemByFormulario() {
            try {
                switch(this.Formulario) {

                    //-- ListaPessoa
                    case 1:
                        titulo.Text = "Pessoa";
                        labelDataGrid.Text = "Nome";
                        labelDataGrid.Left = 330;

                        CarregarDataGridPessoa();
                        break;

                    //-- ListaUsuario
                    case 2:
                        labelDataGrid.Text = "Login";
                        titulo.Text = "Usuário";
                        labelDataGrid.Left = 330;

                        CarregarDataGridUsuario();
                        break;

                    //-- ListaItem
                    case 3:
                        labelDataGrid.Text = "Código referência";
                        labelDataGrid.Left = 270;
                        titulo.Text = "Item";

                        CarregarDataGridItem();
                        break;

                    //-- ListaOrdem 
                    case 4:
                        labelDataGrid.Text = "Nr. pedido";
                        titulo.Text = "Ordem";
                        labelDataGrid.Left = 310;

                        CarregarDataGridOrdem();
                        break;

                    //-- ListaMovimentacao
                    case 5:
                        labelDataGrid.Text = "Código";
                        titulo.Text = "Movimentação";
                        labelDataGrid.Left = 325;

                        CarregarDataGridMovimentacao();
                        break;

                    default: {
                            dataGrid.Visible = false;
                            panelDataGrid.Visible = false;
                            labelDataGrid.Visible = false;
                            buttonBuscarDataGrid.Visible = false;
                            textBoxDataGrid.Visible = false;

                            menuStrip.Visible = true;
                        }
                        break;
                }

                AtualizarPermissaoBotaoToolStrip();

            } catch(Exception ex) {
                MessageBox.Show("Ocorreu um erro ao abrir o formulário: " + ex.Message);
            }
        }

        private void AtualizarPermissaoBotaoToolStrip() {
            if(Formulario == (int)ListaFormulario.ListaMovimentacao) {
                Excluir.Enabled = false;
                Novo.Enabled = false;
                Editar.Enabled = false;
            }
            else {
                Excluir.Enabled = true;
                Novo.Enabled = true;
                Editar.Enabled = true;
            }
        }

        private void ExcluirByFormulario() {
            try {
                try {
                    if(GetExcluirOnClick()) {
                        bool Excluir = true;
                        switch(this.Formulario) {

                            //-- ListaPessoa
                            case 1:
                                PessoaController Pessoa = new PessoaController();
                                Excluir = Pessoa.Excluir(Sistema.Handle);
                                break;

                            //-- ListaUsuario
                            case 2:
                                LoginController Login = new LoginController();
                                Login.Excluir(Sistema.Handle);
                                break;


                            //-- ListaItem
                            case 3:
                                ItemController Item = new ItemController();
                                Excluir = Item.Excluir(Sistema.Handle);
                                break;

                            //-- ListaOrdem 
                            case 4:
                                OrdemController Ordem = new OrdemController();
                                Excluir = Ordem.Excluir(Sistema.Handle);
                                break;
                        }

                        if(!Excluir) {
                            MessageBox.Show("Para excluir, o registro selecionado não pode estar vinculado a outro registro!");
                        }

                        AbrirListagemByFormulario();
                    }
                } finally {
                    Sistema.Handle = 0;
                }
            } catch(Exception ex) {
                MessageBox.Show("Ocorreu um erro ao excluir o registro: " + ex.Message);
            }
        }

        private void CarregarConfiguracaoInicialDataGrid() {
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            panelDataGrid.Visible = true;
            labelDataGrid.Visible = true;
            buttonBuscarDataGrid.Visible = true;
            textBoxDataGrid.Visible = true;
            dataGrid.Visible = true;

            dataGrid.DataSource = null;

            menuStrip.Visible = false;

            for(int i = 0; i < dataGrid.ColumnCount; i++) {
                dataGrid.Columns[i].Visible = false;
            }
        }

        private void CarregarDataGridItem() {
            dataGrid.DataSource = ItemController.GetItemByCodigoByCodigoReferencia(textBoxDataGrid.Text);
            dataGrid.Columns["Codigo"].Visible = true;
            dataGrid.Columns["NomeItem"].Visible = true;
            dataGrid.Columns["CodigoReferencia"].Visible = true;
            dataGrid.Columns["ClienteNome"].Visible = true;
            dataGrid.Columns["ClassificacaoNome"].Visible = true;
            dataGrid.Columns["PesoLiquido"].Visible = true;
            dataGrid.Columns["PesoBruto"].Visible = true;
            dataGrid.Columns["UnidadeSigla"].Visible = true;
        }

        private void CarregarDataGridPessoa() {
            dataGrid.DataSource = PessoaController.GetPessoaByNome(textBoxDataGrid.Text);
            dataGrid.Columns["Codigo"].Visible = true;
            dataGrid.Columns["NomePessoa"].Visible = true;
            dataGrid.Columns["Cpf"].Visible = true;            
            dataGrid.Columns["Telefone"].Visible = true;
            dataGrid.Columns["Endereco"].Visible = true;
        }

        private void CarregarDataGridUsuario() {
            dataGrid.DataSource = LoginController.GetUsuarioByUsuario(textBoxDataGrid.Text);
            dataGrid.Columns["Codigo"].Visible = true;
            dataGrid.Columns["Login"].Visible = true;
        }

        private void CarregarDataGridOrdem() {
            dataGrid.DataSource = OrdemController.GetOrdemByNumeroPedido(textBoxDataGrid.Text);
            dataGrid.Columns["Codigo"].Visible = true;
            dataGrid.Columns["ClienteNome"].Visible = true;
            dataGrid.Columns["Data"].Visible = true;
            dataGrid.Columns["NumeroPedido"].Visible = true;
            dataGrid.Columns["TipoMovimentacao"].Visible = true;
            dataGrid.Columns["ItemNome"].Visible = true;
            dataGrid.Columns["Quantidade"].Visible = true;
            dataGrid.Columns["ValorUnitario"].Visible = true;
            dataGrid.Columns["ValorTotal"].Visible = true;
            dataGrid.Columns["PesoLiquido"].Visible = true;
            dataGrid.Columns["PesoBruto"].Visible = true;            
        }

        private void CarregarDataGridMovimentacao() {
            dataGrid.DataSource = MovimentacaoController.GetMovimentacaoByCodigo(textBoxDataGrid.Text);
            dataGrid.Columns["Codigo"].Visible = true;
            dataGrid.Columns["CodigoOrdem"].Visible = true;
            dataGrid.Columns["ClienteNome"].Visible = true;
            dataGrid.Columns["Data"].Visible = true;
            dataGrid.Columns["TipoMovimentacao"].Visible = true;
            dataGrid.Columns["ItemNome"].Visible = true;
            dataGrid.Columns["Quantidade"].Visible = true;
            dataGrid.Columns["ValorUnitario"].Visible = true;
            dataGrid.Columns["ValorTotal"].Visible = true;
            dataGrid.Columns["PesoLiquido"].Visible = true;
            dataGrid.Columns["PesoBruto"].Visible = true;
        }

        private void toolStripButtonRetornar_Click(object sender, EventArgs e) {
            this.Formulario = 0;
            AbrirListagemByFormulario();
        }

        private void Novo_Click(object sender, EventArgs e) {
            AbrirFormByFormulario(true);
        }

        private void Editar_Click(object sender, EventArgs e) {
            if(dataGrid.CurrentRow == null) {
                MessageBox.Show("Nenhum registro selecionado!");
            } 
            else {
                Sistema.Handle = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                AbrirFormByFormulario(true);
            }
        }

        private void Visualizar_Click(object sender, EventArgs e) {
            if(dataGrid.CurrentRow == null) {
                MessageBox.Show("Nenhum registro selecionado!");
            } 
            else {
                Sistema.Handle = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                AbrirFormByFormulario();
            }
        }

        private void dataGrid_DoubleClick(object sender, EventArgs e) {
            if(dataGrid.CurrentRow == null) {
                MessageBox.Show("Nenhum registro selecionado!");
            } 
            else {
                Sistema.Handle = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                AbrirFormByFormulario();
            }
        }

        private void Excluir_Click(object sender, EventArgs e) {
            if(dataGrid.CurrentRow == null) {
                MessageBox.Show("Nenhum registro selecionado!");
            }
            else {
                Sistema.Handle = Int32.Parse(dataGrid.CurrentRow.Cells[0].Value.ToString());
                ExcluirByFormulario();
            }
        }

        private void Atualizar_Click(object sender, EventArgs e) {
            textBoxDataGrid.Clear();
            AbrirListagemByFormulario();
        }

        private void dataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            for(int i = 0; i < dataGrid.RowCount; i++) {
                if (i % 2 == 0) {
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightCyan;
                }
            }
        }

        private void adicionarUsuario_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaUsuario;
            AbrirFormByFormulario(true);
        }

        private void listaUsuario_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaUsuario;

            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void adicionarPessoa_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaPessoa;
            AbrirFormByFormulario(true);
        }

        private void listarPessoa_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaPessoa;

            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void adicionarItem_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaItem;
            AbrirFormByFormulario(true);
        }

        private void listaItem_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaItem;

            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void adicioanarOrdem_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaItem;
            AbrirFormByFormulario(true);
        }

        private void listarOrdem_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaOrdem;

            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Formulario = (int)ListaFormulario.ListaMovimentacao;

            CarregarConfiguracaoInicialDataGrid();
            AbrirListagemByFormulario();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void trocarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();

        }

        private void buttonBuscarDataGrid_Click(object sender, EventArgs e) {
            AbrirListagemByFormulario();
        }

        private void textBoxDataGrid_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                AbrirListagemByFormulario();
            }
        }

        private void textBoxDataGrid_Leave(object sender, EventArgs e) {
            AbrirListagemByFormulario();
        }
    }
}
