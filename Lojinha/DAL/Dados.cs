using System;
using System.Collections.Generic;
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
                return "server = Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Lojinha; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";
            }




        }
    } 
}
