using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCC.BLL;
using TCC.Modelos;

namespace TCC.PL.WinForms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnADC_Click(object sender, EventArgs e)
        {
            var frm = new frmADC();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmEF();
            frm.ShowDialog();
        }

        private void TSMSobre_Click(object sender, EventArgs e)
        {
            var frm = new frmSobre();
            frm.ShowDialog();
        }

   
      
    }
}
