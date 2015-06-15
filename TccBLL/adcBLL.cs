using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC.Modelos;
using TCC.DAL;

namespace TCC.BLL
{    public class adcBLL
    {
        public void Inserir(adcDTO dto)
        {
            var dal = new adcDAL();
            dal.Inserir(dto);
        }
    }
}
