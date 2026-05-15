using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.DAL;
using Lojinha.Modelos;

namespace Lojinha.BLL
{
    public class ProdutosBLL
    {
        public void Incluir(ProdutosInformation produto)
        {
            // nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("o nome do produto é obrigatório e não pode estar vazio ");
            }
           
            // se está tudo ok, chama a rotina de inserção
            ProdutosDAL obj = new ProdutosDAL();
            obj.InsereProduto(produto);
        }
        public void AlteraProduto(ProdutosInformation produto)
        {
            // nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("o nome do produto é obrigatório e não pode estar vazio ");
            }
           
            // se está tudo ok, chama a rotina de alteração
            ProdutosDAL obj = new ProdutosDAL();
            obj.AlteraProduto(produto);
            // isso aii
        }
        public void Exclui(int codigo)
        {

            // codigo do produto é obrigatório
            if (codigo < 1)
            {
                throw new Exception("o codigo do produto é obrigatório para a exclusão ");
            }
            ProdutosDAL obj = new ProdutosDAL();
            obj.ExcluiProduto(codigo);

        }
        public DataTable Listagem(string filtro)
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.SelecionaProdutos(filtro);
        }


    }
}
