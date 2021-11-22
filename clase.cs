using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_v1
{
    public class angajat
    {
        #region proprietati
        public string nume { get; set; }
        public string prenume { get; set; }
        public int pin { get; set; }
        public int id { get; set; }

        public int drepturi { get; set; }
        #endregion

        #region constructori
        public angajat()
        {
            nume = prenume= "NULL";
            pin = id = 0;
        }

        public angajat(int id, string nume, string prenume, int drepturi, int pin)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.drepturi = drepturi;
            this.pin = pin;
        }
        #endregion

        #region metode
        

        public string format_afisare()
        {
            string mesaj = $"{id}. {nume} {prenume} {drepturi}";

            return mesaj;
        }

        public string format_fisier()
        {
            string mesaj = $"{id};{nume};{prenume};{drepturi};{pin}";

            return mesaj;
        }
        #endregion
    };

    public class piesa
    {
        #region proprietati

        public string nume_marca { get; set; }
        public string nume_model { get; set; }
        public string nume_piesa { get; set; }
        public int an_fabricatie { get; set; }
        public double pret { get; set; }

        const string separator = ";";
        public int id { get; set; }
        //tip_piesa
        #endregion

        #region constructori

        public piesa()
        {
            nume_marca = nume_model = nume_piesa = "NULL";
            id=an_fabricatie = 0;
            pret = 0;
        }

        public piesa(int id, string nume_marca, string nume_model, int an_fabricatie, string nume_piesa,  double pret)
        {
            this.id = id;
            this.nume_marca = nume_marca;
            this.nume_model = nume_model;
            this.nume_piesa = nume_piesa;
            this.an_fabricatie = an_fabricatie;
            this.pret = pret;
        }
        #endregion

        #region metode

        public string format_afisare()
        {
            string mesaj = $"{id}. {nume_marca} {nume_model} {an_fabricatie} {nume_piesa} {pret}";

            return mesaj;
        }

        public string format_fisier()
        {
            string mesaj = $"{id};{nume_marca};{nume_model};{an_fabricatie};{nume_piesa};{pret}";

            return mesaj;
        }

        public void set(string linie)
        {
            string[] sir = linie.Split(separator);
            pret = Convert.ToDouble(sir[5]);
            id = Convert.ToInt32(sir[0]);
            an_fabricatie = Convert.ToInt32(sir[3]);
            nume_model = sir[2];
            nume_marca = sir[1];
            nume_piesa = sir[4];
        }
        #endregion
    };

    public class client
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string nr_telefon { get; set; }
        //public DateTime data_inregistrare { get; set; }

        public int id { get; set; }
        #region constructori
        public client()
        {
            nume = prenume = "NULL";
            nr_telefon = "NULL";
            //data_inregistrare = DateTime.Now;
            id = 0;
        }

        public client(int id, string nume, string prenume, string nr_telefon)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.nr_telefon = nr_telefon;
            //this.data_inregistrare = data_inregistrare;
        }
        #endregion

        #region metode

        public string format_afisare()
        {
            string mesaj=$"{id}. {nume} {prenume} {nr_telefon}";

            return mesaj;
        }

        public string format_fisier()
        {
            string mesaj = $"{id};{nume};{prenume};{nr_telefon}";

            return mesaj;
        }

        public void set(string linie)
        {
            string[] sir = linie.Split(';');
            
            
            bool ok = Int32.TryParse(sir[0], out int id);
            
            if(ok)
            {
                this.id = id;
                this.nume = sir[1];
                this.prenume = sir[2];
                this.nr_telefon = sir[3];
                //this.data_inregistrare = Convert.ToDateTime(sir[4]);
            }
        }
        #endregion
    };
}
