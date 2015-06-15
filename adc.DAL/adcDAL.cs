using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using TCC.Modelos;

namespace TCC.DAL
{
    public class adcDAL
    {
        public void Inserir(adcDTO dto)
        {
            #region Preparation           
            
            var cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["TccConnectionString"]
                .ConnectionString;

            var cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO Cad_MVC(Nome,Email,Telefone)" +
                              "VALUES(@Nome, @Email, @Telefone)";

            cmd.Parameters.AddWithValue("@Nome", dto.Nome);
            cmd.Parameters.AddWithValue("@Email", dto.Email);
            cmd.Parameters.AddWithValue("@Telefone", dto.Telefone);
            
            #endregion
            #region Processing
            try
            {
                cn.Open();               
                cmd.ExecuteNonQuery();
            }            
            #endregion        
            #region Exception treatment
            catch (SqlException sqlex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro(DAL) # {0} - {1}",
                                sqlex.Number,
                                sqlex.Message),
                    innerException: sqlex);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu Erro (Dal - Geral) - {0}",
                                ex.Message),
                    innerException: ex);
            }
            #endregion
            #region Finally
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }            
            #endregion           
        }
    }

}
