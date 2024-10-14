using System;
using System.Windows.Forms;

namespace Gerador_de_Senha
{
    public partial class Form1 : Form
    {
        private TextBox textBoxComprimento;
        private CheckBox checkBoxMaiusculas;
        private CheckBox checkBoxMinusculas;
        private CheckBox checkBoxNumeros;
        private CheckBox checkBoxEspeciais;
        private Button buttonGerar;
        private Button buttonCopiar;
        private Label labelSenha;
        private Label labelComprimento;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.textBoxComprimento = new TextBox();
            this.checkBoxMaiusculas = new CheckBox();
            this.checkBoxMinusculas = new CheckBox();
            this.checkBoxNumeros = new CheckBox();
            this.checkBoxEspeciais = new CheckBox();
            this.buttonGerar = new Button();
            this.buttonCopiar = new Button();
            this.labelSenha = new Label();
            this.labelComprimento = new Label();

            // Propriedades do TextBox para o comprimento da senha
            this.textBoxComprimento.Location = new System.Drawing.Point(150, 20);  // Posição
            this.textBoxComprimento.Size = new System.Drawing.Size(100, 20);  // Tamanho
            this.textBoxComprimento.Name = "textBoxComprimento";  // Nome

            // Propriedades do Label para indicar o campo de comprimento da senha
            this.labelComprimento.Location = new System.Drawing.Point(20, 20);
            this.labelComprimento.Size = new System.Drawing.Size(130, 20);
            this.labelComprimento.Text = "Comprimento da Senha:";

            // Propriedades do CheckBox para Maiúsculas
            this.checkBoxMaiusculas.Location = new System.Drawing.Point(20, 60);
            this.checkBoxMaiusculas.Size = new System.Drawing.Size(130, 20);
            this.checkBoxMaiusculas.Text = "Incluir Maiúsculas";
            this.checkBoxMaiusculas.Name = "checkBoxMaiusculas";

            // Propriedades do CheckBox para Minúsculas
            this.checkBoxMinusculas.Location = new System.Drawing.Point(20, 90);
            this.checkBoxMinusculas.Size = new System.Drawing.Size(130, 20);
            this.checkBoxMinusculas.Text = "Incluir Minúsculas";
            this.checkBoxMinusculas.Name = "checkBoxMinusculas";

            // Propriedades do CheckBox para Números
            this.checkBoxNumeros.Location = new System.Drawing.Point(20, 120);
            this.checkBoxNumeros.Size = new System.Drawing.Size(130, 20);
            this.checkBoxNumeros.Text = "Incluir Números";
            this.checkBoxNumeros.Name = "checkBoxNumeros";

            // Propriedades do CheckBox para Caracteres Especiais
            this.checkBoxEspeciais.Location = new System.Drawing.Point(20, 150);
            this.checkBoxEspeciais.Size = new System.Drawing.Size(160, 20);
            this.checkBoxEspeciais.Text = "Incluir Caracteres Especiais";
            this.checkBoxEspeciais.Name = "checkBoxEspeciais";

            // Propriedades do Botão Gerar Senha
            this.buttonGerar.Location = new System.Drawing.Point(20, 190);
            this.buttonGerar.Size = new System.Drawing.Size(100, 30);
            this.buttonGerar.Text = "Gerar Senha";
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Click += new EventHandler(this.btnGerar_Click);  // Evento de clique

            // Propriedades do Botão Copiar Senha
            this.buttonCopiar.Location = new System.Drawing.Point(150, 190);
            this.buttonCopiar.Size = new System.Drawing.Size(100, 30);
            this.buttonCopiar.Text = "Copiar Senha";
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Click += new EventHandler(this.btnCopiar_Click);  // Evento de clique

            // Propriedades do Label para exibir a senha gerada
            this.labelSenha.Location = new System.Drawing.Point(20, 240);
            this.labelSenha.Size = new System.Drawing.Size(230, 20);
            this.labelSenha.Text = "Senha Gerada:";
            this.labelSenha.Name = "labelSenha";

            // Adicionar os controles ao formulário
            this.Controls.Add(this.textBoxComprimento);
            this.Controls.Add(this.checkBoxMaiusculas);
            this.Controls.Add(this.checkBoxMinusculas);
            this.Controls.Add(this.checkBoxNumeros);
            this.Controls.Add(this.checkBoxEspeciais);
            this.Controls.Add(this.buttonGerar);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelComprimento);

            // Configurar propriedades do formulário
            this.Text = "Gerador de Senhas";
            this.ClientSize = new System.Drawing.Size(300, 300);
        }
    }
}
