namespace Estoque.View {
    partial class FormUsuario {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.textBoxSenhaUsuario = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxCodigoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExcluirUsuario = new System.Windows.Forms.Button();
            this.buttonLimparUsuario = new System.Windows.Forms.Button();
            this.buttonGravarUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSenhaUsuario
            // 
            this.textBoxSenhaUsuario.Location = new System.Drawing.Point(12, 73);
            this.textBoxSenhaUsuario.MaxLength = 100;
            this.textBoxSenhaUsuario.Name = "textBoxSenhaUsuario";
            this.textBoxSenhaUsuario.PasswordChar = '*';
            this.textBoxSenhaUsuario.Size = new System.Drawing.Size(333, 20);
            this.textBoxSenhaUsuario.TabIndex = 3;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSenha.Location = new System.Drawing.Point(9, 56);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 44;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxLoginUsuario
            // 
            this.textBoxLoginUsuario.Location = new System.Drawing.Point(12, 29);
            this.textBoxLoginUsuario.MaxLength = 100;
            this.textBoxLoginUsuario.Name = "textBoxLoginUsuario";
            this.textBoxLoginUsuario.Size = new System.Drawing.Size(223, 20);
            this.textBoxLoginUsuario.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelLogin.Location = new System.Drawing.Point(9, 12);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 41;
            this.labelLogin.Text = "Login";
            // 
            // textBoxCodigoUsuario
            // 
            this.textBoxCodigoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxCodigoUsuario.Location = new System.Drawing.Point(241, 29);
            this.textBoxCodigoUsuario.MaxLength = 100;
            this.textBoxCodigoUsuario.Name = "textBoxCodigoUsuario";
            this.textBoxCodigoUsuario.ReadOnly = true;
            this.textBoxCodigoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCodigoUsuario.Size = new System.Drawing.Size(104, 20);
            this.textBoxCodigoUsuario.TabIndex = 2;
            this.textBoxCodigoUsuario.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Código";
            // 
            // buttonExcluirUsuario
            // 
            this.buttonExcluirUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonExcluirUsuario.Location = new System.Drawing.Point(270, 108);
            this.buttonExcluirUsuario.Name = "buttonExcluirUsuario";
            this.buttonExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluirUsuario.TabIndex = 50;
            this.buttonExcluirUsuario.Text = "Excluir";
            this.buttonExcluirUsuario.UseVisualStyleBackColor = true;
            this.buttonExcluirUsuario.Click += new System.EventHandler(this.buttonExcluirUsuario_Click);
            // 
            // buttonLimparUsuario
            // 
            this.buttonLimparUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonLimparUsuario.Location = new System.Drawing.Point(189, 108);
            this.buttonLimparUsuario.Name = "buttonLimparUsuario";
            this.buttonLimparUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonLimparUsuario.TabIndex = 49;
            this.buttonLimparUsuario.Text = "Limpar";
            this.buttonLimparUsuario.UseVisualStyleBackColor = true;
            this.buttonLimparUsuario.Click += new System.EventHandler(this.buttonLimparUsuario_Click);
            // 
            // buttonGravarUsuario
            // 
            this.buttonGravarUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGravarUsuario.Location = new System.Drawing.Point(108, 108);
            this.buttonGravarUsuario.Name = "buttonGravarUsuario";
            this.buttonGravarUsuario.Size = new System.Drawing.Size(75, 23);
            this.buttonGravarUsuario.TabIndex = 48;
            this.buttonGravarUsuario.Text = "Gravar";
            this.buttonGravarUsuario.UseVisualStyleBackColor = true;
            this.buttonGravarUsuario.Click += new System.EventHandler(this.buttonGravarUsuario_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(357, 145);
            this.Controls.Add(this.buttonExcluirUsuario);
            this.Controls.Add(this.buttonLimparUsuario);
            this.Controls.Add(this.buttonGravarUsuario);
            this.Controls.Add(this.textBoxCodigoUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSenhaUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxLoginUsuario);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.KeyDown += FormController_KeyDown;
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSenhaUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxLoginUsuario;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxCodigoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcluirUsuario;
        private System.Windows.Forms.Button buttonLimparUsuario;
        private System.Windows.Forms.Button buttonGravarUsuario;
    }
}