
namespace proiect_v1
{
    partial class admin_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_form));
            this.label1 = new System.Windows.Forms.Label();
            this.adaugare_angajat = new System.Windows.Forms.Button();
            this.stergere_angajat = new System.Windows.Forms.Button();
            this.vizualizare_angajat = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.Log_off_button = new System.Windows.Forms.Button();
            this.ListaPiese = new System.Windows.Forms.ListBox();
            this.adaugare_piesa_button = new System.Windows.Forms.Button();
            this.stergere_buton_button = new System.Windows.Forms.Button();
            this.afisare_piese = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filtru_text = new System.Windows.Forms.TextBox();
            this.marca_check = new System.Windows.Forms.RadioButton();
            this.model_check = new System.Windows.Forms.RadioButton();
            this.an_check = new System.Windows.Forms.RadioButton();
            this.piesa_check = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filtrare_button = new System.Windows.Forms.Button();
            this.mai_mare_de_check = new System.Windows.Forms.RadioButton();
            this.mai_mic_de_check = new System.Windows.Forms.RadioButton();
            this.modificare_piesa_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ListaClienti = new System.Windows.Forms.ListBox();
            this.afisare_clienti_button = new System.Windows.Forms.Button();
            this.stergere_clienti_button = new System.Windows.Forms.Button();
            this.afisare_registru_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.BindingContextChanged += new System.EventHandler(this.label1_BindingContextChanged);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adaugare_angajat
            // 
            this.adaugare_angajat.Location = new System.Drawing.Point(12, 63);
            this.adaugare_angajat.Name = "adaugare_angajat";
            this.adaugare_angajat.Size = new System.Drawing.Size(75, 42);
            this.adaugare_angajat.TabIndex = 1;
            this.adaugare_angajat.Text = "Adaugare Angajat";
            this.adaugare_angajat.UseVisualStyleBackColor = true;
            this.adaugare_angajat.Click += new System.EventHandler(this.adaugare_angajat_Click);
            // 
            // stergere_angajat
            // 
            this.stergere_angajat.Location = new System.Drawing.Point(102, 63);
            this.stergere_angajat.Name = "stergere_angajat";
            this.stergere_angajat.Size = new System.Drawing.Size(75, 42);
            this.stergere_angajat.TabIndex = 2;
            this.stergere_angajat.Text = "Stergere Angajat";
            this.stergere_angajat.UseVisualStyleBackColor = true;
            this.stergere_angajat.Click += new System.EventHandler(this.stergere_angajat_Click);
            // 
            // vizualizare_angajat
            // 
            this.vizualizare_angajat.Location = new System.Drawing.Point(200, 63);
            this.vizualizare_angajat.Name = "vizualizare_angajat";
            this.vizualizare_angajat.Size = new System.Drawing.Size(75, 42);
            this.vizualizare_angajat.TabIndex = 3;
            this.vizualizare_angajat.Text = "Afisare Angajati";
            this.vizualizare_angajat.UseVisualStyleBackColor = true;
            this.vizualizare_angajat.Click += new System.EventHandler(this.vizualizare_angajat_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 15;
            this.Lista.Location = new System.Drawing.Point(13, 132);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(263, 289);
            this.Lista.TabIndex = 4;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // Log_off_button
            // 
            this.Log_off_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Log_off_button.Location = new System.Drawing.Point(0, 588);
            this.Log_off_button.Name = "Log_off_button";
            this.Log_off_button.Size = new System.Drawing.Size(1115, 42);
            this.Log_off_button.TabIndex = 5;
            this.Log_off_button.Text = "Log Off";
            this.Log_off_button.UseVisualStyleBackColor = true;
            this.Log_off_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // ListaPiese
            // 
            this.ListaPiese.FormattingEnabled = true;
            this.ListaPiese.ItemHeight = 15;
            this.ListaPiese.Location = new System.Drawing.Point(398, 140);
            this.ListaPiese.Name = "ListaPiese";
            this.ListaPiese.Size = new System.Drawing.Size(348, 289);
            this.ListaPiese.TabIndex = 6;
            // 
            // adaugare_piesa_button
            // 
            this.adaugare_piesa_button.Location = new System.Drawing.Point(398, 63);
            this.adaugare_piesa_button.Name = "adaugare_piesa_button";
            this.adaugare_piesa_button.Size = new System.Drawing.Size(75, 42);
            this.adaugare_piesa_button.TabIndex = 7;
            this.adaugare_piesa_button.Text = "Adaugare Piesa";
            this.adaugare_piesa_button.UseVisualStyleBackColor = true;
            this.adaugare_piesa_button.Click += new System.EventHandler(this.adaugare_piesa_button_Click);
            // 
            // stergere_buton_button
            // 
            this.stergere_buton_button.Location = new System.Drawing.Point(495, 63);
            this.stergere_buton_button.Name = "stergere_buton_button";
            this.stergere_buton_button.Size = new System.Drawing.Size(75, 42);
            this.stergere_buton_button.TabIndex = 8;
            this.stergere_buton_button.Text = "Stergere Piesa";
            this.stergere_buton_button.UseVisualStyleBackColor = true;
            this.stergere_buton_button.Click += new System.EventHandler(this.stergere_buton_button_Click);
            // 
            // afisare_piese
            // 
            this.afisare_piese.Location = new System.Drawing.Point(584, 63);
            this.afisare_piese.Name = "afisare_piese";
            this.afisare_piese.Size = new System.Drawing.Size(75, 42);
            this.afisare_piese.TabIndex = 9;
            this.afisare_piese.Text = "Afisare Piesa";
            this.afisare_piese.UseVisualStyleBackColor = true;
            this.afisare_piese.Click += new System.EventHandler(this.afisare_piese_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(328, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 566);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filtrare piese dupa:";
            // 
            // filtru_text
            // 
            this.filtru_text.Location = new System.Drawing.Point(398, 511);
            this.filtru_text.Name = "filtru_text";
            this.filtru_text.Size = new System.Drawing.Size(123, 23);
            this.filtru_text.TabIndex = 14;
            this.filtru_text.TextChanged += new System.EventHandler(this.filtru_text_TextChanged);
            // 
            // marca_check
            // 
            this.marca_check.AutoSize = true;
            this.marca_check.Location = new System.Drawing.Point(398, 450);
            this.marca_check.Name = "marca_check";
            this.marca_check.Size = new System.Drawing.Size(58, 19);
            this.marca_check.TabIndex = 20;
            this.marca_check.TabStop = true;
            this.marca_check.Text = "Marca";
            this.marca_check.UseVisualStyleBackColor = true;
            this.marca_check.CheckedChanged += new System.EventHandler(this.marca_check_CheckedChanged);
            // 
            // model_check
            // 
            this.model_check.AutoSize = true;
            this.model_check.Location = new System.Drawing.Point(462, 450);
            this.model_check.Name = "model_check";
            this.model_check.Size = new System.Drawing.Size(59, 19);
            this.model_check.TabIndex = 21;
            this.model_check.TabStop = true;
            this.model_check.Text = "Model";
            this.model_check.UseVisualStyleBackColor = true;
            this.model_check.CheckedChanged += new System.EventHandler(this.model_check_CheckedChanged);
            // 
            // an_check
            // 
            this.an_check.AutoSize = true;
            this.an_check.Location = new System.Drawing.Point(527, 450);
            this.an_check.Name = "an_check";
            this.an_check.Size = new System.Drawing.Size(92, 19);
            this.an_check.TabIndex = 22;
            this.an_check.TabStop = true;
            this.an_check.Text = "An fabricatie";
            this.an_check.UseVisualStyleBackColor = true;
            this.an_check.CheckedChanged += new System.EventHandler(this.an_check_CheckedChanged);
            // 
            // piesa_check
            // 
            this.piesa_check.AutoSize = true;
            this.piesa_check.Location = new System.Drawing.Point(621, 450);
            this.piesa_check.Name = "piesa_check";
            this.piesa_check.Size = new System.Drawing.Size(52, 19);
            this.piesa_check.TabIndex = 23;
            this.piesa_check.TabStop = true;
            this.piesa_check.Text = "Piesa";
            this.piesa_check.UseVisualStyleBackColor = true;
            this.piesa_check.CheckedChanged += new System.EventHandler(this.piesa_check_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 511);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 23);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // filtrare_button
            // 
            this.filtrare_button.Location = new System.Drawing.Point(532, 511);
            this.filtrare_button.Name = "filtrare_button";
            this.filtrare_button.Size = new System.Drawing.Size(75, 23);
            this.filtrare_button.TabIndex = 25;
            this.filtrare_button.Text = "Filtrare";
            this.filtrare_button.UseVisualStyleBackColor = true;
            this.filtrare_button.Click += new System.EventHandler(this.filtrare_button_Click);
            // 
            // mai_mare_de_check
            // 
            this.mai_mare_de_check.AutoSize = true;
            this.mai_mare_de_check.Location = new System.Drawing.Point(398, 475);
            this.mai_mare_de_check.Name = "mai_mare_de_check";
            this.mai_mare_de_check.Size = new System.Drawing.Size(128, 19);
            this.mai_mare_de_check.TabIndex = 26;
            this.mai_mare_de_check.TabStop = true;
            this.mai_mare_de_check.Text = "Pretul mai mare de:";
            this.mai_mare_de_check.UseVisualStyleBackColor = true;
            this.mai_mare_de_check.CheckedChanged += new System.EventHandler(this.mai_mare_de_check_CheckedChanged);
            // 
            // mai_mic_de_check
            // 
            this.mai_mic_de_check.AutoSize = true;
            this.mai_mic_de_check.Location = new System.Drawing.Point(532, 475);
            this.mai_mic_de_check.Name = "mai_mic_de_check";
            this.mai_mic_de_check.Size = new System.Drawing.Size(127, 19);
            this.mai_mic_de_check.TabIndex = 27;
            this.mai_mic_de_check.TabStop = true;
            this.mai_mic_de_check.Text = "Pretul mai mica de:";
            this.mai_mic_de_check.UseVisualStyleBackColor = true;
            this.mai_mic_de_check.CheckedChanged += new System.EventHandler(this.mai_mic_de_check_CheckedChanged);
            // 
            // modificare_piesa_button
            // 
            this.modificare_piesa_button.Location = new System.Drawing.Point(679, 63);
            this.modificare_piesa_button.Name = "modificare_piesa_button";
            this.modificare_piesa_button.Size = new System.Drawing.Size(75, 42);
            this.modificare_piesa_button.TabIndex = 28;
            this.modificare_piesa_button.Text = "Modificare Piesa";
            this.modificare_piesa_button.UseVisualStyleBackColor = true;
            this.modificare_piesa_button.Click += new System.EventHandler(this.modificare_piesa_button_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(793, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 566);
            this.label2.TabIndex = 29;
            // 
            // ListaClienti
            // 
            this.ListaClienti.FormattingEnabled = true;
            this.ListaClienti.ItemHeight = 15;
            this.ListaClienti.Location = new System.Drawing.Point(816, 132);
            this.ListaClienti.Name = "ListaClienti";
            this.ListaClienti.Size = new System.Drawing.Size(274, 289);
            this.ListaClienti.TabIndex = 30;
            // 
            // afisare_clienti_button
            // 
            this.afisare_clienti_button.Location = new System.Drawing.Point(816, 63);
            this.afisare_clienti_button.Name = "afisare_clienti_button";
            this.afisare_clienti_button.Size = new System.Drawing.Size(75, 42);
            this.afisare_clienti_button.TabIndex = 31;
            this.afisare_clienti_button.Text = "Afisare Clienti";
            this.afisare_clienti_button.UseVisualStyleBackColor = true;
            this.afisare_clienti_button.Click += new System.EventHandler(this.afisare_clienti_button_Click);
            // 
            // stergere_clienti_button
            // 
            this.stergere_clienti_button.Location = new System.Drawing.Point(908, 63);
            this.stergere_clienti_button.Name = "stergere_clienti_button";
            this.stergere_clienti_button.Size = new System.Drawing.Size(75, 42);
            this.stergere_clienti_button.TabIndex = 32;
            this.stergere_clienti_button.Text = "Stergere Clienti";
            this.stergere_clienti_button.UseVisualStyleBackColor = true;
            this.stergere_clienti_button.Click += new System.EventHandler(this.stergere_clienti_button_Click);
            // 
            // afisare_registru_button
            // 
            this.afisare_registru_button.Location = new System.Drawing.Point(1005, 63);
            this.afisare_registru_button.Name = "afisare_registru_button";
            this.afisare_registru_button.Size = new System.Drawing.Size(85, 63);
            this.afisare_registru_button.TabIndex = 33;
            this.afisare_registru_button.Text = "Afisare Registru vanzari";
            this.afisare_registru_button.UseVisualStyleBackColor = true;
            this.afisare_registru_button.Click += new System.EventHandler(this.afisare_registru_button_Click);
            // 
            // admin_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Log_off_button;
            this.ClientSize = new System.Drawing.Size(1115, 630);
            this.Controls.Add(this.afisare_registru_button);
            this.Controls.Add(this.stergere_clienti_button);
            this.Controls.Add(this.afisare_clienti_button);
            this.Controls.Add(this.ListaClienti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificare_piesa_button);
            this.Controls.Add(this.mai_mic_de_check);
            this.Controls.Add(this.mai_mare_de_check);
            this.Controls.Add(this.filtrare_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.piesa_check);
            this.Controls.Add(this.an_check);
            this.Controls.Add(this.model_check);
            this.Controls.Add(this.marca_check);
            this.Controls.Add(this.filtru_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afisare_piese);
            this.Controls.Add(this.stergere_buton_button);
            this.Controls.Add(this.adaugare_piesa_button);
            this.Controls.Add(this.ListaPiese);
            this.Controls.Add(this.Log_off_button);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.vizualizare_angajat);
            this.Controls.Add(this.stergere_angajat);
            this.Controls.Add(this.adaugare_angajat);
            this.Controls.Add(this.label1);
            this.Name = "admin_form";
            this.Text = "Piesa";
            this.Load += new System.EventHandler(this.admin_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adaugare_angajat;
        private System.Windows.Forms.Button stergere_angajat;
        private System.Windows.Forms.Button vizualizare_angajat;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.Button Log_off_button;
        private System.Windows.Forms.ListBox ListaPiese;
        private System.Windows.Forms.Button adaugare_piesa_button;
        private System.Windows.Forms.Button stergere_buton_button;
        private System.Windows.Forms.Button afisare_piese;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filtru_text;
        private System.Windows.Forms.RadioButton marca_check;
        private System.Windows.Forms.RadioButton model_check;
        private System.Windows.Forms.RadioButton an_check;
        private System.Windows.Forms.RadioButton piesa_check;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button filtrare_button;
        private System.Windows.Forms.RadioButton mai_mare_de_check;
        private System.Windows.Forms.RadioButton mai_mic_de_check;
        private System.Windows.Forms.Button modificare_piesa_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListaClienti;
        private System.Windows.Forms.Button afisare_clienti_button;
        private System.Windows.Forms.Button stergere_clienti_button;
        private System.Windows.Forms.Button afisare_registru_button;
    }
}