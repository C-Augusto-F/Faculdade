using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public decimal Total { get; set; }
        public decimal Valor { get; set; } 
        private Operacao OperacaoSelecionada {  get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Resultado.Text += "0";
        }

        private void brn1_Click(object sender, EventArgs e)
        {
            Resultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Resultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Resultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Resultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Resultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Resultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Resultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Resultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Resultado.Text += "9";
        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text = "";
            blOpercao.Text = "X";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text = "";
            blOpercao.Text = "/";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text = "";
            blOpercao.Text = "-";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(Resultado.Text);
            Resultado.Text = "";
            blOpercao.Text = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Total = Valor + Convert.ToDecimal(Resultado.Text);
                    break;
                case Operacao.Subtracao:
                    Total = Valor - Convert.ToDecimal(Resultado.Text);
                    break;
                case Operacao.Divisao:
                    Total = Valor / Convert.ToDecimal(Resultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Total = Valor * Convert.ToDecimal(Resultado.Text);
                    break;
            }
            Resultado.Text = Convert.ToString(Total);
            blOpercao.Text = "=";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!Resultado.Text.Contains(","))
                Resultado.Text += ",";
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
            blOpercao.Text = "";
        }
    }
}
