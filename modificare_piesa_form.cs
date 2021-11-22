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
    public partial class modificare_angajat_form : Form
    {
        public string piesa_original { get; set; }
        public string text { get; set; }
        int id, an_fabricatie;
        double pret;

        private string rezultat;

        public string Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }

        
        public modificare_angajat_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label1_BindingContextChanged(object sender, EventArgs e)
        {
            
        }

        private void anuleaza_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modificare_angajat_form_Load(object sender, EventArgs e)
        {
            label1.Text = text;

            string[] sir = piesa_original.Split(';');
            Int32.TryParse(sir[0], out id);
            Int32.TryParse(sir[3], out an_fabricatie);
            Double.TryParse(sir[5], out pret);

            nume_marca_modificat.Text = sir[1];
            nume_model_modificat.Text = sir[2];
            nume_piesa_modificat.Text = sir[4];
            an_fabricatie_modificat.Text = sir[3];
            pret_piesa_modificat.Text = sir[5];
        }

        private void modifica_button_Click(object sender, EventArgs e)
        {
            bool ok = true;
            ok=double.TryParse(pret_piesa_modificat.Text, out pret);
            if (!ok)
            {
                MessageBox.Show("Pretul trebuie sa fie scris in cifre arabe!!");
                Rezultat = "NULL";
            }
            else
            {
                ok = Int32.TryParse(an_fabricatie_modificat.Text, out an_fabricatie);
                if (!ok)
                {
                    MessageBox.Show("Anul de fabricatie trebuie sa fie scris in cifre arabe!!");
                    Rezultat = "NULL";
                }
                else
                    Rezultat = Convert.ToString(id) + ';' + nume_marca_modificat.Text + ';' + nume_model_modificat.Text + ';' + an_fabricatie_modificat.Text + ';' + nume_piesa_modificat.Text + ';' + pret_piesa_modificat.Text;

            }
                
        }
    }
}
