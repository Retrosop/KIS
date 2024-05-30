namespace Zooshop_App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new CategoriesForm();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new ClientsForm();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm = new SuppliersForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new ProductsForm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new OrdersForm();
            frm.Show();
        }
    }
}