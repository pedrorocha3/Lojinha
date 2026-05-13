using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Lojinha.DAL
{
    public class ClientesDAL
    {
        public void Inclui(ClienteInformation cliente)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_cliente";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                // Nome
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);
                // Email
                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);
                // Telefone
                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 20);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }


            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados. " + ex.Number);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();
            }


        }
        public void Altera(ClienteInformation cliente)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_cliente";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                // Nome
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);
                // Email
                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);
                // Telefone
                SqlParameter ptelefone = new SqlParameter("@telefone", SqlDbType.VarChar, 20);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }


            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados. " + ex.Number);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();
            }


        }
        public void Exclui(int codigo)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_cliente";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                cmd.ExecuteNonQuery();

               
            }


            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados. " + ex.Number);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable Listagem(string filtro)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_cliente";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar, 100);
                pfiltro.Value = filtro;
                cmd.Parameters.Add(pfiltro);
                DataTable tabela = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
                return tabela;

               // cn.Open();
               // cmd.ExecuteNonQuery();

                //cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
            }


            catch (SqlException ex)
            {

                throw new Exception("Erro ao acessar o banco de dados. " + ex.Number);
            }
            catch
            {
                throw new Exception("Erro desconhecido ao acessar o banco de dados.");

            }
            finally
            {
                cn.Close();
            }
        }

        
    }
}
