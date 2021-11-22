
namespace proiect_v1
{
    partial class adaugare_piesa_form
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
            this.nume_marca_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nume_model_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.an_fabricatie_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nume_piesa_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pret_piesa_text = new System.Windows.Forms.TextBox();
            this.adauga_button = new System.Windows.Forms.Button();
            this.anuleaza_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nume_marca_text
            // 
            this.nume_marca_text.Location = new System.Drawing.Point(25, 38);
            this.nume_marca_text.Name = "nume_marca_text";
            this.nume_marca_text.Size = new System.Drawing.Size(147, 23);
            this.nume_marca_text.TabIndex = 2;
            this.nume_marca_text.TextChanged += new System.EventHandler(this.nume_marca_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduceti numele marcii:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introduceti numele modelului:";
            // 
            // nume_model_text
            // 
            this.nume_model_text.Location = new System.Drawing.Point(25, 101);
            this.nume_model_text.Name = "nume_model_text";
            this.nume_model_text.Size = new System.Drawing.Size(168, 23);
            this.nume_model_text.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Introduceti anul fabricatiei:";
            // 
            // an_fabricatie_text
            // 
            this.an_fabricatie_text.Location = new System.Drawing.Point(25, 166);
            this.an_fabricatie_text.Name = "an_fabricatie_text";
            this.an_fabricatie_text.Size = new System.Drawing.Size(147, 23);
            this.an_fabricatie_text.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Introduceti numele piesei:";
            // 
            // nume_piesa_text
            // 
            this.nume_piesa_text.Location = new System.Drawing.Point(25, 229);
            this.nume_piesa_text.Name = "nume_piesa_text";
            this.nume_piesa_text.Size = new System.Drawing.Size(147, 23);
            this.nume_piesa_text.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Introduceti pretul piesei:";
            // 
            // pret_piesa_text
            // 
            this.pret_piesa_text.Location = new System.Drawing.Point(25, 293);
            this.pret_piesa_text.Name = "pret_piesa_text";
            this.pret_piesa_text.Size = new System.Drawing.Size(135, 23);
            this.pret_piesa_text.TabIndex = 11;
            // 
            // adauga_button
            // 
            this.adauga_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adauga_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adauga_button.Location = new System.Drawing.Point(0, 373);
            this.adauga_button.Name = "adauga_button";
            this.adauga_button.Size = new System.Drawing.Size(376, 57);
            this.adauga_button.TabIndex = 12;
            this.adauga_button.Text = "Adauga !";
            this.adauga_button.UseVisualStyleBackColor = true;
            this.adauga_button.Click += new System.EventHandler(this.adauga_button_Click);
            // 
            // anuleaza_button
            // 
            this.anuleaza_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.anuleaza_button.Location = new System.Drawing.Point(0, 337);
            this.anuleaza_button.Name = "anuleaza_button";
            this.anuleaza_button.Size = new System.Drawing.Size(376, 36);
            this.anuleaza_button.TabIndex = 13;
            this.anuleaza_button.Text = "Anuleaza";
            this.anuleaza_button.UseVisualStyleBackColor = true;
            // 
            // adaugare_piesa_form
            // 
            this.AcceptButton = this.adauga_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuleaza_button;
            this.ClientSize = new System.Drawing.Size(376, 430);
            this.Controls.Add(this.anuleaza_button);
            this.Controls.Add(this.adauga_button);
            this.Controls.Add(this.pret_piesa_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nume_piesa_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.an_fabricatie_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nume_model_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nume_marca_text);
            this.Name = "adaugare_piesa_form";
            this.Text = "adaugare_piesa_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nume_marca_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nume_model_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox an_fabricatie_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nume_piesa_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pret_piesa_text;
        private System.Windows.Forms.Button adauga_button;
        private System.Windows.Forms.Button anuleaza_button;
    }
}