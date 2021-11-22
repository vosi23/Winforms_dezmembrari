
namespace proiect_v1
{
    partial class adaugare_client
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
            this.nume_text = new System.Windows.Forms.TextBox();
            this.prenume_text = new System.Windows.Forms.TextBox();
            this.numar_text = new System.Windows.Forms.TextBox();
            this.adauga_button = new System.Windows.Forms.Button();
            this.anuleaza_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nume_text
            // 
            this.nume_text.Location = new System.Drawing.Point(26, 42);
            this.nume_text.Name = "nume_text";
            this.nume_text.Size = new System.Drawing.Size(100, 23);
            this.nume_text.TabIndex = 0;
            // 
            // prenume_text
            // 
            this.prenume_text.Location = new System.Drawing.Point(26, 116);
            this.prenume_text.Name = "prenume_text";
            this.prenume_text.Size = new System.Drawing.Size(100, 23);
            this.prenume_text.TabIndex = 1;
            // 
            // numar_text
            // 
            this.numar_text.Location = new System.Drawing.Point(26, 199);
            this.numar_text.Name = "numar_text";
            this.numar_text.Size = new System.Drawing.Size(100, 23);
            this.numar_text.TabIndex = 2;
            // 
            // adauga_button
            // 
            this.adauga_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adauga_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adauga_button.Location = new System.Drawing.Point(0, 318);
            this.adauga_button.Name = "adauga_button";
            this.adauga_button.Size = new System.Drawing.Size(275, 39);
            this.adauga_button.TabIndex = 3;
            this.adauga_button.Text = "Adauga";
            this.adauga_button.UseVisualStyleBackColor = true;
            this.adauga_button.Click += new System.EventHandler(this.adauga_button_Click);
            // 
            // anuleaza_button
            // 
            this.anuleaza_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.anuleaza_button.Location = new System.Drawing.Point(0, 288);
            this.anuleaza_button.Name = "anuleaza_button";
            this.anuleaza_button.Size = new System.Drawing.Size(275, 30);
            this.anuleaza_button.TabIndex = 4;
            this.anuleaza_button.Text = "Anuleaza";
            this.anuleaza_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Introduceti numele clientului:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Introduceti prenumele clientului:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Introduceti numarul clientului:";
            // 
            // adaugare_client
            // 
            this.AcceptButton = this.adauga_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuleaza_button;
            this.ClientSize = new System.Drawing.Size(275, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anuleaza_button);
            this.Controls.Add(this.adauga_button);
            this.Controls.Add(this.numar_text);
            this.Controls.Add(this.prenume_text);
            this.Controls.Add(this.nume_text);
            this.Name = "adaugare_client";
            this.Text = "Adaugare Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nume_text;
        private System.Windows.Forms.TextBox prenume_text;
        private System.Windows.Forms.TextBox numar_text;
        private System.Windows.Forms.Button adauga_button;
        private System.Windows.Forms.Button anuleaza_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}