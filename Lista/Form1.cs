using System;
using System.Collections.Generic;  // Para usar a List
using System.Windows.Forms;

namespace Lista
{
    public partial class Form1 : Form
    {
        // Declara a lista de tarefas
        private List<string> tarefas;

        public Form1()
        {
            InitializeComponent();
            // Inicializa a lista de tarefas
            tarefas = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Voc� pode inicializar qualquer comportamento ao carregar o formul�rio, se necess�rio.
        }

        // Adiciona a tarefa � lista e atualiza a ListBox
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                // Adiciona a tarefa � lista
                tarefas.Add(txtTarefa.Text);
                AtualizarListBox();
                txtTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Digite uma tarefa v�lida.");
            }
        }

        // Atualiza o item selecionado na lista e na ListBox
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedIndex >= 0)
            {
                int index = listBoxTarefas.SelectedIndex;
                tarefas[index] = txtTarefa.Text;
                AtualizarListBox();
                txtTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.");
            }
        }

        // Remove a tarefa selecionada da lista e atualiza a ListBox
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedIndex >= 0)
            {
                tarefas.RemoveAt(listBoxTarefas.SelectedIndex);
                AtualizarListBox();
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
        }

        // Limpa todas as tarefas da lista e da ListBox
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tarefas.Clear();
            AtualizarListBox();
        }

        // Atualiza o conte�do da ListBox com base na lista de tarefas
        private void AtualizarListBox()
        {
            listBoxTarefas.Items.Clear();
            foreach (var tarefa in tarefas)
            {
                listBoxTarefas.Items.Add(tarefa);
            }
        }

        // Quando uma tarefa � selecionada no ListBox, ela aparece na TextBox para edi��o
        private void listBoxTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedIndex >= 0)
            {
                txtTarefa.Text = tarefas[listBoxTarefas.SelectedIndex];
            }
        }
    }
}
