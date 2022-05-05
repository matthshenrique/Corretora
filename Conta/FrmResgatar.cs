using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta
{
    public partial class FrmResgatar : Form
    {
        private readonly int NumConta;
        public FrmResgatar(int idConta)
        {
            InitializeComponent();
            NumConta = idConta;
        }
        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            decimal valorResgate;
            string valorTexto;

            valorTexto = TxtValor.Text.Replace(".", ",");
            valorResgate = Math.Round(Convert.ToDecimal(valorTexto), 2);

            Conta conta = new Conta();

            decimal saldoAtual = conta.ObterSaldo(NumConta);

            if (saldoAtual < valorResgate)
            {
                MessageBox.Show("O valor de resgate não pode ser maior que o saldo disponível na conta");
                return;
            }

            conta.Resgatar(valorResgate, NumConta);

            MessageBox.Show("Resgate de R$ " + valorResgate + " realizado!");

            Dispose();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
