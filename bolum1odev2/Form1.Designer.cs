namespace bolum1odev2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKontrolet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Mouse",
            "Yazıcı",
            "Klavye",
            "Hoparlör",
            "Kamera",
            "Tarayıcı",
            "Projeksiyon"});
            this.listBox1.Location = new System.Drawing.Point(34, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(133, 173);
            this.listBox1.TabIndex = 0;
            // 
            // btnKontrolet
            // 
            this.btnKontrolet.Location = new System.Drawing.Point(34, 221);
            this.btnKontrolet.Name = "btnKontrolet";
            this.btnKontrolet.Size = new System.Drawing.Size(133, 33);
            this.btnKontrolet.TabIndex = 1;
            this.btnKontrolet.Text = "Kontrol Et";
            this.btnKontrolet.UseVisualStyleBackColor = true;
            this.btnKontrolet.Click += new System.EventHandler(this.btnKontrolet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKontrolet);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKontrolet;
    }
}

