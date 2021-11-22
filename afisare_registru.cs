using System;
using System.IO;
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
    public partial class afisare_registru : Form
    {
        public afisare_registru()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Close();

            
        }


        private void afisare_registru_Load(object sender, EventArgs e)
        {
            Lista_Registri.Items.Clear();
            using (StreamReader f = new StreamReader("registru_vanzare.txt"))
            {
                do
                {
                    string linie = f.ReadLine();
                    if (linie == null)
                        break;
                    Lista_Registri.Items.Add(linie);
                } while (true);
            }
        }
    }
}

