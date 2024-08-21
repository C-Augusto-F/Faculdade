using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temporizador_cronometro
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch; // Corrige a declaração do Stopwatch

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch(); // Instancia o Stopwatch corretamente
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopwatch.Start(); // Usa a instância correta para iniciar o cronômetro
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Stop(); // Usa a instância correta para parar o cronômetro
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Reset(); // Usa a instância correta para resetar o cronômetro
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = stopwatch.Elapsed.ToString(@"hh\:mm\:ss\.fff"); // Exibe o tempo decorrido formatado corretamente
        }
    }
}
