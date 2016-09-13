namespace ppeTableauBord
{
    partial class tableauBord
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.occupation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.annee = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnConnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.occupation)).BeginInit();
            this.SuspendLayout();
            // 
            // occupation
            // 
            this.occupation.BackColor = System.Drawing.Color.Silver;
            chartArea2.Name = "ChartArea1";
            this.occupation.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.occupation.Legends.Add(legend2);
            this.occupation.Location = new System.Drawing.Point(150, 12);
            this.occupation.Name = "occupation";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "taux d\'occupation";
            this.occupation.Series.Add(series2);
            this.occupation.Size = new System.Drawing.Size(587, 300);
            this.occupation.TabIndex = 0;
            this.occupation.Text = "chart1";
            this.occupation.Click += new System.EventHandler(this.chart1_Click);
            // 
            // annee
            // 
            this.annee.AutoSize = true;
            this.annee.Location = new System.Drawing.Point(382, 397);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(0, 13);
            this.annee.TabIndex = 1;
            this.annee.Click += new System.EventHandler(this.annee_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(502, 392);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(235, 23);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = "année suivante";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(150, 392);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(171, 23);
            this.btnPrecedent.TabIndex = 3;
            this.btnPrecedent.Text = "année précédente";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(41, 237);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(75, 23);
            this.btnConnexion.TabIndex = 4;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // tableauBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 466);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.btnPrecedent);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.annee);
            this.Controls.Add(this.occupation);
            this.Name = "tableauBord";
            this.Text = "tableauBord";
            this.Load += new System.EventHandler(this.tableauBord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.occupation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart occupation;
        private System.Windows.Forms.Label annee;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnConnexion;

    }
}