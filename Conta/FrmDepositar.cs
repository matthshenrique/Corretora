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
    public partial class FrmDepositar : Form
    {
        private readonly int NumConta;
        public FrmDepositar(int idConta)
        {
            InitializeComponent();
            NumConta = idConta;
        }
        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            decimal valorDeposito;
            string valorTexto;

            valorTexto = TxtValor.Text.Replace(".", ",");
            valorDeposito = Math.Round(Convert.ToDecimal(valorTexto), 2);

            Conta conta = new Conta();

            conta.Depositar(valorDeposito, NumConta);

            MessageBox.Show("Depósito de R$ " + valorDeposito + " realizado!");

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
