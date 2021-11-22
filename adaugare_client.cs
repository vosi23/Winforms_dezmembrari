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
    public partial class adaugare_client : Form
    {
        private string rezultat;

        public string Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }

        public adaugare_client()
        {
            InitializeComponent();
        }

        private void adauga_button_Click(object sender, EventArgs e)
        {

            if (nume_text.Text == "" || prenume_text.Text == "" || numar_text.Text == "")
            {
                MessageBox.Show("Introduceti caractere in campurile goale ! ");
                Rezultat = "NULL";
            }
            else
                Rezultat = nume_text.Text + ';' + prenume_text.Text + ';' + numar_text.Text;

        }
    }
}
