using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btn_n2_Click(object sender, EventArgs e)
        {
            grp_n1.Visible = true;
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            
        
            // Dichiarazione e inizializzazione delle variabili base
            float costo = 0;
            float sconto = 0;
            float stagione = 0;
            float camera = 0;
            float parcheggio = 0;
            int giorni = 0;

            
            giorni = Convert.ToInt32(nud_n1.Value);

            

            if (cmb_n2.SelectedIndex == 2)
            {
                camera = 30;
            }
            else if (cmb_n2.SelectedIndex == 1)
            {
                camera = 15;
            }
            else
            {
                camera = 0;
            }

            
            if (cmb_n1.SelectedIndex == 2)
            {
                stagione = 10;
            }
            else if (cmb_n1.SelectedIndex == 1)
            {
                stagione = 5;
            }
            else
            {
                stagione = 0;
            }

           
            costo = (15 + camera + stagione) * giorni;
            
            if (chk_n1.Checked)
            {
                parcheggio = 5;
                parcheggio = parcheggio * giorni;
            }
            else
            {
                parcheggio = 0;
            }

           
            if (giorni >= 3 && giorni <= 7)
            {
                sconto = costo * 0.25f;
            }
            else if (giorni > 7)
            {
                sconto = costo * 0.35f;
            }
            else
            {
                sconto = 0;
            }

            
            costo = costo - sconto+parcheggio;

            
            MessageBox.Show("Il prezzo finale è : " + costo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
