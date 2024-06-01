namespace LibraryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new GenresData();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new BooksData();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new MembersData();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm = new RecordsData();
            frm.Show();
        }
    }
}