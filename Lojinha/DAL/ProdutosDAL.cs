using Lojinha.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class ProdutosDAL
    {
        public void InsereProduto(ProdutosInformation produtos)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_produto";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                // Nome
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = produtos.Nome;
                cmd.Parameters.Add(pnome);
                // Preço
                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.Decimal);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);
                // Estoque
                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.Int);
                pestoque.Value = produtos.Estoque;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void AlteraProduto(ProdutosInformation produtos)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "altera_produto";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                // Nome
                SqlParameter pnome = new SqlParameter("@nome", SqlDbType.VarChar, 100);
                pnome.Value = produtos.Nome;
                cmd.Parameters.Add(pnome);
                // Preço
                SqlParameter ppreco = new SqlParameter("@preco", SqlDbType.Decimal);
                ppreco.Value = produtos.Preco;
                cmd.Parameters.Add(ppreco);
                // Estoque
                SqlParameter pestoque = new SqlParameter("@estoque", SqlDbType.Int);
                pestoque.Value = produtos.Estoque;
                cmd.Parameters.Add(pestoque);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public void ExcluiProduto(ProdutosInformation produtos)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "exclui_produto";
                // Parâmetros da Stored Procedure


                // Código
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);

                cn.Open();
                cmd.ExecuteNonQuery();

                produtos.Codigo = (Int32)cmd.Parameters["@codigo"].Value;
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
        public DataTable SelecionaProdutos(string filtro)
        {
            // Conexão com o banco de dados
            SqlConnection cn = new SqlConnection(Dados.StringConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "seleciona_produto";
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


