using System;
using System.Text;
using System.Windows.Forms;

namespace Gerador_de_Senha
{
    public partial class Form1 : Form
    {

        // Método para gerar a senha
        private void btnGerar_Click(object sender, EventArgs e)
        {
            int comprimentoSenha;
            if (!int.TryParse(textBoxComprimento.Text, out comprimentoSenha) || comprimentoSenha <= 0)
            {
                MessageBox.Show("Por favor, insira um comprimento de senha válido.");
                return;
            }

            bool incluirMaiusculas = checkBoxMaiusculas.Checked;
            bool incluirMinusculas = checkBoxMinusculas.Checked;
            bool incluirNumeros = checkBoxNumeros.Checked;
            bool incluirEspeciais = checkBoxEspeciais.Checked;

            if (!incluirMaiusculas && !incluirMinusculas && !incluirNumeros && !incluirEspeciais)
            {
                MessageBox.Show("Selecione pelo menos um tipo de caractere.");
                return;
            }

            string senhaGerada = GerarSenha(comprimentoSenha, incluirMaiusculas, incluirMinusculas, incluirNumeros, incluirEspeciais);
            labelSenha.Text = senhaGerada; // Agora corresponde ao Label correto
        }

        // Função para gerar a senha aleatória
        private string GerarSenha(int comprimento, bool maiusculas, bool minusculas, bool numeros, bool especiais)
        {
            string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            string digitos = "0123456789";
            string caracteresEspeciais = "!@#$%^&*()_-+=<>?";

            StringBuilder conjuntoCaracteres = new StringBuilder();
            Random random = new Random();

            if (maiusculas) conjuntoCaracteres.Append(letrasMaiusculas);
            if (minusculas) conjuntoCaracteres.Append(letrasMinusculas);
            if (numeros) conjuntoCaracteres.Append(digitos);
            if (especiais) conjuntoCaracteres.Append(caracteresEspeciais);

            StringBuilder senha = new StringBuilder(comprimento);

            for (int i = 0; i < comprimento; i++)
            {
                int indexAleatorio = random.Next(conjuntoCaracteres.Length);
                senha.Append(conjuntoCaracteres[indexAleatorio]);
            }

            return senha.ToString();
        }

        // Método para copiar a senha para a área de transferência
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(labelSenha.Text)) // Nome atualizado para o Label correto
            {
                Clipboard.SetText(labelSenha.Text); // Nome atualizado
                MessageBox.Show("Senha copiada para a área de transferência!");
            }
            else
            {
                MessageBox.Show("Nenhuma senha gerada para copiar.");
            }
        }
    }
}
