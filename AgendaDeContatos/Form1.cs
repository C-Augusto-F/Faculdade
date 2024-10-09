using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaDeContatos
{
    public partial class Form1 : Form
    {
        // Lista para armazenar os contatos
        private List<Contato> contatos = new List<Contato>();

        public Form1()
        {
            InitializeComponent();
        }

        // Método para adicionar um novo contato
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtTelefone.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                // Cria um novo contato
                Contato contato = new Contato(txtNome.Text, txtTelefone.Text, txtEmail.Text);
                contatos.Add(contato);

                // Adiciona o contato à ListBox
                listBoxContatos.Items.Add(contato);

                // Limpa os campos de entrada
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

        // Método para editar um contato selecionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedItem != null)
            {
                Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;

                contatoSelecionado.Nome = txtNome.Text;
                contatoSelecionado.Telefone = txtTelefone.Text;
                contatoSelecionado.Email = txtEmail.Text;

                // Atualiza a exibição na ListBox
                int index = listBoxContatos.SelectedIndex;
                listBoxContatos.Items[index] = contatoSelecionado;

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um contato para editar.");
            }
        }

        // Método para remover um contato
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedItem != null)
            {
                Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;
                contatos.Remove(contatoSelecionado);

                // Remove o contato da ListBox
                listBoxContatos.Items.Remove(contatoSelecionado);

                LimparCampos();
            }
            else
            {
                MessageBox.Show("Selecione um contato para remover.");
            }
        }

        // Limpa os campos de entrada
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // Limpar os campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
        }

        // Exibe os detalhes do contato selecionado
        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxContatos.SelectedItem != null)
            {
                Contato contatoSelecionado = (Contato)listBoxContatos.SelectedItem;
                txtNome.Text = contatoSelecionado.Nome;
                txtTelefone.Text = contatoSelecionado.Telefone;
                txtEmail.Text = contatoSelecionado.Email;
            }
        }
    }

    // Classe Contato
    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome} - {Telefone} - {Email}";
        }
    }
}

