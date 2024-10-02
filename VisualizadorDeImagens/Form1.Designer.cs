namespace VisualizadorDeImagens
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnLimpar;

        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(50, 50); // Posição do PictureBox
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 200); // Tamanho do PictureBox
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;

            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(50, 270); // Posição do botão "Carregar"
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(100, 30); // Tamanho do botão "Carregar"
            this.btnCarregar.TabIndex = 1;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);

            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(200, 270); // Posição do botão "Limpar"
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 30); // Tamanho do botão "Limpar"
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 350); // Tamanho da janela do Formulário
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnLimpar);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
        }
    }
}