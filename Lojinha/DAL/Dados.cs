using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class Dados
    {
        public static string StringConexao
        {
            get 
            {
               string conexao = "Data Source=DESKTOP-OEKMT27\\MSSQLSERVER02;Initial Catalog=LOJINHA;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
                return conexao;
               

            }




        }
    } 
}
