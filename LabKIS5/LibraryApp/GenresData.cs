using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class GenresData : Form
    {
        public string genre_name = "";
        public string genre_desc = "";

        public GenresData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var glist = db.Genres.ToList();
                foreach (var g in glist)
                {
                    dataGridView1.Rows.Add(g.Id, g.Name.Trim(), g.Description.Trim());
                }
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            genre_name = textBoxName.Text;
            genre_desc = textBoxDescription.Text.ToString();
            if (genre_name == "" || genre_desc == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    var g = new Genres()
                    {
                        Name = genre_name,
                        Description = genre_desc
                    };
                    db.Genres.Add(g);
                    db.SaveChanges();
                }
                textBoxName.Clear();
                textBoxDescription.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var glist = db.Genres.ToList();
                    foreach (var g in glist)
                    {
                        dataGridView1.Rows.Add(g.Id, g.Name.Trim(), g.Description.Trim());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db1 = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var genres = db1.Genres.Where(index => index.Id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                genres.Name = dataGridView1[1, i].Value.ToString();
                genres.Description = dataGridView1[2, i].Value.ToString();
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var glist = db.Genres.ToList();
                foreach (var g in glist)
                {
                    dataGridView1.Rows.Add(g.Id, g.Name.Trim(), g.Description.Trim());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var db1 = new DataContext();
                var g_id = new Genres()
                {
                    Id = id
                };
                db1.Genres.Attach(g_id);
                db1.Genres.Remove(g_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var glist = db.Genres.ToList();
                    foreach (var g in glist)
                    {
                        dataGridView1.Rows.Add(g.Id, g.Name.Trim(), g.Description.Trim());
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите одну или более записей для удаления!");
            }
        }
    }
}
