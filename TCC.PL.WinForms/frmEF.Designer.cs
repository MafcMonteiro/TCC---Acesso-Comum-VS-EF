namespace TCC.PL.WinForms
{
    partial class frmEF
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
            this.numupQtdInserts = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrCronometro = new System.Windows.Forms.Timer(this.components);
            this.cargaDadosBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblTempo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numupQtdInserts)).BeginInit();
            this.SuspendLayout();
            // 
            // numupQtdInserts
            // 
            this.numupQtdInserts.Location = new System.Drawing.Point(123, 7);
            this.numupQtdInserts.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numupQtdInserts.Name = "numupQtdInserts";
            this.numupQtdInserts.Size = new System.Drawing.Size(120, 20);
            this.numupQtdInserts.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Limpar Dados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 41);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade de Inserts:";
            // 
            // tmrCronometro
            // 
            this.tmrCronometro.Interval = 1;
            this.tmrCronometro.Tick += new System.EventHandler(this.tmrCronometro_Tick);
            // 
            // cargaDadosBackgroundWorker
            // 
            this.cargaDadosBackgroundWorker.WorkerReportsProgress = true;
            this.cargaDadosBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.cargaDadosBackgroundWorker_DoWork);
            this.cargaDadosBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.cargaDadosBackgroundWorker_ProgressChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(30, 175);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(338, 23);
            this.progressBar.TabIndex = 9;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(143, 133);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(116, 24);
            this.lblTempo.TabIndex = 8;
            this.lblTempo.Text = "00:00:00:00";
            // 
            // frmEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 210);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.numupQtdInserts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Name = "frmEF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Entity Framework";
            ((System.ComponentModel.ISupportInitialize)(this.numupQtdInserts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numupQtdInserts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrCronometro;
        private System.ComponentModel.BackgroundWorker cargaDadosBackgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblTempo;

    }
}