
namespace Cliente
{
    partial class FrmCadastro
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCriarConta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTpInvestidor = new System.Windows.Forms.ComboBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSaldoInicial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(281, 174);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(82, 30);
            this.BtnCancelar.TabIndex = 16;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCriarConta
            // 
            this.BtnCriarConta.Location = new System.Drawing.Point(2, 174);
            this.BtnCriarConta.Name = "BtnCriarConta";
            this.BtnCriarConta.Size = new System.Drawing.Size(82, 30);
            this.BtnCriarConta.TabIndex = 15;
            this.BtnCriarConta.Text = "OK";
            this.BtnCriarConta.UseVisualStyleBackColor = true;
            this.BtnCriarConta.Click += new System.EventHandler(this.BtnCriarConta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Perfil de Investidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome";
            // 
            // CmbTpInvestidor
            // 
            this.CmbTpInvestidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTpInvestidor.FormattingEnabled = true;
            this.CmbTpInvestidor.Location = new System.Drawing.Point(2, 126);
            this.CmbTpInvestidor.Name = "CmbTpInvestidor";
            this.CmbTpInvestidor.Size = new System.Drawing.Size(147, 21);
            this.CmbTpInvestidor.TabIndex = 11;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(2, 74);
            this.TxtCpf.MaxLength = 11;
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(147, 20);
            this.TxtCpf.TabIndex = 10;
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpf_KeyPress);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(2, 25);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(361, 20);
            this.TxtNome.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Saldo Inicial";
            // 
            // TxtSaldoInicial
            // 
            this.TxtSaldoInicial.Location = new System.Drawing.Point(155, 126);
            this.TxtSaldoInicial.MaxLength = 11;
            this.TxtSaldoInicial.Name = "TxtSaldoInicial";
            this.TxtSaldoInicial.Size = new System.Drawing.Size(90, 20);
            this.TxtSaldoInicial.TabIndex = 12;
            this.TxtSaldoInicial.Text = "0.00";
            this.TxtSaldoInicial.WordWrap = false;
            this.TxtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldoInicial_KeyPress);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 212);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSaldoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCriarConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbTpInvestidor);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadastro";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCriarConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTpInvestidor;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSaldoInicial;
    }
}