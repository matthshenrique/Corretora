using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        #region "Eventos"
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            CmbTpInvestidor.Items.Add("Arrojado");
            CmbTpInvestidor.Items.Add("Moderado");
            CmbTpInvestidor.Items.Add("Conservador");
        }
        private void BtnCriarConta_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
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

            if (CmbTpInvestidor.Text == "")
            {
                MessageBox.Show("Selecione o tipo de investidor!");
                CmbTpInvestidor.Focus();
                return;
            }

            if (TxtSaldoInicial.Text == "")
            {
                MessageBox.Show("informe o saldo inicial!");
                TxtSaldoInicial.Focus();
                return;
            }

            tipoInvestidor = CmbTpInvestidor.SelectedItem.ToString().Substring(0, 1);

            string saldoTexto = TxtSaldoInicial.Text.Replace(".", ",");
            saldo = Math.Round(Convert.ToDecimal(saldoTexto), 2);

            Cliente cliente = new Cliente(nome, cpf, tipoInvestidor, saldo);

            if (!cliente.ValidarTamanhoCpf(cpf)) 
            {
                MessageBox.Show("CPF Incompleto!");                
                TxtCpf.Focus();
                return;
            }

            if (!cliente.ValidarCpfRegistrado(cpf))
            {
                MessageBox.Show("CPF já cadastrado!");
                TxtCpf.Focus();
                return;
            }             

            cliente.InserirCliente();

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
        #endregion

        //private void TxtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 46) { e.Handled = true; }
        //}
    }
}
