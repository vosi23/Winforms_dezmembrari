
namespace proiect_v1
{
    partial class afisare_registru
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
            this.Lista_Registri = new System.Windows.Forms.ListBox();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lista_Registri
            // 
            this.Lista_Registri.FormattingEnabled = true;
            this.Lista_Registri.ItemHeight = 15;
            this.Lista_Registri.Location = new System.Drawing.Point(12, 32);
            this.Lista_Registri.Name = "Lista_Registri";
            this.Lista_Registri.Size = new System.Drawing.Size(689, 439);
            this.Lista_Registri.TabIndex = 0;
            // 
            // back_button
            // 
            this.back_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.back_button.Location = new System.Drawing.Point(0, 518);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(713, 35);
            this.back_button.TabIndex = 1;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // afisare_registru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.back_button;
            this.ClientSize = new System.Drawing.Size(713, 553);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Lista_Registri);
            this.Name = "afisare_registru";
            this.Text = "Afisare Registru";
            this.Load += new System.EventHandler(this.afisare_registru_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Lista_Registri;
        private System.Windows.Forms.Button back_button;
    }
}