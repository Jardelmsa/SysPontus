using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CAMADA.DALL.Models;

namespace CAMADA.DALL.Persistence
{
    public class FuncionariosController : Conexao
    {
        public void Create(Funcionarios f)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("INSERT INTO Funcionario VALUES ( @v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9)", Con);
                Cmd.Parameters.AddWithValue("@v1", f.CPF_CNPJ);
                Cmd.Parameters.AddWithValue("@v2", f.NomeCompleto);
                Cmd.Parameters.AddWithValue("@v3", f.Email);
                Cmd.Parameters.AddWithValue("@v4", f.Telefone);
                Cmd.Parameters.AddWithValue("@v5", f.Endereco);
                Cmd.Parameters.AddWithValue("@v6", f.Sexo);
                Cmd.Parameters.AddWithValue("@v7", f.Login);
                Cmd.Parameters.AddWithValue("@v8", f.Senha);
                Cmd.Parameters.AddWithValue("@v9", f.Cargo);
                Cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
