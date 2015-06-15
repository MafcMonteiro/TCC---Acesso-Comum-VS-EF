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
using TCC.DAL;
using TCC.Modelos;
using System.Diagnostics;


namespace TCC.PL.WinForms
{
    public partial class frmEF : Form
    {
        Stopwatch Cronometro = new Stopwatch();
        public frmEF()
        {
            InitializeComponent();
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int Progress = Convert.ToInt32(numupQtdInserts.Value);
            Cronometro.Reset();
            Cronometro.Start();
            tmrCronometro.Start();

            progressBar.Minimum = 0;
            progressBar.Maximum = Progress;

            cargaDadosBackgroundWorker.RunWorkerAsync();                 

        }

        private void cargaDadosBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void cargaDadosBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int j = 1;
                for (int i = 0; i < numupQtdInserts.Value; i++)
                {
                    var ef = new Cad_EF
                    {
                        Nome = "UninoveEF",
                        Email = "UninoveEF@uninove.br",
                        Telefone = 80808080
                    };
                    cargaDadosBackgroundWorker.ReportProgress(j);
                    var bll = new efBLL();
                    bll.InsertBLL(ef);
                    
                    j++;
                }
                Cronometro.Stop();
                MessageBox.Show("Usuario inserido no Banco de Dados");
            }
            catch (Exception ex)
            {
                MessageBox.Show(text: ex.Message, caption: "Alerta de Exceção",
                   buttons: MessageBoxButtons.OK,
                   icon: MessageBoxIcon.Error);

            }
        }

        private void tmrCronometro_Tick(object sender, EventArgs e)
        {
            lblTempo.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Cronometro.Elapsed.Hours, Cronometro.Elapsed.Minutes, Cronometro.Elapsed.Seconds, Cronometro.Elapsed.Milliseconds / 10);
        }

     
    }
}
