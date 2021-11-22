
namespace proiect_v1
{
    partial class modificare_angajat_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.nume_marca_modificat = new System.Windows.Forms.TextBox();
            this.modifica_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nume_model_modificat = new System.Windows.Forms.TextBox();
            this.an_fabricatie_modificat = new System.Windows.Forms.TextBox();
            this.nume_piesa_modificat = new System.Windows.Forms.TextBox();
            this.pret_piesa_modificat = new System.Windows.Forms.TextBox();
            this.anuleaza_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numele marcii:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nume_marca_modificat
            // 
            this.nume_marca_modificat.Location = new System.Drawing.Point(12, 27);
            this.nume_marca_modificat.Name = "nume_marca_modificat";
            this.nume_marca_modificat.Size = new System.Drawing.Size(178, 23);
            this.nume_marca_modificat.TabIndex = 1;
            // 
            // modifica_button
            // 
            this.modifica_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.modifica_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modifica_button.Location = new System.Drawing.Point(0, 338);
            this.modifica_button.Name = "modifica_button";
            this.modifica_button.Size = new System.Drawing.Size(243, 40);
            this.modifica_button.TabIndex = 2;
            this.modifica_button.Text = "Modifica";
            this.modifica_button.UseVisualStyleBackColor = true;
            this.modifica_button.Click += new System.EventHandler(this.modifica_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numele modelului:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anul de fabricatie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numele piesei:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pretul piesei:";
            // 
            // nume_model_modificat
            // 
            this.nume_model_modificat.Location = new System.Drawing.Point(12, 80);
            this.nume_model_modificat.Name = "nume_model_modificat";
            this.nume_model_modificat.Size = new System.Drawing.Size(178, 23);
            this.nume_model_modificat.TabIndex = 7;
            // 
            // an_fabricatie_modificat
            // 
            this.an_fabricatie_modificat.Location = new System.Drawing.Point(12, 139);
            this.an_fabricatie_modificat.Name = "an_fabricatie_modificat";
            this.an_fabricatie_modificat.Size = new System.Drawing.Size(178, 23);
            this.an_fabricatie_modificat.TabIndex = 8;
            // 
            // nume_piesa_modificat
            // 
            this.nume_piesa_modificat.Location = new System.Drawing.Point(12, 195);
            this.nume_piesa_modificat.Name = "nume_piesa_modificat";
            this.nume_piesa_modificat.Size = new System.Drawing.Size(178, 23);
            this.nume_piesa_modificat.TabIndex = 9;
            // 
            // pret_piesa_modificat
            // 
            this.pret_piesa_modificat.Location = new System.Drawing.Point(12, 253);
            this.pret_piesa_modificat.Name = "pret_piesa_modificat";
            this.pret_piesa_modificat.Size = new System.Drawing.Size(178, 23);
            this.pret_piesa_modificat.TabIndex = 10;
            // 
            // anuleaza_button
            // 
            this.anuleaza_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.anuleaza_button.Location = new System.Drawing.Point(0, 310);
            this.anuleaza_button.Name = "anuleaza_button";
            this.anuleaza_button.Size = new System.Drawing.Size(243, 28);
            this.anuleaza_button.TabIndex = 11;
            this.anuleaza_button.Text = "Anuleaza";
            this.anuleaza_button.UseVisualStyleBackColor = true;
            this.anuleaza_button.Click += new System.EventHandler(this.anuleaza_button_Click);
            // 
            // modificare_angajat_form
            // 
            this.AcceptButton = this.modifica_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuleaza_button;
            this.ClientSize = new System.Drawing.Size(243, 378);
            this.Controls.Add(this.anuleaza_button);
            this.Controls.Add(this.pret_piesa_modificat);
            this.Controls.Add(this.nume_piesa_modificat);
            this.Controls.Add(this.an_fabricatie_modificat);
            this.Controls.Add(this.nume_model_modificat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modifica_button);
            this.Controls.Add(this.nume_marca_modificat);
            this.Controls.Add(this.label1);
            this.Name = "modificare_angajat_form";
            this.Text = "Modificare Piesa";
            this.Load += new System.EventHandler(this.modificare_angajat_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nume_marca_modificat;
        private System.Windows.Forms.Button modifica_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nume_model_modificat;
        private System.Windows.Forms.TextBox an_fabricatie_modificat;
        private System.Windows.Forms.TextBox nume_piesa_modificat;
        private System.Windows.Forms.TextBox pret_piesa_modificat;
        private System.Windows.Forms.Button anuleaza_button;
    }
}