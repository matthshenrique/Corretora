
namespace Cliente
{
    partial class FrmNovaConta
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
            this.TxtSaldoInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCriarConta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbTpInvestidor = new System.Windows.Forms.ComboBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtSaldoInicial
            // 
            this.TxtSaldoInicial.Location = new System.Drawing.Point(156, 76);
            this.TxtSaldoInicial.MaxLength = 11;
            this.TxtSaldoInicial.Name = "TxtSaldoInicial";
            this.TxtSaldoInicial.Size = new System.Drawing.Size(90, 20);
            this.TxtSaldoInicial.TabIndex = 21;
            this.TxtSaldoInicial.Text = "0.00";
            this.TxtSaldoInicial.WordWrap = false;
            this.TxtSaldoInicial.TextChanged += new System.EventHandler(this.TxtSaldoInicial_TextChanged);
            this.TxtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSaldoInicial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Saldo Inicial";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(282, 124);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(82, 30);
            this.BtnCancelar.TabIndex = 25;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCriarConta
            // 
            this.BtnCriarConta.Location = new System.Drawing.Point(3, 124);
            this.BtnCriarConta.Name = "BtnCriarConta";
            this.BtnCriarConta.Size = new System.Drawing.Size(82, 30);
            this.BtnCriarConta.TabIndex = 24;
            this.BtnCriarConta.Text = "OK";
            this.BtnCriarConta.UseVisualStyleBackColor = true;
            this.BtnCriarConta.Click += new System.EventHandler(this.BtnCriarConta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Perfil de Investidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Informe o CPF do cliente:";
            // 
            // CmbTpInvestidor
            // 
            this.CmbTpInvestidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTpInvestidor.FormattingEnabled = true;
            this.CmbTpInvestidor.Location = new System.Drawing.Point(3, 76);
            this.CmbTpInvestidor.Name = "CmbTpInvestidor";
            this.CmbTpInvestidor.Size = new System.Drawing.Size(147, 21);
            this.CmbTpInvestidor.TabIndex = 20;
            // 
            // TxtCpf
            // 
            this.TxtCpf.Location = new System.Drawing.Point(3, 24);
            this.TxtCpf.MaxLength = 11;
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(147, 20);
            this.TxtCpf.TabIndex = 19;
            this.TxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCpf_KeyPress);
            // 
            // FrmNovaConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 163);
            this.ControlBox = false;
            this.Controls.Add(this.TxtSaldoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCriarConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbTpInvestidor);
            this.Controls.Add(this.TxtCpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNovaConta";
            this.Text = "Nova Conta";
            this.Load += new System.EventHandler(this.FrmNovaConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSaldoInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCriarConta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbTpInvestidor;
        private System.Windows.Forms.TextBox TxtCpf;
    }
}