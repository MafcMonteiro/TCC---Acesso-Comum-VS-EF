using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.DAL;
using TCC.Modelos;

namespace TCC.BLL
{
    public class efBLL
    {
        public void InsertBLL(Cad_EF ef) 
        {
            var dal = new efDAL();
            dal.Inserir(ef);
        }
    }
}
