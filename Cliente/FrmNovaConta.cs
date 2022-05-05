using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conta;

namespace Cliente
{
    public partial class FrmNovaConta : Form
    {
        public FrmNovaConta()
        {
            InitializeComponent();
        }
        private void FrmNovaConta_Load(object sender, EventArgs e)
        {
            CmbTpInvestidor.Items.Add("Arrojado");
            CmbTpInvestidor.Items.Add("Moderado");
            CmbTpInvestidor.Items.Add("Conservador");
        }
        private void BtnCriarConta_Click(object sender, EventArgs e)
        {
            int id;
            string cpf;
            string tipoInvestidor;
            decimal saldo;

            if (TxtCpf.Text == "")
            {
                MessageBox.Show("Digite o CPF");
                TxtCpf.Focus();
                return;
            }
            else
            {
                cpf = TxtCpf.Text;
            }

            Cliente cliente = new Cliente();

            id = cliente.ObterIdRegistrado(cpf);

            if (id == 0)
            {
                MessageBox.Show("Não existe cliente cadastrado com este CPF");
                TxtCpf.Focus();
                return;
            }      

            if (CmbTpInvestidor.Text == "")
            {
                MessageBox.Show("Selecione o tipo de investidor");
                CmbTpInvestidor.Focus();
                return;
            }

            if (TxtSaldoInicial.Text == "")
            {
                MessageBox.Show("Informe o saldo inicial");
                TxtSaldoInicial.Focus();
                return;
            }

            tipoInvestidor = CmbTpInvestidor.SelectedItem.ToString().Substring(0, 1);

            string saldoTexto = TxtSaldoInicial.Text.Replace(".", ",");
            saldo = Math.Round(Convert.ToDecimal(saldoTexto),2);

            Conta.Conta conta = new Conta.Conta(id, saldo, tipoInvestidor);

            conta.RegisterAccount();

            Dispose();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void TxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08) { e.Handled = true; }
        }
        private void TxtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TxtSaldoInicial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
