
namespace proiect_v1
{
    partial class Normal
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
            this.Afisare_clienti_button = new System.Windows.Forms.Button();
            this.adaugare_client_button = new System.Windows.Forms.Button();
            this.lista_clienti = new System.Windows.Forms.ListBox();
            this.afisare_piesa_button = new System.Windows.Forms.Button();
            this.lista_piese = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vanzare_button = new System.Windows.Forms.Button();
            this.log_off_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Afisare_clienti_button
            // 
            this.Afisare_clienti_button.Location = new System.Drawing.Point(12, 72);
            this.Afisare_clienti_button.Name = "Afisare_clienti_button";
            this.Afisare_clienti_button.Size = new System.Drawing.Size(75, 42);
            this.Afisare_clienti_button.TabIndex = 0;
            this.Afisare_clienti_button.Text = "Afiseaza Clientii";
            this.Afisare_clienti_button.UseVisualStyleBackColor = true;
            this.Afisare_clienti_button.Click += new System.EventHandler(this.Afisare_cleinti_button_Click);
            // 
            // adaugare_client_button
            // 
            this.adaugare_client_button.Location = new System.Drawing.Point(148, 72);
            this.adaugare_client_button.Name = "adaugare_client_button";
            this.adaugare_client_button.Size = new System.Drawing.Size(75, 42);
            this.adaugare_client_button.TabIndex = 1;
            this.adaugare_client_button.Text = "Adaugare Clienti";
            this.adaugare_client_button.UseVisualStyleBackColor = true;
            this.adaugare_client_button.Click += new System.EventHandler(this.adaugare_client_button_Click);
            // 
            // lista_clienti
            // 
            this.lista_clienti.FormattingEnabled = true;
            this.lista_clienti.ItemHeight = 15;
            this.lista_clienti.Location = new System.Drawing.Point(12, 120);
            this.lista_clienti.Name = "lista_clienti";
            this.lista_clienti.Size = new System.Drawing.Size(232, 319);
            this.lista_clienti.TabIndex = 2;
            // 
            // afisare_piesa_button
            // 
            this.afisare_piesa_button.Location = new System.Drawing.Point(361, 72);
            this.afisare_piesa_button.Name = "afisare_piesa_button";
            this.afisare_piesa_button.Size = new System.Drawing.Size(75, 42);
            this.afisare_piesa_button.TabIndex = 3;
            this.afisare_piesa_button.Text = "Afisare piese";
            this.afisare_piesa_button.UseVisualStyleBackColor = true;
            this.afisare_piesa_button.Click += new System.EventHandler(this.afisare_piesa_button_Click);
            // 
            // lista_piese
            // 
            this.lista_piese.FormattingEnabled = true;
            this.lista_piese.ItemHeight = 15;
            this.lista_piese.Location = new System.Drawing.Point(361, 120);
            this.lista_piese.Name = "lista_piese";
            this.lista_piese.Size = new System.Drawing.Size(232, 319);
            this.lista_piese.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vanzare_button
            // 
            this.vanzare_button.Location = new System.Drawing.Point(505, 72);
            this.vanzare_button.Name = "vanzare_button";
            this.vanzare_button.Size = new System.Drawing.Size(75, 42);
            this.vanzare_button.TabIndex = 6;
            this.vanzare_button.Text = "Vanzare piesa";
            this.vanzare_button.UseVisualStyleBackColor = true;
            this.vanzare_button.Click += new System.EventHandler(this.vanzare_button_Click);
            // 
            // log_off_button
            // 
            this.log_off_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log_off_button.Location = new System.Drawing.Point(0, 453);
            this.log_off_button.Name = "log_off_button";
            this.log_off_button.Size = new System.Drawing.Size(634, 42);
            this.log_off_button.TabIndex = 7;
            this.log_off_button.Text = "Log OFF";
            this.log_off_button.UseVisualStyleBackColor = true;
            this.log_off_button.Click += new System.EventHandler(this.log_off_button_Click);
            // 
            // Normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.log_off_button;
            this.ClientSize = new System.Drawing.Size(634, 495);
            this.Controls.Add(this.log_off_button);
            this.Controls.Add(this.vanzare_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_piese);
            this.Controls.Add(this.afisare_piesa_button);
            this.Controls.Add(this.lista_clienti);
            this.Controls.Add(this.adaugare_client_button);
            this.Controls.Add(this.Afisare_clienti_button);
            this.Name = "Normal";
            this.Text = " Vanzari";
            this.Load += new System.EventHandler(this.Normal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Afisare_clienti_button;
        private System.Windows.Forms.Button adaugare_client_button;
        private System.Windows.Forms.ListBox lista_clienti;
        private System.Windows.Forms.Button afisare_piesa_button;
        private System.Windows.Forms.ListBox lista_piese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vanzare_button;
        private System.Windows.Forms.Button log_off_button;
    }
}