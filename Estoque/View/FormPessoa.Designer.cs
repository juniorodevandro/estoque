namespace Estoque.View {
    partial class FormPessoa {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPessoa));
            this.labelTelefonePessoa = new System.Windows.Forms.Label();
            this.textBoxCodigoPessoa = new System.Windows.Forms.TextBox();
            this.labelCodigoPessoa = new System.Windows.Forms.Label();
            this.textBoxNomePessoa = new System.Windows.Forms.TextBox();
            this.labelNomePessoa = new System.Windows.Forms.Label();
            this.labelCnpjCpfPessoa = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTelefonePessoa = new System.Windows.Forms.MaskedTextBox();
            this.buttonGravarPesssoa = new System.Windows.Forms.Button();
            this.buttonLimparPesssoa = new System.Windows.Forms.Button();
            this.buttonExcluirPessoa = new System.Windows.Forms.Button();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelObservacao = new System.Windows.Forms.Label();
            this.textBoxObservacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTelefonePessoa
            // 
            this.labelTelefonePessoa.AutoSize = true;
            this.labelTelefonePessoa.Location = new System.Drawing.Point(469, 65);
            this.labelTelefonePessoa.Name = "labelTelefonePessoa";
            this.labelTelefonePessoa.Size = new System.Drawing.Size(49, 13);
            this.labelTelefonePessoa.TabIndex = 30;
            this.labelTelefonePessoa.Text = "Telefone";
            // 
            // textBoxCodigoPessoa
            // 
            this.textBoxCodigoPessoa.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCodigoPessoa.Location = new System.Drawing.Point(472, 33);
            this.textBoxCodigoPessoa.MaxLength = 100;
            this.textBoxCodigoPessoa.Name = "textBoxCodigoPessoa";
            this.textBoxCodigoPessoa.ReadOnly = true;
            this.textBoxCodigoPessoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCodigoPessoa.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoPessoa.TabIndex = 2;
            this.textBoxCodigoPessoa.Text = "0";
            // 
            // labelCodigoPessoa
            // 
            this.labelCodigoPessoa.AutoSize = true;
            this.labelCodigoPessoa.Location = new System.Drawing.Point(469, 16);
            this.labelCodigoPessoa.Name = "labelCodigoPessoa";
            this.labelCodigoPessoa.Size = new System.Drawing.Size(40, 13);
            this.labelCodigoPessoa.TabIndex = 20;
            this.labelCodigoPessoa.Text = "Código";
            // 
            // textBoxNomePessoa
            // 
            this.textBoxNomePessoa.Location = new System.Drawing.Point(15, 33);
            this.textBoxNomePessoa.MaxLength = 100;
            this.textBoxNomePessoa.Name = "textBoxNomePessoa";
            this.textBoxNomePessoa.Size = new System.Drawing.Size(343, 20);
            this.textBoxNomePessoa.TabIndex = 1;
            // 
            // labelNomePessoa
            // 
            this.labelNomePessoa.AutoSize = true;
            this.labelNomePessoa.Location = new System.Drawing.Point(12, 16);
            this.labelNomePessoa.Name = "labelNomePessoa";
            this.labelNomePessoa.Size = new System.Drawing.Size(35, 13);
            this.labelNomePessoa.TabIndex = 18;
            this.labelNomePessoa.Text = "Nome";
            // 
            // labelCnpjCpfPessoa
            // 
            this.labelCnpjCpfPessoa.AutoSize = true;
            this.labelCnpjCpfPessoa.Location = new System.Drawing.Point(361, 16);
            this.labelCnpjCpfPessoa.Name = "labelCnpjCpfPessoa";
            this.labelCnpjCpfPessoa.Size = new System.Drawing.Size(27, 13);
            this.labelCnpjCpfPessoa.TabIndex = 22;
            this.labelCnpjCpfPessoa.Text = "CPF";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(15, 81);
            this.textBoxEndereco.MaxLength = 100;
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(451, 20);
            this.textBoxEndereco.TabIndex = 3;
            // 
            // maskedTextBoxTelefonePessoa
            // 
            this.maskedTextBoxTelefonePessoa.Location = new System.Drawing.Point(472, 81);
            this.maskedTextBoxTelefonePessoa.Mask = "(99) 00000-0000";
            this.maskedTextBoxTelefonePessoa.Name = "maskedTextBoxTelefonePessoa";
            this.maskedTextBoxTelefonePessoa.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxTelefonePessoa.TabIndex = 4;
            // 
            // buttonGravarPesssoa
            // 
            this.buttonGravarPesssoa.Location = new System.Drawing.Point(335, 195);
            this.buttonGravarPesssoa.Name = "buttonGravarPesssoa";
            this.buttonGravarPesssoa.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarPesssoa.TabIndex = 31;
            this.buttonGravarPesssoa.Text = "Gravar";
            this.buttonGravarPesssoa.UseVisualStyleBackColor = true;
            this.buttonGravarPesssoa.Click += new System.EventHandler(this.buttonGravarPesssoa_Click);
            // 
            // buttonLimparPesssoa
            // 
            this.buttonLimparPesssoa.Location = new System.Drawing.Point(416, 195);
            this.buttonLimparPesssoa.Name = "buttonLimparPesssoa";
            this.buttonLimparPesssoa.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparPesssoa.TabIndex = 32;
            this.buttonLimparPesssoa.Text = "Limpar";
            this.buttonLimparPesssoa.UseVisualStyleBackColor = true;
            this.buttonLimparPesssoa.Click += new System.EventHandler(this.buttonLimparPesssoa_Click);
            // 
            // buttonExcluirPessoa
            // 
            this.buttonExcluirPessoa.Location = new System.Drawing.Point(497, 195);
            this.buttonExcluirPessoa.Name = "buttonExcluirPessoa";
            this.buttonExcluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirPessoa.TabIndex = 33;
            this.buttonExcluirPessoa.Text = "Excluir";
            this.buttonExcluirPessoa.UseVisualStyleBackColor = true;
            this.buttonExcluirPessoa.Click += new System.EventHandler(this.buttonExcluirPessoa_Click);
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(364, 33);
            this.maskedTextBoxCpf.Mask = "000.000.000-00";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(102, 20);
            this.maskedTextBoxCpf.TabIndex = 2;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(12, 65);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(53, 13);
            this.labelEndereco.TabIndex = 35;
            this.labelEndereco.Text = "Endereço";
            // 
            // labelObservacao
            // 
            this.labelObservacao.AutoSize = true;
            this.labelObservacao.Location = new System.Drawing.Point(12, 110);
            this.labelObservacao.Name = "labelObservacao";
            this.labelObservacao.Size = new System.Drawing.Size(65, 13);
            this.labelObservacao.TabIndex = 37;
            this.labelObservacao.Text = "Observação";
            // 
            // textBoxObservacao
            // 
            this.textBoxObservacao.Location = new System.Drawing.Point(15, 126);
            this.textBoxObservacao.MaxLength = 1000;
            this.textBoxObservacao.Multiline = true;
            this.textBoxObservacao.Name = "textBoxObservacao";
            this.textBoxObservacao.Size = new System.Drawing.Size(557, 60);
            this.textBoxObservacao.TabIndex = 6;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 230);
            this.Controls.Add(this.labelObservacao);
            this.Controls.Add(this.textBoxObservacao);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.maskedTextBoxCpf);
            this.Controls.Add(this.buttonExcluirPessoa);
            this.Controls.Add(this.buttonLimparPesssoa);
            this.Controls.Add(this.buttonGravarPesssoa);
            this.Controls.Add(this.maskedTextBoxTelefonePessoa);
            this.Controls.Add(this.labelTelefonePessoa);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.labelCnpjCpfPessoa);
            this.Controls.Add(this.textBoxCodigoPessoa);
            this.Controls.Add(this.labelCodigoPessoa);
            this.Controls.Add(this.textBoxNomePessoa);
            this.Controls.Add(this.labelNomePessoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPessoa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += FormController_KeyDown;

        }

        #endregion
        private System.Windows.Forms.Label labelTelefonePessoa;
        private System.Windows.Forms.TextBox textBoxCodigoPessoa;
        private System.Windows.Forms.Label labelCodigoPessoa;
        private System.Windows.Forms.TextBox textBoxNomePessoa;
        private System.Windows.Forms.Label labelNomePessoa;
        private System.Windows.Forms.Label labelCnpjCpfPessoa;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefonePessoa;
        private System.Windows.Forms.Button buttonGravarPesssoa;
        private System.Windows.Forms.Button buttonLimparPesssoa;
        private System.Windows.Forms.Button buttonExcluirPessoa;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelObservacao;
        private System.Windows.Forms.TextBox textBoxObservacao;
    }
}