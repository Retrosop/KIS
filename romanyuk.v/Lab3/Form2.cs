using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            int f_val, e_val, w_val, t_val;
            f_val = e.X; f_value.Text = f_val.ToString();
            w_val = e.Y; w_value.Text = w_val.ToString();
            e_val = Convert.ToInt32(e_value.Text);
            t_val = Convert.ToInt32(t_value.Text);
            if (t_val == 0)
            {
                Text = "ERROR";
            }
            else
            {
                Text = (Math.Log10(f_val) - e_val + Math.Abs(Math.Sin(w_val/t_val) + Math.Sqrt(Math.Abs(e_val)))).ToString();
            }
        }
    }
}
