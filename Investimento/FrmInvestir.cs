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

namespace Investimento
{
    public partial class FrmInvestir : Form
    {
        private readonly int NumConta;
        private readonly int Ativo;

        public FrmInvestir(int idConta, int idAtivo)
        {
            InitializeComponent();
            NumConta = idConta;
            Ativo = idAtivo;
        }

        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            if (TxtValor.Text == "" )
            {
                MessageBox.Show("Digite um valor para investir");
                return;
            }

            Conta.Conta conta = new Conta.Conta();
            Investimento investimento = new Investimento();
            Ativo ativo = new Ativo();

            decimal saldo = conta.ObterSaldo(NumConta);            
            string tipoInvestidor = conta.ObterTipoInvestidor(NumConta);
            decimal valorAtivo = ativo.ObterValorAtivo(Ativo);

            decimal valorInvestimento;
            string valorTexto;

            valorTexto = TxtValor.Text.Replace(".", ",");
            valorInvestimento = Math.Round(Convert.ToDecimal(valorTexto), 2);

            if (investimento.VerificarValorAInvestir(tipoInvestidor,saldo,valorInvestimento) == false)
            {
                MessageBox.Show("Valor a Investir maior que o permitido para este tipo Investidor (Arrojado)");
                return;
            }

            if (investimento.VerificarValorAtivoInvestimento(tipoInvestidor,saldo,valorAtivo) == false)
            {
                MessageBox.Show("Não é possível aplicar o valor inserido neste investimento. Esta aplicação pode comprometer o seu saldo");
                return;
            }

            investimento.DebitarSaldoInvestir(NumConta, valorInvestimento);

            investimento.Investir(NumConta, Ativo, valorInvestimento);

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
