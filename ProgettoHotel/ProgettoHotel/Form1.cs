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

            // Lettura del numero di giorni dal NumericUpDown (nud_n1)
            giorni = Convert.ToInt32(nud_n1.Value);

            

            // 2. Calcolo supplemento Camera (cmb_n2)
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

            // 3. Calcolo supplemento Stagione (cmb_n1)
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

            // Calcolo del costo base totale prima dello sconto
            costo = (15 + camera + stagione) * giorni;
            // 1. Calcolo tariffa Parcheggio (chk_n1)
            if (chk_n1.Checked)
            {
                parcheggio = 5;
                parcheggio = parcheggio * giorni;
            }
            else
            {
                parcheggio = 0;
            }

            // 4. Calcolo dello Sconto progressivo sui giorni
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

            // Calcolo del costo finale netto
            costo = costo - sconto+parcheggio;

            // Output finale
            MessageBox.Show("Il prezzo finale è : " + costo);
        }
    }
    
}
