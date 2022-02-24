
namespace UDP_klient
{
    partial class Form1
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
            this.tbxMeddelande = new System.Windows.Forms.TextBox();
            this.btnSkicka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxMeddelande
            // 
            this.tbxMeddelande.Location = new System.Drawing.Point(30, 112);
            this.tbxMeddelande.Multiline = true;
            this.tbxMeddelande.Name = "tbxMeddelande";
            this.tbxMeddelande.Size = new System.Drawing.Size(278, 107);
            this.tbxMeddelande.TabIndex = 0;
            // 
            // btnSkicka
            // 
            this.btnSkicka.Location = new System.Drawing.Point(30, 235);
            this.btnSkicka.Name = "btnSkicka";
            this.btnSkicka.Size = new System.Drawing.Size(278, 29);
            this.btnSkicka.TabIndex = 1;
            this.btnSkicka.Text = "Sänd";
            this.btnSkicka.UseVisualStyleBackColor = true;
            this.btnSkicka.Click += new System.EventHandler(this.btnSkicka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Utkorg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 294);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSkicka);
            this.Controls.Add(this.tbxMeddelande);
            this.Name = "Form1";
            this.Text = "UDP klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMeddelande;
        private System.Windows.Forms.Button btnSkicka;
        private System.Windows.Forms.Label label1;
    }
}

