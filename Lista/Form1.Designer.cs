namespace Lista
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listBoxTarefas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnLimpar;

        private void InitializeComponent()
        {
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listBoxTarefas = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtTarefa
            this.txtTarefa.Location = new System.Drawing.Point(12, 12);
            this.txtTarefa.Size = new System.Drawing.Size(250, 20);

            // btnAdicionar
            this.btnAdicionar.Location = new System.Drawing.Point(270, 10);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            // listBoxTarefas
            this.listBoxTarefas.Location = new System.Drawing.Point(12, 50);
            this.listBoxTarefas.Size = new System.Drawing.Size(250, 150);
            this.listBoxTarefas.SelectedIndexChanged += new System.EventHandler(this.listBoxTarefas_SelectedIndexChanged);

            // btnEditar
            this.btnEditar.Location = new System.Drawing.Point(270, 50);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnRemover
            this.btnRemover.Location = new System.Drawing.Point(270, 90);
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            // btnLimpar
            this.btnLimpar.Location = new System.Drawing.Point(270, 130);
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listBoxTarefas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnLimpar);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
