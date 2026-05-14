using Lojinha.BLL;
using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void Limpar_Click(object sender, EventArgs e)
        {

        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            ClienteInformation cliente = new ClienteInformation();
            cliente.Nome = nomeTextBox.Text;
            cliente.Email = emailTextBox.Text;
            cliente.Telefone = TelefoneTextBox.Text;

            ClientesBLL obj = new ClientesBLL();
            obj.Incluir(cliente);
            MessageBox.Show("O cliente foi incluido");
            codigoTextBox.Text = Convert.ToString(cliente.Codigo);
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente precisa ser selecionado para alteração");
            }
            else
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Codigo = int.Parse(codigoTextBox.Text);
                    cliente.Nome = nomeTextBox.Text;
                    cliente.Email = emailTextBox.Text;
                    cliente.Telefone = TelefoneTextBox.Text;

                    ClientesBLL obj = new ClientesBLL();
                    obj.Altera(cliente);
                    MessageBox.Show("Cliente alterado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente precisa ser selecionado para exclusão");
            }
            else
            {
                try
                {
                   int codigo = int.Parse(codigoTextBox.Text);
                    ClientesBLL obj = new ClientesBLL();
                    obj.Exclui(codigo);
                    MessageBox.Show("Cliente excluido com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message.ToString());
                }
            }
        }
    }
}