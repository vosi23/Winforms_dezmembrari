
namespace proiect_v1
{
    partial class log_inForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.log_inbutton = new System.Windows.Forms.Button();
            this.Close_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_textbox
            // 
            this.login_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_textbox.Location = new System.Drawing.Point(0, 77);
            this.login_textbox.MaxLength = 5;
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.PasswordChar = '*';
            this.login_textbox.Size = new System.Drawing.Size(209, 23);
            this.login_textbox.TabIndex = 0;
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(49, 51);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(108, 23);
            this.text.TabIndex = 1;
            this.text.Text = "Introduceti pin-ul:";
            // 
            // log_inbutton
            // 
            this.log_inbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log_inbutton.Location = new System.Drawing.Point(0, 129);
            this.log_inbutton.Name = "log_inbutton";
            this.log_inbutton.Size = new System.Drawing.Size(209, 46);
            this.log_inbutton.TabIndex = 2;
            this.log_inbutton.Text = "Log In";
            this.log_inbutton.UseVisualStyleBackColor = true;
            this.log_inbutton.Click += new System.EventHandler(this.log_inbutton_Click);
            // 
            // Close_button
            // 
            this.Close_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Close_button.Location = new System.Drawing.Point(0, 106);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(209, 23);
            this.Close_button.TabIndex = 3;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // log_inForm
            // 
            this.AcceptButton = this.log_inbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Close_button;
            this.ClientSize = new System.Drawing.Size(209, 175);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.log_inbutton);
            this.Controls.Add(this.text);
            this.Controls.Add(this.login_textbox);
            this.MinimumSize = new System.Drawing.Size(225, 214);
            this.Name = "log_inForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login_textbox;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button log_inbutton;
        private System.Windows.Forms.Button Close_button;
    }
}

