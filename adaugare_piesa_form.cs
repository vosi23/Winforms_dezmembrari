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
    public partial class adaugare_piesa_form : Form
    {
        private string piesa_noua;

        public string Piesa_noua
        {
            get { return piesa_noua; }
            set { piesa_noua = value; }
        }

        public adaugare_piesa_form()
        {
            InitializeComponent();
        }

        private void adauga_button_Click(object sender, EventArgs e)
        {
            
            bool ok = true;
            if(nume_marca_text.Text=="" || nume_model_text.Text=="" || an_fabricatie_text.Text=="" || nume_piesa_text.Text=="" || pret_piesa_text.Text=="")
            {
                ok = false;
                MessageBox.Show("Toate campurile trebuie sa fie completate !!");
            }

            if(an_fabricatie_text.TextLength!=4)
            {
                ok = false;
                MessageBox.Show("Anul fabricatiei trebuie sa fie de exact 4 cifre!");
            }

            bool este_int = Int32.TryParse(an_fabricatie_text.Text, out int aux);
            if(!este_int)
            {
                ok = false;
                MessageBox.Show("Anul fabricatiei este introdus in cifre !");
            }
            este_int = double.TryParse(pret_piesa_text.Text, out double aux1);
            if(!este_int)
            {
                ok = false;
                MessageBox.Show("Pretul trebuie sa fie compus doar din cifre si zecimalele vor fi deosebita cu caracterul '.' !");
            }

            if (ok)
                Piesa_noua = nume_marca_text.Text + ';' + nume_model_text.Text + ';' + an_fabricatie_text.Text + ';' + nume_piesa_text.Text + ';' + pret_piesa_text.Text;
            else
                Piesa_noua = "NULL";
        }

        private void nume_marca_text_TextChanged(object sender, EventArgs e)
        {
               
        }

        
    }
}
