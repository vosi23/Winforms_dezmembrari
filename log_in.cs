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
    public partial class log_inForm : Form
    {
        
        public log_inForm()
        {
            InitializeComponent();
        }

        private void log_inbutton_Click(object sender, EventArgs e)
        {
            #region validare log_in
            string nume, prenume, linie, text = login_textbox.Text;
            int pin2,pin, id, drepturi;
            bool esteint = Int32.TryParse(text, out pin2);
            
            if(esteint==false)
                MessageBox.Show("EROARE!!\nPin-ul contine doar CIFRE!!");
            else
            {
                if (File.Exists("angajat.txt") && File.Exists("piesa.txt") && File.Exists("client.txt") && File.Exists("registru_vanzare.txt"))
                {
                    
                        StreamReader f = new StreamReader("angajat.txt");
                        bool gasire_pin = false;
                        do
                        {
                            linie = f.ReadLine();

                            if (linie == null)
                                break;
                            string[] sir = linie.Split(';');
                            Int32.TryParse(sir[0], out id);
                            nume = sir[1];
                            prenume = sir[2];
                            Int32.TryParse(sir[3], out drepturi);
                            Int32.TryParse(sir[4], out pin);
                            if (pin2 == pin)
                            {
                                f.Close();
                            gasire_pin = true;
                                
                                if (drepturi == 1)
                            {
                                Normal normal_f = new Normal();
                                normal_f.nume = nume + ' ' + prenume;
                                normal_f.id_angajat = id;
                                normal_f.ShowDialog();
                                this.login_textbox.Text = String.Empty;
                            }
                           
                                if (drepturi == 2)
                                MessageBox.Show("gasit");
                            if (drepturi == 3)
                                {
                                    admin_form admin_f = new admin_form();
                                    admin_f.nume_a = nume;
                                    admin_f.prenume_a = prenume;
                                    admin_f.ShowDialog();

                                    this.login_textbox.Text = String.Empty;
                                    
                                }
                                break;
                            }
                        } while (linie != null);
                        
                        if(!gasire_pin)
                        MessageBox.Show("PIN introdus invalid !!!");
                }
                else
                    MessageBox.Show("Eroare !! \n Anumite fisiere nu se gasesc !!!");
            }
            #endregion

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
