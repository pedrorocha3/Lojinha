using Lojinha.BLL;
using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lojinha.Formularios
{
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            // Load-time initialization (left empty to satisfy designer hookup)
        }

        private void InserirProdutoButton_Click(object sender, EventArgs e)
        {
            ProdutosInformation produto = new ProdutosInformation();
            produto.Nome = NomeProdutoTextBox.Text;
            produto.Preco = decimal.Parse(PrecoProdutoTextBox.Text);
            produto.Estoque = int.Parse(EstoqueProdutoTextBox.Text);

            ProdutosBLL obj = new ProdutosBLL();
            obj.Incluir(produto);
            MessageBox.Show("O produto foi incluido");
            CodigoProdutoTextBox.Text = Convert.ToString(produto.Codigo);
        }
    }
}
