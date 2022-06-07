namespace Estoque.View {
    partial class FormOrdem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdem));
            this.buttonLimparItem = new System.Windows.Forms.Button();
            this.buttonGravarItem = new System.Windows.Forms.Button();
            this.textBoxPesoLiquidoOrdem = new System.Windows.Forms.TextBox();
            this.labelPesoLiquidoItem = new System.Windows.Forms.Label();
            this.textBoxPesoBrutoOrdem = new System.Windows.Forms.TextBox();
            this.labelPesoBrutoItem = new System.Windows.Forms.Label();
            this.comboBoxClienteOrdem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigoOrdem = new System.Windows.Forms.TextBox();
            this.labelCodigoItem = new System.Windows.Forms.Label();
            this.comboBoxTipoMovimentacaoOrdem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataOrdem = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumeroPedidoOrdem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQuantidadeOrdem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxItemOrdem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxValorUnitarioOrdem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValorTotalOrdem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExcluirOrdem = new System.Windows.Forms.Button();
            this.texBoxObservacao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonGerarMovimentacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLimparItem
            // 
            this.buttonLimparItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLimparItem.Location = new System.Drawing.Point(413, 244);
            this.buttonLimparItem.Name = "buttonLimparItem";
            this.buttonLimparItem.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparItem.TabIndex = 31;
            this.buttonLimparItem.Text = "Limpar";
            this.buttonLimparItem.UseVisualStyleBackColor = true;
            this.buttonLimparItem.Click += new System.EventHandler(this.buttonLimparItem_Click);
            // 
            // buttonGravarItem
            // 
            this.buttonGravarItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGravarItem.Location = new System.Drawing.Point(332, 244);
            this.buttonGravarItem.Name = "buttonGravarItem";
            this.buttonGravarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarItem.TabIndex = 30;
            this.buttonGravarItem.Text = "Gravar";
            this.buttonGravarItem.UseVisualStyleBackColor = true;
            this.buttonGravarItem.Click += new System.EventHandler(this.buttonGravarItem_Click);
            // 
            // textBoxPesoLiquidoOrdem
            // 
            this.textBoxPesoLiquidoOrdem.Location = new System.Drawing.Point(352, 107);
            this.textBoxPesoLiquidoOrdem.MaxLength = 10;
            this.textBoxPesoLiquidoOrdem.Name = "textBoxPesoLiquidoOrdem";
            this.textBoxPesoLiquidoOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPesoLiquidoOrdem.Size = new System.Drawing.Size(105, 20);
            this.textBoxPesoLiquidoOrdem.TabIndex = 10;
            this.textBoxPesoLiquidoOrdem.Text = "0.00";
            this.textBoxPesoLiquidoOrdem.KeyDown += FormController_KeyDown;
            this.textBoxPesoLiquidoOrdem.Leave += textBoxToCurrency;
            // 
            // labelPesoLiquidoItem
            // 
            this.labelPesoLiquidoItem.AutoSize = true;
            this.labelPesoLiquidoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPesoLiquidoItem.Location = new System.Drawing.Point(349, 92);
            this.labelPesoLiquidoItem.Name = "labelPesoLiquidoItem";
            this.labelPesoLiquidoItem.Size = new System.Drawing.Size(66, 13);
            this.labelPesoLiquidoItem.TabIndex = 50;
            this.labelPesoLiquidoItem.Text = "Peso líquido";
            // 
            // textBoxPesoBrutoOrdem
            // 
            this.textBoxPesoBrutoOrdem.Location = new System.Drawing.Point(463, 107);
            this.textBoxPesoBrutoOrdem.MaxLength = 10;
            this.textBoxPesoBrutoOrdem.Name = "textBoxPesoBrutoOrdem";
            this.textBoxPesoBrutoOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPesoBrutoOrdem.Size = new System.Drawing.Size(105, 20);
            this.textBoxPesoBrutoOrdem.TabIndex = 11;
            this.textBoxPesoBrutoOrdem.Text = "0,00";
            this.textBoxPesoBrutoOrdem.KeyDown += FormController_KeyDown;
            this.textBoxPesoBrutoOrdem.Leave += textBoxToCurrency;
            // 
            // labelPesoBrutoItem
            // 
            this.labelPesoBrutoItem.AutoSize = true;
            this.labelPesoBrutoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelPesoBrutoItem.Location = new System.Drawing.Point(460, 92);
            this.labelPesoBrutoItem.Name = "labelPesoBrutoItem";
            this.labelPesoBrutoItem.Size = new System.Drawing.Size(58, 13);
            this.labelPesoBrutoItem.TabIndex = 49;
            this.labelPesoBrutoItem.Text = "Peso bruto";
            // 
            // comboBoxClienteOrdem
            // 
            this.comboBoxClienteOrdem.FormattingEnabled = true;
            this.comboBoxClienteOrdem.Location = new System.Drawing.Point(12, 27);
            this.comboBoxClienteOrdem.Name = "comboBoxClienteOrdem";
            this.comboBoxClienteOrdem.Size = new System.Drawing.Size(288, 21);
            this.comboBoxClienteOrdem.TabIndex = 1;
            this.comboBoxClienteOrdem.DropDown += new System.EventHandler(this.comboBoxClienteOrdem_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cliente";
            // 
            // textBoxCodigoOrdem
            // 
            this.textBoxCodigoOrdem.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCodigoOrdem.Location = new System.Drawing.Point(468, 28);
            this.textBoxCodigoOrdem.MaxLength = 100;
            this.textBoxCodigoOrdem.Name = "textBoxCodigoOrdem";
            this.textBoxCodigoOrdem.ReadOnly = true;
            this.textBoxCodigoOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCodigoOrdem.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoOrdem.TabIndex = 3;
            this.textBoxCodigoOrdem.Text = "0";
            // 
            // labelCodigoItem
            // 
            this.labelCodigoItem.AutoSize = true;
            this.labelCodigoItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCodigoItem.Location = new System.Drawing.Point(465, 12);
            this.labelCodigoItem.Name = "labelCodigoItem";
            this.labelCodigoItem.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoItem.TabIndex = 37;
            this.labelCodigoItem.Text = "Código";
            // 
            // comboBoxTipoMovimentacaoOrdem
            // 
            this.comboBoxTipoMovimentacaoOrdem.FormattingEnabled = true;
            this.comboBoxTipoMovimentacaoOrdem.Location = new System.Drawing.Point(306, 27);
            this.comboBoxTipoMovimentacaoOrdem.Name = "comboBoxTipoMovimentacaoOrdem";
            this.comboBoxTipoMovimentacaoOrdem.Size = new System.Drawing.Size(156, 21);
            this.comboBoxTipoMovimentacaoOrdem.TabIndex = 2;
            this.comboBoxTipoMovimentacaoOrdem.DropDown += new System.EventHandler(this.comboBoxTipoMovimentacaoOrdem_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(303, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Tipo movimentação";
            // 
            // dataOrdem
            // 
            this.dataOrdem.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dataOrdem.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dataOrdem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataOrdem.Location = new System.Drawing.Point(12, 67);
            this.dataOrdem.Name = "dataOrdem";
            this.dataOrdem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataOrdem.Size = new System.Drawing.Size(133, 20);
            this.dataOrdem.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Data";
            // 
            // textBoxNumeroPedidoOrdem
            // 
            this.textBoxNumeroPedidoOrdem.Location = new System.Drawing.Point(151, 67);
            this.textBoxNumeroPedidoOrdem.MaxLength = 100;
            this.textBoxNumeroPedidoOrdem.Name = "textBoxNumeroPedidoOrdem";
            this.textBoxNumeroPedidoOrdem.Size = new System.Drawing.Size(149, 20);
            this.textBoxNumeroPedidoOrdem.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(148, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Número pedido";
            // 
            // textBoxQuantidadeOrdem
            // 
            this.textBoxQuantidadeOrdem.Location = new System.Drawing.Point(12, 107);
            this.textBoxQuantidadeOrdem.MaxLength = 100;
            this.textBoxQuantidadeOrdem.Name = "textBoxQuantidadeOrdem";
            this.textBoxQuantidadeOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxQuantidadeOrdem.Size = new System.Drawing.Size(110, 20);
            this.textBoxQuantidadeOrdem.TabIndex = 7;
            this.textBoxQuantidadeOrdem.Text = "0.00";
            this.textBoxQuantidadeOrdem.Leave += new System.EventHandler(this.textBoxQuantidadeOrdem_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(9, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 90;
            this.label5.Text = "Quantidade";
            // 
            // comboBoxItemOrdem
            // 
            this.comboBoxItemOrdem.FormattingEnabled = true;
            this.comboBoxItemOrdem.Location = new System.Drawing.Point(306, 66);
            this.comboBoxItemOrdem.Name = "comboBoxItemOrdem";
            this.comboBoxItemOrdem.Size = new System.Drawing.Size(262, 21);
            this.comboBoxItemOrdem.TabIndex = 6;
            this.comboBoxItemOrdem.DropDown += new System.EventHandler(this.comboBoxItemOrdem_DropDown);
            this.comboBoxItemOrdem.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemOrdem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(303, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Item";
            // 
            // textBoxValorUnitarioOrdem
            // 
            this.textBoxValorUnitarioOrdem.Location = new System.Drawing.Point(126, 107);
            this.textBoxValorUnitarioOrdem.MaxLength = 100;
            this.textBoxValorUnitarioOrdem.Name = "textBoxValorUnitarioOrdem";
            this.textBoxValorUnitarioOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxValorUnitarioOrdem.Size = new System.Drawing.Size(110, 20);
            this.textBoxValorUnitarioOrdem.TabIndex = 8;
            this.textBoxValorUnitarioOrdem.Text = "0,00";
            this.textBoxValorUnitarioOrdem.Leave += new System.EventHandler(this.textBoxValorUnitarioOrdem_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(123, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 94;
            this.label7.Text = "Valor unitário";
            // 
            // textBoxValorTotalOrdem
            // 
            this.textBoxValorTotalOrdem.Location = new System.Drawing.Point(241, 107);
            this.textBoxValorTotalOrdem.MaxLength = 100;
            this.textBoxValorTotalOrdem.Name = "textBoxValorTotalOrdem";
            this.textBoxValorTotalOrdem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxValorTotalOrdem.Size = new System.Drawing.Size(105, 20);
            this.textBoxValorTotalOrdem.TabIndex = 9;
            this.textBoxValorTotalOrdem.Text = "0,00";
            this.textBoxValorTotalOrdem.Leave += new System.EventHandler(this.textBoxValorTotalOrdem_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(238, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 96;
            this.label8.Text = "Valor total";
            // 
            // buttonExcluirOrdem
            // 
            this.buttonExcluirOrdem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExcluirOrdem.Location = new System.Drawing.Point(493, 244);
            this.buttonExcluirOrdem.Name = "buttonExcluirOrdem";
            this.buttonExcluirOrdem.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirOrdem.TabIndex = 33;
            this.buttonExcluirOrdem.Text = "Excluir";
            this.buttonExcluirOrdem.UseVisualStyleBackColor = true;
            this.buttonExcluirOrdem.Click += new System.EventHandler(this.buttonExcluirOrdem_Click);
            // 
            // texBoxObservacao
            // 
            this.texBoxObservacao.Location = new System.Drawing.Point(12, 151);
            this.texBoxObservacao.MaxLength = 1000;
            this.texBoxObservacao.Multiline = true;
            this.texBoxObservacao.Name = "texBoxObservacao";
            this.texBoxObservacao.Size = new System.Drawing.Size(556, 77);
            this.texBoxObservacao.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(9, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Observação";
            // 
            // buttonGerarMovimentacao
            // 
            this.buttonGerarMovimentacao.Enabled = false;
            this.buttonGerarMovimentacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGerarMovimentacao.Location = new System.Drawing.Point(213, 244);
            this.buttonGerarMovimentacao.Name = "buttonGerarMovimentacao";
            this.buttonGerarMovimentacao.Size = new System.Drawing.Size(113, 23);
            this.buttonGerarMovimentacao.TabIndex = 100;
            this.buttonGerarMovimentacao.Text = "Gerar movimentação";
            this.buttonGerarMovimentacao.UseVisualStyleBackColor = true;
            this.buttonGerarMovimentacao.Click += new System.EventHandler(this.buttonGerarMovimentacao_Click);
            // 
            // FormOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(580, 279);
            this.Controls.Add(this.buttonGerarMovimentacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.texBoxObservacao);
            this.Controls.Add(this.buttonExcluirOrdem);
            this.Controls.Add(this.textBoxValorTotalOrdem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxValorUnitarioOrdem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxItemOrdem);
            this.Controls.Add(this.textBoxQuantidadeOrdem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumeroPedidoOrdem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataOrdem);
            this.Controls.Add(this.comboBoxTipoMovimentacaoOrdem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLimparItem);
            this.Controls.Add(this.buttonGravarItem);
            this.Controls.Add(this.textBoxPesoLiquidoOrdem);
            this.Controls.Add(this.labelPesoLiquidoItem);
            this.Controls.Add(this.textBoxPesoBrutoOrdem);
            this.Controls.Add(this.labelPesoBrutoItem);
            this.Controls.Add(this.comboBoxClienteOrdem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoOrdem);
            this.Controls.Add(this.labelCodigoItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrdem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += FormController_KeyDown;
        }

        #endregion

        private System.Windows.Forms.Button buttonLimparItem;
        private System.Windows.Forms.Button buttonGravarItem;
        private System.Windows.Forms.TextBox textBoxPesoLiquidoOrdem;
        private System.Windows.Forms.Label labelPesoLiquidoItem;
        private System.Windows.Forms.TextBox textBoxPesoBrutoOrdem;
        private System.Windows.Forms.Label labelPesoBrutoItem;
        private System.Windows.Forms.ComboBox comboBoxClienteOrdem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigoOrdem;
        private System.Windows.Forms.Label labelCodigoItem;
        private System.Windows.Forms.ComboBox comboBoxTipoMovimentacaoOrdem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataOrdem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumeroPedidoOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQuantidadeOrdem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxItemOrdem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxValorUnitarioOrdem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValorTotalOrdem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExcluirOrdem;
        private System.Windows.Forms.TextBox texBoxObservacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonGerarMovimentacao;
    }
}