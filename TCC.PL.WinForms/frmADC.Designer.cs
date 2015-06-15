namespace TCC.PL.WinForms
{
    partial class frmADC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numupQtdInserts = new System.Windows.Forms.NumericUpDown();
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.cargaDadosBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numupQtdInserts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Inserts:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(25, 62);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpar Dados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // numupQtdInserts
            // 
            this.numupQtdInserts.Location = new System.Drawing.Point(133, 28);
            this.numupQtdInserts.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numupQtdInserts.Name = "numupQtdInserts";
            this.numupQtdInserts.Size = new System.Drawing.Size(120, 20);
            this.numupQtdInserts.TabIndex = 3;
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Interval = 1;
            this.tmrCronometro.Tick += new System.EventHandler(this.tmrCronometro_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(129, 106);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(116, 24);
            this.lblTempo.TabIndex = 4;
            this.lblTempo.Text = "00:00:00:00";
            // 
            // cargaDadosBackgroundWorker
            // 
            this.cargaDadosBackgroundWorker.WorkerReportsProgress = true;
            this.cargaDadosBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cargaDadosBackgroundWorker_DoWork);
            this.cargaDadosBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.cargaDadosBackgroundWorker_ProgressChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(25, 162);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 23);
            this.progressBar.TabIndex = 5;
            // 
            // frmADC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 197);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.numupQtdInserts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Name = "frmADC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Acesso a Dados Comum";
            ((System.ComponentModel.ISupportInitialize)(this.numupQtdInserts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numupQtdInserts;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.Windows.Forms.Label lblTempo;
        private System.ComponentModel.BackgroundWorker cargaDadosBackgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}