using Microsoft.EntityFrameworkCore;
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
    public partial class BooksData : Form
    {
        public string book_title = "";
        public string book_author = "";
        public int book_publish = 0;
        public int book_copies = 0;
        public int book_genre = 0;

        public BooksData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var blist = db.Books.Include(g => g.Genres_).ToList();
                foreach (var b in blist)
                {
                    dataGridView1.Rows.Add(b.Id, b.Title.Trim(), b.Author.Trim(), b.Publish_Year, b.Copies, b.Genres_.Id);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            book_title = textBoxName.Text;
            book_author = textBoxAuthor.Text;
            book_publish = int.Parse(textBoxPublish.Text);
            book_copies = int.Parse(textBoxQuantity.Text);
            book_genre = int.Parse(textBoxGenre.Text);
            if (book_title == "" || book_author == "" || book_publish == null || book_copies == null || book_genre == null)
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    Genres g = db.Genres
                        .Where(g => g.Id == book_genre)
                        .FirstOrDefault();
                    var b = new Books()
                    {
                        Title = book_title,
                        Author = book_author,
                        Publish_Year = book_publish,
                        Copies = book_copies,
                        Genres_ = g
                    };
                    db.Books.Add(b);
                    db.SaveChanges();
                }
                textBoxName.Clear(); textBoxAuthor.Clear();
                textBoxPublish.Clear(); textBoxQuantity.Clear();
                textBoxGenre.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var blist = db.Books.Include(g => g.Genres_).ToList();
                    foreach (var b in blist)
                    {
                        dataGridView1.Rows.Add(b.Id, b.Title.Trim(), b.Author.Trim(), b.Publish_Year, b.Copies, b.Genres_.Id);
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
                var books = db1.Books.Where(index => index.Id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                books.Title = dataGridView1[1, i].Value.ToString();
                books.Author = dataGridView1[2, i].Value.ToString();
                books.Publish_Year = int.Parse(dataGridView1[3, i].Value.ToString());
                books.Copies = int.Parse(dataGridView1[4, i].Value.ToString());
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var blist = db.Books.Include(g => g.Genres_).ToList();
                foreach (var b in blist)
                {
                    dataGridView1.Rows.Add(b.Id, b.Title.Trim(), b.Author.Trim(), b.Publish_Year, b.Copies, b.Genres_.Id);
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
                var b_id = new Books()
                {
                    Id = id
                };
                db1.Books.Attach(b_id);
                db1.Books.Remove(b_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var blist = db.Books.Include(g => g.Genres_).ToList();
                    foreach (var b in blist)
                    {
                        dataGridView1.Rows.Add(b.Id, b.Title.Trim(), b.Author.Trim(), b.Publish_Year, b.Copies, b.Genres_.Id);
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
