using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinozicSebastianMojProjekt2
{
    public partial class Form1 : Form
    {
        int broj = 0;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            broj++;
            txtPrikaz.Text = broj.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            broj--;
            txtPrikaz.Text = broj.ToString();
        }
    }
}
