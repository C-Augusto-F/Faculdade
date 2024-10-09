namespace AgendaDeContatos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private ListBox listBoxContatos;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnLimpar;
        private Label lblNome;
        private Label lblTelefone;
        private Label lblEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNome = new TextBox();
            this.txtTelefone = new TextBox();
            this.txtEmail = new TextBox();
            this.listBoxContatos = new ListBox();
            this.btnAdicionar = new Button();
            this.btnEditar = new Button();
            this.btnRemover = new Button();
            this.btnLimpar = new Button();
            this.lblNome = new Label();
            this.lblTelefone = new Label();
            this.lblEmail = new Label();
            this.SuspendLayout();

            // Configurações dos TextBoxes
            this.txtNome.Location = new System.Drawing.Point(12, 25);
            this.txtNome.Size = new System.Drawing.Size(200, 23);

            this.txtTelefone.Location = new System.Drawing.Point(12, 75);
            this.txtTelefone.Size = new System.Drawing.Size(200, 23);

            this.txtEmail.Location = new System.Drawing.Point(12, 125);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);

            // Configurações do ListBox
            this.listBoxContatos.Location = new System.Drawing.Point(230, 25);
            this.listBoxContatos.Size = new System.Drawing.Size(250, 150);
            this.listBoxContatos.SelectedIndexChanged += new System.EventHandler(this.listBoxContatos_SelectedIndexChanged);

            // Configurações dos Botões
            this.btnAdicionar.Location = new System.Drawing.Point(12, 175);
            this.btnAdicionar.Size = new System.Drawing.Size(90, 30);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.btnEditar.Location = new System.Drawing.Point(120, 175);
            this.btnEditar.Size = new System.Drawing.Size(90, 30);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnRemover.Location = new System.Drawing.Point(230, 200);
            this.btnRemover.Size = new System.Drawing.Size(90, 30);
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            this.btnLimpar.Location = new System.Drawing.Point(340, 200);
            this.btnLimpar.Size = new System.Drawing.Size(90, 30);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // Configurações dos Labels
            this.lblNome.Location = new System.Drawing.Point(12, 5);
            this.lblNome.Size = new System.Drawing.Size(100, 20);
            this.lblNome.Text = "Nome:";

            this.lblTelefone.Location = new System.Drawing.Point(12, 55);
            this.lblTelefone.Size = new System.Drawing.Size(100, 20);
            this.lblTelefone.Text = "Telefone:";

            this.lblEmail.Location = new System.Drawing.Point(12, 105);
            this.lblEmail.Size = new System.Drawing.Size(100, 20);
            this.lblEmail.Text = "Email:";

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEmail);
            this.Text = "Agenda de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
