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
    public partial class admin_form : Form
    {
        public string nume_a { get; set; }
        public string prenume_a { get; set; }

        //CONSTANTA SEPARATOR
        const string separator = ";";
        //Initializarea listelor pentru obiectele claselor
        public List<angajat> a = new List<angajat>();
        public List<piesa> p = new List<piesa>();
        public List<client> c = new List<client>();

        #region initializare angajati si piese si client

        public void citire_fisier()
        {
            a.Clear();

            string linie,nume, prenume;
            int pin,id,drepturi;

            using (StreamReader f = new StreamReader("angajat.txt"))
            {

                do
                {
                    linie = f.ReadLine();
                    if (linie == null)
                        break;
                    string[] sir = linie.Split(separator);
                    Int32.TryParse(sir[0], out id);
                    nume = sir[1];
                    prenume = sir[2];
                    Int32.TryParse(sir[3], out drepturi);
                    Int32.TryParse(sir[4], out pin);

                    a.Add(new angajat(id, nume, prenume, drepturi, pin));
                } while (true);
            }
        }

        public void citire_fisier_piese()
        {
            p.Clear();
            
            string nume_marca, nume_model, nume_piesa,linie;
            int id, an_fabricatie;
            double pret;
            using (StreamReader f=new StreamReader("piesa.txt"))
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

        #region scriere fisier

        public void scriere_fisier_angajati()
        {
            using (StreamWriter f = new StreamWriter("angajat.txt"))
            {
                for (int i = 0; i < a.Count(); i++)
                    f.WriteLine(a[i].format_fisier());
            }
        }

        public void adaugare_fisier_angajati()
        {

            using (StreamWriter f = File.AppendText("angajat.txt"))
            {
                int n = a.Count;
                //MessageBox.Show(a[n - 1].format_fisier());
                f.WriteLine(a[n - 1].format_fisier());
            }
            
        }
        public void scriere_fisier_piese()
        {
            using (StreamWriter f = new StreamWriter("piesa.txt"))
            {
                for (int i = 0; i < p.Count; i++)
                    f.WriteLine(p[i].format_fisier());
            } 
        }

        public void adaugare_fisier_piese()
        {
            using (StreamWriter f = File.AppendText("piesa.txt"))
            {
                int n = p.Count;
                f.WriteLine(p[n - 1].format_fisier());
            }
        }

        public void scriere_fisier_client()
        {
            using (StreamWriter f = new StreamWriter("client.txt"))
            {
                for (int i = 0; i < c.Count; i++)
                    f.WriteLine(c[i].format_fisier());
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


        #region butoane angajat
        public admin_form()
        {
            InitializeComponent();
            
        }

        private void label1_BindingContextChanged(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label1.Text = nume_a + ' ' + prenume_a;
            //a.Clear();
            citire_fisier();
            citire_fisier_piese();
            Lista.Items.Clear();
            ListaPiese.Items.Clear();
            citire_fisier_client();
            ListaClienti.Items.Clear();
            label1.Refresh();
        }

        private void adaugare_angajat_Click(object sender, EventArgs e)
        {
            string angajat_nou="NULL";
            adaugare_angajatForm adaugare_a = new adaugare_angajatForm();
            if(adaugare_a.ShowDialog()==DialogResult.OK)
            {
                angajat_nou = adaugare_a.Angajat_nou;
                if(angajat_nou!="NULL")
                {
                    string[] sir_angajat_nou = angajat_nou.Split(' ');
                    int id_angajat_nou = a.Count, drepturi_angajat_nou, pin_angajat_nou;
                    //id_angajat_nou--;
                    id_angajat_nou = a[id_angajat_nou - 1].id;
                    id_angajat_nou++;
                    
                    Int32.TryParse(sir_angajat_nou[2], out drepturi_angajat_nou);
                    
                    Int32.TryParse(sir_angajat_nou[3],out pin_angajat_nou);
                    a.Add(new angajat(id_angajat_nou, sir_angajat_nou[0], sir_angajat_nou[1], drepturi_angajat_nou, pin_angajat_nou));
                    adaugare_fisier_angajati();
                    Lista.Items.Clear();
                    for (int i = 0; i < a.Count(); i++)
                        Lista.Items.Add(a[i].format_afisare());
                }
            }
        }

        private void vizualizare_angajat_Click(object sender, EventArgs e)
        {

            Lista.Items.Clear();
            for(int i=0; i<a.Count();i++)
                Lista.Items.Add(a[i].format_afisare());

        }

        private void stergere_angajat_Click(object sender, EventArgs e)
        {

            
            if (Lista.SelectedIndex == -1)
                MessageBox.Show("Selectati un angajat inainte !!");
            else
            {
                a.RemoveAt(Lista.SelectedIndex);
                scriere_fisier_angajati();
                Lista.Items.Clear();
                for (int i = 0; i < a.Count(); i++)
                    Lista.Items.Add(a[i].format_afisare());
            }
        }

        private void admin_form_Load(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        #endregion

        #region butoane piese

        private void adaugare_piesa_button_Click(object sender, EventArgs e)
        {
            adaugare_piesa_form adaugare_p = new adaugare_piesa_form();
            if(adaugare_p.ShowDialog()==DialogResult.OK)
            {
                string piesa_noua = adaugare_p.Piesa_noua;
                if(piesa_noua!="NULL")
                {
                    string[] sir_piesa_noua = piesa_noua.Split(separator);
                    int id_piesa_noua=p.Count;
                    id_piesa_noua = p[id_piesa_noua -1].id;
                    id_piesa_noua++;
                    Int32.TryParse(sir_piesa_noua[2], out int an);
                    Double.TryParse(sir_piesa_noua[4], out double pret);
                    p.Add(new piesa(id_piesa_noua, sir_piesa_noua[0], sir_piesa_noua[1], an, sir_piesa_noua[3], pret));
                    adaugare_fisier_piese();
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        ListaPiese.Items.Add(p[i].format_afisare());
                }
                
            }    

        }

        private void stergere_buton_button_Click(object sender, EventArgs e)
        {
            if (ListaPiese.SelectedIndex== -1)
                MessageBox.Show("Selectati un angajat inainte !!");
            else
            {
                //MessageBox.Show(Convert.ToString(ListaPiese.SelectedIndex));
                p.RemoveAt(ListaPiese.SelectedIndex);
                scriere_fisier_piese();
                ListaPiese.Items.Clear();
                for (int i = 0; i < p.Count; i++)
                    ListaPiese.Items.Add(p[i].format_afisare());
            }
        }

        private void afisare_piese_Click(object sender, EventArgs e)
        {
            ListaPiese.Items.Clear();
            for (int i = 0; i < p.Count; i++)
                ListaPiese.Items.Add(p[i].format_afisare());
        }


        private void filtrare_button_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (filtru_text.Text != "")
            {
                if (marca_check.Checked)
                {
                    ok = true;
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        if (p[i].nume_marca.ToUpper() == filtru_text.Text.ToUpper())
                            ListaPiese.Items.Add(p[i].format_afisare());
                    marca_check.Checked = false;
                }
                if (model_check.Checked)
                {
                    ok = true;
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        if (p[i].nume_model.ToUpper() == filtru_text.Text.ToUpper())
                            ListaPiese.Items.Add(p[i].format_afisare());
                    model_check.Checked = false;
                }
                if (piesa_check.Checked)
                {
                    ok = true;
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        if (p[i].nume_piesa.ToUpper() == filtru_text.Text.ToUpper())
                            ListaPiese.Items.Add(p[i].format_afisare());
                    piesa_check.Checked = false;
                }
                if (an_check.Checked)
                {
                    ok = true;
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        if (p[i].an_fabricatie == Convert.ToInt32(filtru_text.Text))
                            ListaPiese.Items.Add(p[i].format_afisare());
                    an_check.Checked = false;
                }
                if (mai_mare_de_check.Checked)
                {
                    ok = true;
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        if (p[i].pret > Convert.ToDouble(filtru_text.Text))
                            ListaPiese.Items.Add(p[i].format_afisare());
                    mai_mare_de_check.Checked = false;
                }
                if (mai_mic_de_check.Checked)
                {
                    ok = true;
                    ListaPiese.Items.Clear();
                    for (int i = 0; i < p.Count; i++)
                        if (p[i].pret < Convert.ToDouble(filtru_text.Text))
                            ListaPiese.Items.Add(p[i].format_afisare());
                    mai_mic_de_check.Checked = false;
                }

                if (!ok)
                    MessageBox.Show("Selectati o bifa !");
                else
                    filtru_text.Text = string.Empty;
                
            }
            else
                MessageBox.Show("Introduceti valoarea dupa care doriti sa fie aplicat filtrul !");
            
        }
        private void modificare_piesa_button_Click(object sender, EventArgs e)
        {
            string trimitere = p[ListaPiese.SelectedIndex].format_fisier();
            //MessageBox.Show(trimitere);
            modificare_angajat_form modificare_p = new modificare_angajat_form();
            modificare_p.piesa_original = trimitere;
            modificare_p.text = "Nume marca:";
            if (modificare_p.ShowDialog() == DialogResult.OK)
            {
                trimitere = modificare_p.Rezultat;
                p[ListaPiese.SelectedIndex].set(trimitere);
            }
        }

        private void marca_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void model_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void an_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void piesa_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mai_mare_de_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mai_mic_de_check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void filtru_text_TextChanged(object sender, EventArgs e)
        {

        }



        #endregion

        #region butoane clienti
        private void afisare_clienti_button_Click(object sender, EventArgs e)
        {
            ListaClienti.Items.Clear();
            //MessageBox.Show(Convert.ToString(c.Count));
            for (int i = 0; i < c.Count(); i++)
                ListaClienti.Items.Add(c[i].format_afisare());
        }
        

        private void stergere_clienti_button_Click(object sender, EventArgs e)
        {
            if (ListaClienti.SelectedIndex == -1)
                MessageBox.Show("Selectati o valoare ce doriti sa fie stearsa din lista !");
            else
            {
                c.RemoveAt(ListaClienti.SelectedIndex);
                scriere_fisier_client();
                //pentru refresh lista
                ListaClienti.Items.Clear();
                for (int i = 0; i < c.Count(); i++)
                    ListaClienti.Items.Add(c[i].format_afisare());
            }
            
        }

        private void afisare_registru_button_Click(object sender, EventArgs e)
        {
            afisare_registru afisare_r = new afisare_registru();
            afisare_r.ShowDialog();
        }
        #endregion
    }
}