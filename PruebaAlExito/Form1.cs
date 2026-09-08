using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaAlExito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tBX.Text);
            int y = Convert.ToInt32(tBY.Text);
            but.Text = (x + y).ToString();
        }
    }
}
