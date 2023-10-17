using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolet_Click(object sender, EventArgs e)
        {
            string secim;
            secim = listBox1.SelectedItem.ToString();
            if (secim == "mouse" || secim == "klavye" || secim == "kamera" || secim == "Tarayıcı")
            {
                MessageBox.Show("Bu parça,giriş birimidir.");
            }
            if (secim == "yazıcı" || secim == "hoparlör" || secim == "projeksiyon")
            {
                MessageBox.Show("Bu parça,çıkış birimidir.");
            }
        }
    }
}
