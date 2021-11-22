using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_v1
{
    public partial class adaugare_angajatForm : Form
    {
        private string angajat_nou;
        public string Angajat_nou
        {
            get { return angajat_nou; }
            set { angajat_nou = value; }
        }
        int pin_aux;
        public adaugare_angajatForm()
        {
            InitializeComponent();
        }

        private void nume_prenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void anuleaza_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adauga_button_Click(object sender, EventArgs e)
        {
            bool ok = true;
            string drepturi="NULL";
            if (pin.TextLength != 5)
            {
                MessageBox.Show("Pinul trebuie contina exact 5 cifre!");
                ok = false;
            }
            if (!Int32.TryParse(pin.Text, out pin_aux))
            {
                MessageBox.Show("Pinul trebuie sa contina doar cifre!!");
                ok = false;
            }
            if(!Admin_check.Checked && !normal_check.Checked)
            {
                MessageBox.Show("Trebuie sa selectati functia angajatului !");
                ok = false;
            }
            if (Admin_check.Checked)
                drepturi = "3";
            if (normal_check.Checked)
                drepturi = "1";
            if (nume_prenume.Text=="")
            {
                MessageBox.Show("Adaugati numele si prenumele angajatului!");
                ok = false;
            }

            if (ok)
                Angajat_nou = nume_prenume.Text+' '+drepturi+' '+pin.Text;
            else
                Angajat_nou = "NULL";
        }

        private void Admin_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void normal_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
