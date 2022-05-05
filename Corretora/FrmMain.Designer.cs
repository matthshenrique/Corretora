
namespace Corretora
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvContas = new System.Windows.Forms.DataGridView();
            this.BtnDepositar = new System.Windows.Forms.Button();
            this.BtnResgatar = new System.Windows.Forms.Button();
            this.BtnCriarConta = new System.Windows.Forms.Button();
            this.BtnNovoCadastro = new System.Windows.Forms.Button();
            this.BtnInvestir = new System.Windows.Forms.Button();
            this.BtnAtualizarLista = new System.Windows.Forms.Button();
            this.DgvAtivos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvInvestimento = new System.Windows.Forms.DataGridView();
            this.BtnVender = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvestimento)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvContas
            // 
            this.DgvContas.AllowUserToAddRows = false;
            this.DgvContas.AllowUserToDeleteRows = false;
            this.DgvContas.AllowUserToResizeColumns = false;
            this.DgvContas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvContas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvContas.Location = new System.Drawing.Point(3, 183);
            this.DgvContas.MultiSelect = false;
            this.DgvContas.Name = "DgvContas";
            this.DgvContas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvContas.Size = new System.Drawing.Size(569, 152);
            this.DgvContas.TabIndex = 0;
            // 
            // BtnDepositar
            // 
            this.BtnDepositar.Location = new System.Drawing.Point(277, 341);
            this.BtnDepositar.Name = "BtnDepositar";
            this.BtnDepositar.Size = new System.Drawing.Size(67, 30);
            this.BtnDepositar.TabIndex = 1;
            this.BtnDepositar.Text = "Depositar";
            this.BtnDepositar.UseVisualStyleBackColor = true;
            this.BtnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // BtnResgatar
            // 
            this.BtnResgatar.Location = new System.Drawing.Point(350, 341);
            this.BtnResgatar.Name = "BtnResgatar";
            this.BtnResgatar.Size = new System.Drawing.Size(69, 30);
            this.BtnResgatar.TabIndex = 2;
            this.BtnResgatar.Text = "Resgatar";
            this.BtnResgatar.UseVisualStyleBackColor = true;
            this.BtnResgatar.Click += new System.EventHandler(this.BtnResgatar_Click);
            // 
            // BtnCriarConta
            // 
            this.BtnCriarConta.Location = new System.Drawing.Point(184, 341);
            this.BtnCriarConta.Name = "BtnCriarConta";
            this.BtnCriarConta.Size = new System.Drawing.Size(69, 30);
            this.BtnCriarConta.TabIndex = 3;
            this.BtnCriarConta.Text = "Criar Conta";
            this.BtnCriarConta.UseVisualStyleBackColor = true;
            this.BtnCriarConta.Click += new System.EventHandler(this.BtnCriarConta_Click);
            // 
            // BtnNovoCadastro
            // 
            this.BtnNovoCadastro.Location = new System.Drawing.Point(92, 341);
            this.BtnNovoCadastro.Name = "BtnNovoCadastro";
            this.BtnNovoCadastro.Size = new System.Drawing.Size(86, 30);
            this.BtnNovoCadastro.TabIndex = 4;
            this.BtnNovoCadastro.Text = "Novo Cadastro";
            this.BtnNovoCadastro.UseVisualStyleBackColor = true;
            this.BtnNovoCadastro.Click += new System.EventHandler(this.BtnNovoCadastro_Click);
            // 
            // BtnInvestir
            // 
            this.BtnInvestir.Location = new System.Drawing.Point(425, 341);
            this.BtnInvestir.Name = "BtnInvestir";
            this.BtnInvestir.Size = new System.Drawing.Size(63, 30);
            this.BtnInvestir.TabIndex = 5;
            this.BtnInvestir.Text = "Investir";
            this.BtnInvestir.UseVisualStyleBackColor = true;
            this.BtnInvestir.Click += new System.EventHandler(this.BtnInvestir_Click);
            // 
            // BtnAtualizarLista
            // 
            this.BtnAtualizarLista.Location = new System.Drawing.Point(3, 341);
            this.BtnAtualizarLista.Name = "BtnAtualizarLista";
            this.BtnAtualizarLista.Size = new System.Drawing.Size(83, 30);
            this.BtnAtualizarLista.TabIndex = 6;
            this.BtnAtualizarLista.Text = "Atualizar Lista";
            this.BtnAtualizarLista.UseVisualStyleBackColor = true;
            this.BtnAtualizarLista.Click += new System.EventHandler(this.BtnAtualizarLista_Click);
            // 
            // DgvAtivos
            // 
            this.DgvAtivos.AllowUserToAddRows = false;
            this.DgvAtivos.AllowUserToDeleteRows = false;
            this.DgvAtivos.AllowUserToResizeColumns = false;
            this.DgvAtivos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAtivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvAtivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvAtivos.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvAtivos.Location = new System.Drawing.Point(3, 24);
            this.DgvAtivos.MultiSelect = false;
            this.DgvAtivos.Name = "DgvAtivos";
            this.DgvAtivos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAtivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvAtivos.Size = new System.Drawing.Size(242, 116);
            this.DgvAtivos.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ativos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clientes - Contas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Investimento";
            // 
            // DgvInvestimento
            // 
            this.DgvInvestimento.AllowUserToAddRows = false;
            this.DgvInvestimento.AllowUserToDeleteRows = false;
            this.DgvInvestimento.AllowUserToResizeColumns = false;
            this.DgvInvestimento.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInvestimento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvInvestimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvInvestimento.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvInvestimento.Location = new System.Drawing.Point(269, 24);
            this.DgvInvestimento.Name = "DgvInvestimento";
            this.DgvInvestimento.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvInvestimento.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvInvestimento.Size = new System.Drawing.Size(303, 116);
            this.DgvInvestimento.TabIndex = 10;
            // 
            // BtnVender
            // 
            this.BtnVender.Location = new System.Drawing.Point(494, 341);
            this.BtnVender.Name = "BtnVender";
            this.BtnVender.Size = new System.Drawing.Size(78, 30);
            this.BtnVender.TabIndex = 12;
            this.BtnVender.Text = "Vender Ativo";
            this.BtnVender.UseVisualStyleBackColor = true;
            this.BtnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 373);
            this.Controls.Add(this.BtnVender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DgvInvestimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvAtivos);
            this.Controls.Add(this.BtnAtualizarLista);
            this.Controls.Add(this.BtnInvestir);
            this.Controls.Add(this.BtnNovoCadastro);
            this.Controls.Add(this.BtnCriarConta);
            this.Controls.Add(this.BtnResgatar);
            this.Controls.Add(this.BtnDepositar);
            this.Controls.Add(this.DgvContas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Corretora ABCD";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvestimento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvContas;
        private System.Windows.Forms.Button BtnDepositar;
        private System.Windows.Forms.Button BtnResgatar;
        private System.Windows.Forms.Button BtnCriarConta;
        private System.Windows.Forms.Button BtnNovoCadastro;
        private System.Windows.Forms.Button BtnInvestir;
        private System.Windows.Forms.Button BtnAtualizarLista;
        private System.Windows.Forms.DataGridView DgvAtivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvInvestimento;
        private System.Windows.Forms.Button BtnVender;
    }
}

