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
    public partial class Normal : Form
    {
        public string nume { get; set; }
        public int id_angajat { get; set; }
        List<client> c = new List<client>();
        List<piesa> p = new List<piesa>();
        const string separator = ";";

        #region initializare citire clienti si piese

        public void citire_fisier_piese()
        {
            p.Clear();

            string nume_marca, nume_model, nume_piesa, linie;
            int id, an_fabricatie;
            double pret;
            using (StreamReader f = new StreamReader("piesa.txt"))
            {
                do
                {
                    linie = f.ReadLine();
                    if (linie == null)
                        break;
                    string[] sir = linie.Split(separator);
                    Int32.TryParse(sir[0], out id);
                    nume_marca = sir[1];
                    nume_model = sir[2];
                    Int32.TryParse(sir[3], out an_fabricatie);
                    nume_piesa = sir[4];
                    double.TryParse(sir[5], out pret);
                    p.Add(new piesa(id, nume_marca, nume_model, an_fabricatie, nume_piesa, pret));
                } while (true);
            }
        }

        public void citire_fisier_client()
        {
            c.Clear();
            string linie;
            using (StreamReader f = new StreamReader("client.txt"))
            {
                do
                {

                    linie = f.ReadLine();
                    if (linie == null)
                        break;
                    string[] sir = linie.Split(separator);
                    Int32.TryParse(sir[0], out int id);

                    c.Add(new client(id, sir[1], sir[2], sir[3]));
                } while (true);
            }
        }

        #endregion

        #region scriere in fisier
        public void scriere_fisier_piese()
        {
            using (StreamWriter f = new StreamWriter("piesa.txt"))
            {
                for (int i = 0; i < p.Count; i++)
                    f.WriteLine(p[i].format_fisier());
            }
        }

        public void adaugare_fisier_client()
        {
            using (StreamWriter f = File.AppendText("client.txt"))
            {
                int n = c.Count;
                f.WriteLine(c[n - 1].format_fisier());
            }
        }
        #endregion
        public Normal()
        {
            InitializeComponent();
            
        }
        private void Normal_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Text = nume;
            label1.Refresh();

            citire_fisier_client();
            citire_fisier_piese();
        }

        #region others

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #region clienti
        

        private void Afisare_cleinti_button_Click(object sender, EventArgs e)
        {
            lista_clienti.Items.Clear();
            for (int i = 0; i < c.Count; i++)
                lista_clienti.Items.Add(c[i].format_afisare());
        }

        private void adaugare_client_button_Click(object sender, EventArgs e)
        {
            adaugare_client adaugare_c = new adaugare_client();
            if(adaugare_c.ShowDialog()==DialogResult.OK)
            {
                string rezultat = adaugare_c.Rezultat;
                string[] sir = rezultat.Split(separator);
                int id_client = lista_clienti.Items.Count;
                 id_client = c[id_client-1].id;
                id_client++;
                c.Add(new client(id_client, sir[0], sir[1], sir[2]));
                adaugare_fisier_client();
            }
        }
        #endregion

        #region piese

        private void afisare_piesa_button_Click(object sender, EventArgs e)
        {
            lista_piese.Items.Clear();
            for (int i = 0; i < p.Count; i++)
                lista_piese.Items.Add(p[i].format_afisare());
        }

        private void vanzare_button_Click(object sender, EventArgs e)
        {
            if (lista_piese.SelectedIndex >= 0 && lista_clienti.SelectedIndex >= 0)
            {
                string for_client = c[lista_clienti.SelectedIndex].format_afisare();
                string for_piesa = p[lista_piese.SelectedIndex].format_afisare();

                using (StreamWriter f= File.AppendText("registru_vanzare.txt"))
                    f.WriteLine($"{id_angajat}. {nume}| {for_client} -> {for_piesa}");

                p.RemoveAt(lista_piese.SelectedIndex);
                scriere_fisier_piese();


                //pentru refresh lista piese
                lista_piese.Items.Clear();
                for (int i = 0; i < p.Count; i++)
                    lista_piese.Items.Add(p[i].format_afisare());
            }
            else
                MessageBox.Show("Selectati clientul si piesa dorita!");
        }
        #endregion

        private void log_off_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
