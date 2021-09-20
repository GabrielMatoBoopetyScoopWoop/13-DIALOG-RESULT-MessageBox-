namespace GabrielMatosevicDialogResult
{
    partial class Form1
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
            this.Butun = new System.Windows.Forms.Button();
            this.TextKutija = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Butun
            // 
            this.Butun.Location = new System.Drawing.Point(346, 197);
            this.Butun.Name = "Butun";
            this.Butun.Size = new System.Drawing.Size(75, 23);
            this.Butun.TabIndex = 0;
            this.Butun.Text = "Click here";
            this.Butun.UseVisualStyleBackColor = true;
            this.Butun.Click += new System.EventHandler(this.Butun_Click);
            // 
            // TextKutija
            // 
            this.TextKutija.Location = new System.Drawing.Point(188, 226);
            this.TextKutija.Multiline = true;
            this.TextKutija.Name = "TextKutija";
            this.TextKutija.Size = new System.Drawing.Size(404, 20);
            this.TextKutija.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextKutija);
            this.Controls.Add(this.Butun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Butun;
        private System.Windows.Forms.TextBox TextKutija;
    }
}

