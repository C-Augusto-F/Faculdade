using System;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        bool jogadorX = true; // Controla o jogador da vez
        int jogadas = 0; // Contador de jogadas
        Button?[,] botoes = new Button[3, 3]; // Matriz de bot�es (possivelmente nulos)

        public Form1()
        {
            InitializeComponent();
            InicializarTabuleiro(); // M�todo para inicializar o tabuleiro de bot�es
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa��es ou configura��es adicionais que voc� queira ao carregar o formul�rio
        }

        private void InicializarTabuleiro()
        {
            // Inicializa a matriz de bot�es 3x3
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    botoes[i, j] = new Button
                    {
                        Width = 100,
                        Height = 100,
                        Font = new System.Drawing.Font("Arial", 24),
                        Tag = $"{i},{j}" // Marca o bot�o com sua posi��o
                    };
                    botoes[i, j].Click += BotaoClick;
                    Controls.Add(botoes[i, j]);
                    botoes[i, j].Location = new System.Drawing.Point(100 * i, 100 * j);
                }
            }
        }

        private void BotaoClick(object? sender, EventArgs e)
        {
            if (sender is Button botao && string.IsNullOrEmpty(botao.Text)) // Verifica se o bot�o � v�lido
            {
                botao.Text = jogadorX ? "X" : "O";
                jogadas++;
                jogadorX = !jogadorX; // Alterna o jogador

                // Verificar se algu�m ganhou
                if (VerificarVencedor())
                {
                    string vencedor = jogadorX ? "O" : "X";
                    MessageBox.Show($"Jogador {vencedor} ganhou!");
                    DesabilitarBotoes();
                }
                else if (jogadas == 9)
                {
                    MessageBox.Show("Empate!");
                }
            }
        }

        private bool VerificarVencedor()
        {
            // Verifica linhas, colunas e diagonais
            for (int i = 0; i < 3; i++)
            {
                // Verificar linhas
                if (botoes[i, 0]?.Text == botoes[i, 1]?.Text && botoes[i, 1]?.Text == botoes[i, 2]?.Text && !string.IsNullOrEmpty(botoes[i, 0]?.Text))
                    return true;
                // Verificar colunas
                if (botoes[0, i]?.Text == botoes[1, i]?.Text && botoes[1, i]?.Text == botoes[2, i]?.Text && !string.IsNullOrEmpty(botoes[0, i]?.Text))
                    return true;
            }
            // Verificar diagonais
            if (botoes[0, 0]?.Text == botoes[1, 1]?.Text && botoes[1, 1]?.Text == botoes[2, 2]?.Text && !string.IsNullOrEmpty(botoes[0, 0]?.Text))
                return true;
            if (botoes[0, 2]?.Text == botoes[1, 1]?.Text && botoes[1, 1]?.Text == botoes[2, 0]?.Text && !string.IsNullOrEmpty(botoes[0, 2]?.Text))
                return true;

            return false;
        }

        private void DesabilitarBotoes()
        {
            foreach (Button? botao in botoes)
            {
                if (botao != null)
                    botao.Enabled = false; // Desabilita os bot�es para impedir jogadas adicionais
            }
        }

        private void ReiniciarJogo(object? sender, EventArgs e)
        {
            jogadorX = true;
            jogadas = 0;

            foreach (Button? botao in botoes)
            {
                if (botao != null)
                {
                    botao.Text = string.Empty; // Limpa o texto dos bot�es
                    botao.Enabled = true; // Reativa os bot�es para um novo jogo
                }
            }
        }
    }
}
