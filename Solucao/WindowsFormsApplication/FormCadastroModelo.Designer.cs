namespace WindowsFormsApplication
{
    partial class FormCadastroModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGravarEContinuar = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDataCadastro = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDataCadastro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGravarEContinuar
            // 
            this.buttonGravarEContinuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGravarEContinuar.Location = new System.Drawing.Point(196, 402);
            this.buttonGravarEContinuar.Name = "buttonGravarEContinuar";
            this.buttonGravarEContinuar.Size = new System.Drawing.Size(149, 23);
            this.buttonGravarEContinuar.TabIndex = 7;
            this.buttonGravarEContinuar.Text = "Gravar e cadastrar um novo";
            this.buttonGravarEContinuar.UseVisualStyleBackColor = true;
            this.buttonGravarEContinuar.Click += new System.EventHandler(this.buttonGravarEContinuar_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGravar.Location = new System.Drawing.Point(351, 402);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 23);
            this.buttonGravar.TabIndex = 8;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.excluirButton.Location = new System.Drawing.Point(432, 402);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 9;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sairButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.sairButton.Location = new System.Drawing.Point(513, 402);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(75, 23);
            this.sairButton.TabIndex = 10;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro modelo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 52);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(118, 52);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(364, 20);
            this.textBoxNome.TabIndex = 4;
            // 
            // textBoxDataCadastro
            // 
            this.textBoxDataCadastro.Enabled = false;
            this.textBoxDataCadastro.Location = new System.Drawing.Point(488, 52);
            this.textBoxDataCadastro.Name = "textBoxDataCadastro";
            this.textBoxDataCadastro.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataCadastro.TabIndex = 6;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(12, 36);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(40, 13);
            this.labelCodigo.TabIndex = 1;
            this.labelCodigo.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome";
            // 
            // labelDataCadastro
            // 
            this.labelDataCadastro.AutoSize = true;
            this.labelDataCadastro.Location = new System.Drawing.Point(485, 36);
            this.labelDataCadastro.Name = "labelDataCadastro";
            this.labelDataCadastro.Size = new System.Drawing.Size(89, 13);
            this.labelDataCadastro.TabIndex = 5;
            this.labelDataCadastro.Text = "Data de cadastro";
            // 
            // FormCadastroModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 437);
            this.Controls.Add(this.labelDataCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxDataCadastro);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGravarEContinuar);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.sairButton);
            this.MaximumSize = new System.Drawing.Size(616, 476);
            this.Name = "FormCadastroModelo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCadastroModelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGravarEContinuar;
        private System.Windows.Forms.Button buttonGravar;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDataCadastro;
        public System.Windows.Forms.TextBox textBoxCodigo;
        public System.Windows.Forms.TextBox textBoxNome;
        public System.Windows.Forms.TextBox textBoxDataCadastro;
    }
}