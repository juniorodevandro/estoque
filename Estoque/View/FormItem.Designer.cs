namespace Estoque.View {
    partial class FormItem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer componentes = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (componentes != null)) {
                componentes.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormItem));
            this.labelNomeItem = new System.Windows.Forms.Label();
            this.textBoxNomeItem = new System.Windows.Forms.TextBox();
            this.textBoxCodigoItem = new System.Windows.Forms.TextBox();
            this.labelCodigoItem = new System.Windows.Forms.Label();
            this.textBoxCodigoReferenciaItem = new System.Windows.Forms.TextBox();
            this.labelCodigoReferenciaItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxUnidadeMedidaItem = new System.Windows.Forms.ComboBox();
            this.labelUnidadeMedidaItem = new System.Windows.Forms.Label();
            this.comboBoxClassificacaoItem = new System.Windows.Forms.ComboBox();
            this.labelClassificacaoItem = new System.Windows.Forms.Label();
            this.textBoxPesoLiquidoItem = new System.Windows.Forms.TextBox();
            this.labelPesoLiquidoItem = new System.Windows.Forms.Label();
            this.textBoxPesoBrutoItem = new System.Windows.Forms.TextBox();
            this.labelPesoBrutoItem = new System.Windows.Forms.Label();
            this.buttonLimparItem = new System.Windows.Forms.Button();
            this.buttonGravarItem = new System.Windows.Forms.Button();
            this.buttonExcluirItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNomeItem
            // 
            this.labelNomeItem.AutoSize = true;
            this.labelNomeItem.Location = new System.Drawing.Point(12, 15);
            this.labelNomeItem.Name = "labelNomeItem";
            this.labelNomeItem.Size = new System.Drawing.Size(35, 13);
            this.labelNomeItem.TabIndex = 0;
            this.labelNomeItem.Text = "Nome";
            // 
            // textBoxNomeItem
            // 
            this.textBoxNomeItem.Location = new System.Drawing.Point(15, 32);
            this.textBoxNomeItem.MaxLength = 100;
            this.textBoxNomeItem.Name = "textBoxNomeItem";
            this.textBoxNomeItem.Size = new System.Drawing.Size(400, 20);
            this.textBoxNomeItem.TabIndex = 1;
            // 
            // textBoxCodigoItem
            // 
            this.textBoxCodigoItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxCodigoItem.Enabled = false;
            this.textBoxCodigoItem.Location = new System.Drawing.Point(421, 32);
            this.textBoxCodigoItem.MaxLength = 100;
            this.textBoxCodigoItem.Name = "textBoxCodigoItem";
            this.textBoxCodigoItem.ReadOnly = true;
            this.textBoxCodigoItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCodigoItem.Size = new System.Drawing.Size(147, 20);
            this.textBoxCodigoItem.TabIndex = 3;
            this.textBoxCodigoItem.Text = "0";
            // 
            // labelCodigoItem
            // 
            this.labelCodigoItem.AutoSize = true;
            this.labelCodigoItem.Location = new System.Drawing.Point(418, 15);
            this.labelCodigoItem.Name = "labelCodigoItem";
            this.labelCodigoItem.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoItem.TabIndex = 2;
            this.labelCodigoItem.Text = "Código";
            // 
            // textBoxCodigoReferenciaItem
            // 
            this.textBoxCodigoReferenciaItem.Location = new System.Drawing.Point(421, 81);
            this.textBoxCodigoReferenciaItem.MaxLength = 100;
            this.textBoxCodigoReferenciaItem.Name = "textBoxCodigoReferenciaItem";
            this.textBoxCodigoReferenciaItem.Size = new System.Drawing.Size(147, 20);
            this.textBoxCodigoReferenciaItem.TabIndex = 5;
            // 
            // labelCodigoReferenciaItem
            // 
            this.labelCodigoReferenciaItem.AutoSize = true;
            this.labelCodigoReferenciaItem.Location = new System.Drawing.Point(418, 64);
            this.labelCodigoReferenciaItem.Name = "labelCodigoReferenciaItem";
            this.labelCodigoReferenciaItem.Size = new System.Drawing.Size(90, 13);
            this.labelCodigoReferenciaItem.TabIndex = 4;
            this.labelCodigoReferenciaItem.Text = "Código referência";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(15, 81);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(400, 21);
            this.comboBoxCliente.TabIndex = 3;
            this.comboBoxCliente.DropDown += new System.EventHandler(this.comboBoxCliente_DropDown);
            // 
            // comboBoxUnidadeMedidaItem
            // 
            this.comboBoxUnidadeMedidaItem.FormattingEnabled = true;
            this.comboBoxUnidadeMedidaItem.Location = new System.Drawing.Point(115, 127);
            this.comboBoxUnidadeMedidaItem.Name = "comboBoxUnidadeMedidaItem";
            this.comboBoxUnidadeMedidaItem.Size = new System.Drawing.Size(147, 21);
            this.comboBoxUnidadeMedidaItem.TabIndex = 7;
            this.comboBoxUnidadeMedidaItem.DropDown += new System.EventHandler(this.comboBoxUnidadeMedidaItem_DropDown);
            // 
            // labelUnidadeMedidaItem
            // 
            this.labelUnidadeMedidaItem.AutoSize = true;
            this.labelUnidadeMedidaItem.Location = new System.Drawing.Point(112, 110);
            this.labelUnidadeMedidaItem.Name = "labelUnidadeMedidaItem";
            this.labelUnidadeMedidaItem.Size = new System.Drawing.Size(84, 13);
            this.labelUnidadeMedidaItem.TabIndex = 8;
            this.labelUnidadeMedidaItem.Text = "Unidade medida";
            // 
            // comboBoxClassificacaoItem
            // 
            this.comboBoxClassificacaoItem.FormattingEnabled = true;
            this.comboBoxClassificacaoItem.Location = new System.Drawing.Point(15, 128);
            this.comboBoxClassificacaoItem.Name = "comboBoxClassificacaoItem";
            this.comboBoxClassificacaoItem.Size = new System.Drawing.Size(94, 21);
            this.comboBoxClassificacaoItem.TabIndex = 6;
            this.comboBoxClassificacaoItem.DropDown += new System.EventHandler(this.comboBoxClassificacaoItem_DropDown);
            // 
            // labelClassificacaoItem
            // 
            this.labelClassificacaoItem.AutoSize = true;
            this.labelClassificacaoItem.Location = new System.Drawing.Point(12, 111);
            this.labelClassificacaoItem.Name = "labelClassificacaoItem";
            this.labelClassificacaoItem.Size = new System.Drawing.Size(69, 13);
            this.labelClassificacaoItem.TabIndex = 10;
            this.labelClassificacaoItem.Text = "Classificação";
            // 
            // textBoxPesoLiquidoItem
            // 
            this.textBoxPesoLiquidoItem.Location = new System.Drawing.Point(268, 128);
            this.textBoxPesoLiquidoItem.MaxLength = 100;
            this.textBoxPesoLiquidoItem.Name = "textBoxPesoLiquidoItem";
            this.textBoxPesoLiquidoItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPesoLiquidoItem.Size = new System.Drawing.Size(147, 20);
            this.textBoxPesoLiquidoItem.TabIndex = 15;
            this.textBoxPesoLiquidoItem.Text = "0,00";
            this.textBoxPesoLiquidoItem.KeyPress += textBoxCurrency_KeyPress;
            this.textBoxPesoLiquidoItem.Leave += textBoxToCurrency;
            // 
            // labelPesoLiquidoItem
            // 
            this.labelPesoLiquidoItem.AutoSize = true;
            this.labelPesoLiquidoItem.Location = new System.Drawing.Point(265, 112);
            this.labelPesoLiquidoItem.Name = "labelPesoLiquidoItem";
            this.labelPesoLiquidoItem.Size = new System.Drawing.Size(66, 13);
            this.labelPesoLiquidoItem.TabIndex = 14;
            this.labelPesoLiquidoItem.Text = "Peso líquido";
            // 
            // textBoxPesoBrutoItem
            // 
            this.textBoxPesoBrutoItem.Location = new System.Drawing.Point(421, 128);
            this.textBoxPesoBrutoItem.MaxLength = 100;
            this.textBoxPesoBrutoItem.Name = "textBoxPesoBrutoItem";
            this.textBoxPesoBrutoItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxPesoBrutoItem.Size = new System.Drawing.Size(147, 20);
            this.textBoxPesoBrutoItem.TabIndex = 16;
            this.textBoxPesoBrutoItem.Text = "0,00";
            this.textBoxPesoBrutoItem.KeyPress += textBoxCurrency_KeyPress;
            this.textBoxPesoBrutoItem.Leave += textBoxToCurrency;
            // 
            // labelPesoBrutoItem
            // 
            this.labelPesoBrutoItem.AutoSize = true;
            this.labelPesoBrutoItem.Location = new System.Drawing.Point(418, 111);
            this.labelPesoBrutoItem.Name = "labelPesoBrutoItem";
            this.labelPesoBrutoItem.Size = new System.Drawing.Size(58, 13);
            this.labelPesoBrutoItem.TabIndex = 12;
            this.labelPesoBrutoItem.Text = "Peso bruto";
            // 
            // buttonLimparItem
            // 
            this.buttonLimparItem.Location = new System.Drawing.Point(412, 166);
            this.buttonLimparItem.Name = "buttonLimparItem";
            this.buttonLimparItem.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparItem.TabIndex = 34;
            this.buttonLimparItem.Text = "Limpar";
            this.buttonLimparItem.UseVisualStyleBackColor = true;
            this.buttonLimparItem.Click += new System.EventHandler(this.buttonLimparItem_Click);
            // 
            // buttonGravarItem
            // 
            this.buttonGravarItem.Location = new System.Drawing.Point(331, 166);
            this.buttonGravarItem.Name = "buttonGravarItem";
            this.buttonGravarItem.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarItem.TabIndex = 33;
            this.buttonGravarItem.Text = "Gravar";
            this.buttonGravarItem.UseVisualStyleBackColor = true;
            this.buttonGravarItem.Click += new System.EventHandler(this.buttonGravarItem_Click);
            // 
            // buttonExcluirItem
            // 
            this.buttonExcluirItem.Location = new System.Drawing.Point(493, 166);
            this.buttonExcluirItem.Name = "buttonExcluirItem";
            this.buttonExcluirItem.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirItem.TabIndex = 35;
            this.buttonExcluirItem.Text = "Excluir";
            this.buttonExcluirItem.UseVisualStyleBackColor = true;
            this.buttonExcluirItem.Click += new System.EventHandler(this.buttonExcluirItem_Click);
            // 
            // FormItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 201);
            this.Controls.Add(this.buttonExcluirItem);
            this.Controls.Add(this.buttonLimparItem);
            this.Controls.Add(this.buttonGravarItem);
            this.Controls.Add(this.textBoxPesoLiquidoItem);
            this.Controls.Add(this.labelPesoLiquidoItem);
            this.Controls.Add(this.textBoxPesoBrutoItem);
            this.Controls.Add(this.labelPesoBrutoItem);
            this.Controls.Add(this.comboBoxClassificacaoItem);
            this.Controls.Add(this.labelClassificacaoItem);
            this.Controls.Add(this.comboBoxUnidadeMedidaItem);
            this.Controls.Add(this.labelUnidadeMedidaItem);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodigoReferenciaItem);
            this.Controls.Add(this.labelCodigoReferenciaItem);
            this.Controls.Add(this.textBoxCodigoItem);
            this.Controls.Add(this.labelCodigoItem);
            this.Controls.Add(this.textBoxNomeItem);
            this.Controls.Add(this.labelNomeItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += FormController_KeyDown;
        }

        private void TextBoxPesoBrutoItem_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelNomeItem;
        private System.Windows.Forms.TextBox textBoxNomeItem;
        private System.Windows.Forms.TextBox textBoxCodigoItem;
        private System.Windows.Forms.Label labelCodigoItem;
        private System.Windows.Forms.TextBox textBoxCodigoReferenciaItem;
        private System.Windows.Forms.Label labelCodigoReferenciaItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxUnidadeMedidaItem;
        private System.Windows.Forms.Label labelUnidadeMedidaItem;
        private System.Windows.Forms.ComboBox comboBoxClassificacaoItem;
        private System.Windows.Forms.Label labelClassificacaoItem;
        private System.Windows.Forms.TextBox textBoxPesoLiquidoItem;
        private System.Windows.Forms.Label labelPesoLiquidoItem;
        private System.Windows.Forms.TextBox textBoxPesoBrutoItem;
        private System.Windows.Forms.Label labelPesoBrutoItem;
        private System.Windows.Forms.Button buttonLimparItem;
        private System.Windows.Forms.Button buttonGravarItem;
        private System.Windows.Forms.Button buttonExcluirItem;
    }
}