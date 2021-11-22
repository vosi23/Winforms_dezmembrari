
namespace proiect_v1
{
    partial class adaugare_angajatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adaugare_angajatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nume_prenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pin = new System.Windows.Forms.TextBox();
            this.Admin_check = new System.Windows.Forms.RadioButton();
            this.normal_check = new System.Windows.Forms.RadioButton();
            this.adauga_button = new System.Windows.Forms.Button();
            this.anuleaza_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // nume_prenume
            // 
            resources.ApplyResources(this.nume_prenume, "nume_prenume");
            this.nume_prenume.Name = "nume_prenume";
            this.nume_prenume.TextChanged += new System.EventHandler(this.nume_prenume_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pin
            // 
            resources.ApplyResources(this.pin, "pin");
            this.pin.Name = "pin";
            this.pin.TextChanged += new System.EventHandler(this.pin_TextChanged);
            // 
            // Admin_check
            // 
            resources.ApplyResources(this.Admin_check, "Admin_check");
            this.Admin_check.Name = "Admin_check";
            this.Admin_check.TabStop = true;
            this.Admin_check.UseVisualStyleBackColor = true;
            this.Admin_check.CheckedChanged += new System.EventHandler(this.Admin_check_CheckedChanged);
            // 
            // normal_check
            // 
            resources.ApplyResources(this.normal_check, "normal_check");
            this.normal_check.Name = "normal_check";
            this.normal_check.TabStop = true;
            this.normal_check.UseVisualStyleBackColor = true;
            this.normal_check.CheckedChanged += new System.EventHandler(this.normal_check_CheckedChanged);
            // 
            // adauga_button
            // 
            this.adauga_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.adauga_button, "adauga_button");
            this.adauga_button.Name = "adauga_button";
            this.adauga_button.UseVisualStyleBackColor = true;
            this.adauga_button.Click += new System.EventHandler(this.adauga_button_Click);
            // 
            // anuleaza_button
            // 
            resources.ApplyResources(this.anuleaza_button, "anuleaza_button");
            this.anuleaza_button.Name = "anuleaza_button";
            this.anuleaza_button.UseVisualStyleBackColor = true;
            this.anuleaza_button.Click += new System.EventHandler(this.anuleaza_button_Click);
            // 
            // adaugare_angajatForm
            // 
            this.AcceptButton = this.adauga_button;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.anuleaza_button;
            this.Controls.Add(this.anuleaza_button);
            this.Controls.Add(this.adauga_button);
            this.Controls.Add(this.normal_check);
            this.Controls.Add(this.Admin_check);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nume_prenume);
            this.Controls.Add(this.label1);
            this.Name = "adaugare_angajatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nume_prenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.RadioButton Admin_check;
        private System.Windows.Forms.RadioButton normal_check;
        private System.Windows.Forms.Button adauga_button;
        private System.Windows.Forms.Button anuleaza_button;
    }
}