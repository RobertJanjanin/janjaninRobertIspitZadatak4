namespace janjaninRobertIspitZadatak4
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
            this.btn_noviStudent = new System.Windows.Forms.Button();
            this.btn_obrisiStudenta = new System.Windows.Forms.Button();
            this.btn_obrisiSve = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_noviStudent
            // 
            this.btn_noviStudent.Location = new System.Drawing.Point(181, 80);
            this.btn_noviStudent.Name = "btn_noviStudent";
            this.btn_noviStudent.Size = new System.Drawing.Size(129, 23);
            this.btn_noviStudent.TabIndex = 0;
            this.btn_noviStudent.Text = "Dodaj novog studenta ";
            this.btn_noviStudent.UseVisualStyleBackColor = true;
            this.btn_noviStudent.Click += new System.EventHandler(this.Btn_noviStudent_Click);
            // 
            // btn_obrisiStudenta
            // 
            this.btn_obrisiStudenta.Location = new System.Drawing.Point(411, 188);
            this.btn_obrisiStudenta.Name = "btn_obrisiStudenta";
            this.btn_obrisiStudenta.Size = new System.Drawing.Size(92, 23);
            this.btn_obrisiStudenta.TabIndex = 1;
            this.btn_obrisiStudenta.Text = "Obrisi studenta";
            this.btn_obrisiStudenta.UseVisualStyleBackColor = true;
            // 
            // btn_obrisiSve
            // 
            this.btn_obrisiSve.Location = new System.Drawing.Point(181, 321);
            this.btn_obrisiSve.Name = "btn_obrisiSve";
            this.btn_obrisiSve.Size = new System.Drawing.Size(129, 23);
            this.btn_obrisiSve.TabIndex = 2;
            this.btn_obrisiSve.Text = "Obrisi sve studente";
            this.btn_obrisiSve.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(168, 127);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(211, 169);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_obrisiSve);
            this.Controls.Add(this.btn_obrisiStudenta);
            this.Controls.Add(this.btn_noviStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_noviStudent;
        private System.Windows.Forms.Button btn_obrisiStudenta;
        private System.Windows.Forms.Button btn_obrisiSve;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

