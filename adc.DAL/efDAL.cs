using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using TCC.Modelos;

namespace TCC.DAL
{  
    public class efDAL
    {
        private TCCEntities ctx = new TCCEntities();
        public void Inserir(Cad_EF ef) 
        {            
            try
            {                
                var InsEF = new Cad_EF
                {
                    Nome = ef.Nome,
                    Email = ef.Email,
                    Telefone = ef.Telefone
                };            
                ctx.Cad_EF.Add(ef);
                ctx.SaveChanges();                 
            }
            catch (Exception ex)
            {
                throw new Exception(
                    message: string.Format("Ocorreu erro(DAL) # {0}",
                        ex.Message),
                        innerException: ex);
            }
           
        }
    }
}
