using System;
using System.Windows.Forms;

namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialização se necessário
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }
    }
}
