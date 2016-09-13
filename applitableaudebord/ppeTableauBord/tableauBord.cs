using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ppeTableauBord
{
    public partial class tableauBord : Form
    {
       

        public tableauBord()
        {
            InitializeComponent();
            List<Pourcentage> desPourcentages = Passerelle.donnerLesPourcentages(2016);
            foreach (Pourcentage unPourcentage in desPourcentages)
            {
                this.occupation.Series["taux d'occupation"].Points.AddXY(unPourcentage.getleMois(), unPourcentage.getTaux());
            }
 
           
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void annee_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
           

        }

        private void tableauBord_Load(object sender, EventArgs e)
        {
           
        }
    }
}