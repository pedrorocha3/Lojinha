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
    public class ClientesBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            // nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("o nome do cliente é obrigatório e não pode estar vazio ");
            }
            //EMAIL é sempre com letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            // se está tudo ok, chama a rotina de inserção
            ClientesDAL obj = new ClientesDAL();
            obj.Inclui(cliente);
        }
        public void Altera(ClienteInformation cliente)
        {
            // nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("o nome do cliente é obrigatório e não pode estar vazio ");
            }
            //EMAIL é sempre com letras minúsculas
            cliente.Email = cliente.Email.ToLower();
            // se está tudo ok, chama a rotina de alteração
            ClientesDAL obj = new ClientesDAL();
            obj.Altera(cliente);
            // isso aii
        }
        public void Exclui(int codigo)
        {

            // codigo do cliente é obrigatório
            if (codigo < 1)
            {
                throw new Exception("o codigo do cliente é obrigatório para a exclusão ");
            }
            ClientesDAL obj = new ClientesDAL();
            obj.Exclui(codigo);
         
        }
        public DataTable Listagem(string filtro)
        {
            ClientesDAL obj = new ClientesDAL();
            return obj.Listagem(filtro);
        }

        
    }
}
