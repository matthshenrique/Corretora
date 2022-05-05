using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cliente;
using Investimento;
using Conexao;

namespace Corretora
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region "Eventos"

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ListarAtivos();
            ListarContas();
            ListarInvestimentos();
            TornarReadOnly(DgvAtivos);
            TornarReadOnly(DgvContas);
            TornarReadOnly(DgvInvestimento);
        }

        private void BtnAtualizarLista_Click(object sender, EventArgs e)
        {
            ListarAtivos();
            ListarContas();
            ListarInvestimentos();
        }

        private void BtnNovoCadastro_Click(object sender, EventArgs e)
        {
            Form frmCadastro = new FrmCadastro();
            frmCadastro.ShowDialog();
            ListarContas();
        }

        private void BtnCriarConta_Click(object sender, EventArgs e)
        {
            Form frmNovaConta = new Cliente.FrmNovaConta();
            frmNovaConta.ShowDialog();
            ListarContas();
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (DgvContas.CurrentCell == null)
            {
                MessageBox.Show("Selecione uma conta para depositar.");
                return;
            }

            int conta = (int)DgvContas.Rows[DgvContas.CurrentCell.RowIndex].Cells[1].Value;

            Form frmDepositar = new Conta.FrmDepositar(conta);
            frmDepositar.ShowDialog();
            ListarContas();  
        }

        private void BtnResgatar_Click(object sender, EventArgs e)
        {
            if (DgvContas.CurrentCell == null)
            {
                MessageBox.Show("Selecione uma conta para resgatar.");
                return;
            }

            int conta = (int)DgvContas.Rows[DgvContas.CurrentCell.RowIndex].Cells[1].Value;

            Form frmResgatar = new Conta.FrmResgatar(conta);
            frmResgatar.ShowDialog();
            ListarContas();
        }

        private void BtnInvestir_Click(object sender, EventArgs e)
        {           
            if (DgvAtivos.CurrentCell == null)
            {
                MessageBox.Show("Selecione um ativo para investir.");
                return;
            }

            if (DgvContas.CurrentCell == null)
            {
                MessageBox.Show("Selecione uma conta para investir.");
                return;
            }

            int conta = (int)DgvContas.Rows[DgvContas.CurrentCell.RowIndex].Cells[1].Value;
            int ativo = (int)DgvAtivos.Rows[DgvAtivos.CurrentCell.RowIndex].Cells[0].Value;

            Form frmInvestir = new FrmInvestir(conta,ativo);
            frmInvestir.ShowDialog();
            ListarContas();
            ListarInvestimentos();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if (DgvInvestimento.CurrentCell == null)
            {
                MessageBox.Show("Selecione um ativo para vender.");
                return;
            }

            int idInvestimento = (int)DgvInvestimento.Rows[DgvInvestimento.CurrentCell.RowIndex].Cells[0].Value;
            decimal valor = (decimal)DgvInvestimento.Rows[DgvInvestimento.CurrentCell.RowIndex].Cells[5].Value;
            int conta = (int)DgvInvestimento.Rows[DgvInvestimento.CurrentCell.RowIndex].Cells[1].Value;

            Investimento.Investimento investimento = new Investimento.Investimento();

            investimento.VenderAtivo(idInvestimento);

            investimento.CreditarSaldoVendaAtivo(conta, valor);

            ListarContas();
            ListarInvestimentos();

            MessageBox.Show("Ativo vendido.");
        }
        #endregion

        private void TornarReadOnly(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
        }

        private void ListarAtivos()
        {
            Ativo ativo = new Ativo();
            DgvAtivos.DataSource = ativo.ObterAtivos();
            FormatarDgv(DgvAtivos);
        }
        
        private void ListarContas()
        {
            Cliente.Cliente cliente = new Cliente.Cliente();
            DgvContas.DataSource = cliente.ObterContaCliente();
            FormatarDgv(DgvContas);
        }

        private void ListarInvestimentos()
        {
            Investimento.Investimento investimento = new Investimento.Investimento();
            DgvInvestimento.DataSource = investimento.ObterInvestimentos();
            FormatarDgv(DgvInvestimento);
        }

        private void FormatarDgv( DataGridView dgv)
        {
            if (dgv.Equals(DgvContas))
            {
                dgv.Columns[0].Visible = false; //idCliente
                DgvContas.Columns[1].Visible = false; //idConta

                dgv.Columns[2].Width = 111; //Nome
                dgv.Columns[3].Width = 70; //Data Cadastro
                dgv.Columns[4].Width = 85; //CPF
                dgv.Columns[5].Width = 35; //Ag.
                dgv.Columns[6].Width = 90; //Banco
                dgv.Columns[7].Width = 60; //Saldo 
                dgv.Columns[8].Width = 75; //Tipo Invest.
            }
            else if (dgv.Equals(DgvAtivos))
            {
                dgv.Columns[0].Visible = false; //idAtivo

                dgv.Columns[1].Width = 110; //Nome
                dgv.Columns[2].Width = 89; //Valor
            }
            else 
            {
                dgv.Columns[0].Visible = false; //IdInvestimento
                dgv.Columns[1].Visible = false; //IdConta

                dgv.Columns[2].Width = 100; //Cliente
                dgv.Columns[3].Width = 50; //Tipo Invest.
                dgv.Columns[4].Width = 50; //Ativo
                dgv.Columns[5].Width = 60; //Valor
            }
        }
    }
}
