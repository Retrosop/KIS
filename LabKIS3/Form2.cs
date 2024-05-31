using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabKIS3
{
    public partial class Form2 : Form
    {
        int a, b, w, x, y, z;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                w = e.X; textBoxW.Text = w.ToString();
                y = e.Y; textBoxY.Text = y.ToString();
                a = int.Parse(textBoxA.Text);
                b = int.Parse(textBoxB.Text);
                x = int.Parse(textBoxX.Text);
                Text = (Math.Sqrt(Math.Abs((a * x) / Math.Pow(w, a))) + Math.Sqrt(Math.Abs(b)) - Math.Abs(x + Math.Cos(y))).ToString();
            }
            catch
            {
                Text = "ERROR";
            }
        }
    }
}
