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
    public partial class RecordsData : Form
    {
        public string rec_date = "";
        public string due_date = "";
        public string ret_date = "";
        public int member_id = 0;
        public int book_id = 0;

        public RecordsData()
        {
            InitializeComponent();
            using(var db = new DataContext())
            {
                var rlist = db.Records.Include(m => m.Members_).Include(b => b.Books_).ToList();
                foreach (var r in rlist)
                {
                    dataGridView1.Rows.Add(r.Id, r.Record_Date, r.Due_Date, r.Return_Date, r.Members_.Id, r.Books_.Id);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rec_date = textBoxRec.Text;
            due_date = textBoxDue.Text;
            ret_date = textBoxRet.Text;
            member_id = int.Parse(textBoxMem.Text);
            book_id = int.Parse(textBoxBoo.Text);
            if (rec_date == "" || due_date == "" || ret_date == "" || member_id == null || book_id == null)
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    Members m = db.Members
                        .Where(m => m.Id == member_id)
                        .FirstOrDefault();
                    Books b = db.Books
                        .Where(b => b.Id == book_id)
                        .FirstOrDefault();
                    var r = new Records()
                    {
                        Record_Date = rec_date,
                        Due_Date = due_date,
                        Return_Date = ret_date,
                        Members_ = m,
                        Books_ = b
                    };
                    db.Records.Add(r);
                    db.SaveChanges();
                }
                textBoxRec.Clear(); textBoxDue.Clear();
                textBoxRet.Clear(); textBoxBoo.Clear();
                textBoxMem.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var rlist = db.Records.Include(m => m.Members_).Include(b => b.Books_).ToList();
                    foreach (var r in rlist)
                    {
                        dataGridView1.Rows.Add(r.Id, r.Record_Date, r.Due_Date, r.Return_Date, r.Members_.Id, r.Books_.Id);
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
                var records = db1.Records.Where(index => index.Id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                records.Record_Date = dataGridView1[1, i].Value.ToString();
                records.Due_Date = dataGridView1[2, i].Value.ToString();
                records.Return_Date = dataGridView1[3, i].Value.ToString();
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var rlist = db.Records.Include(m => m.Members_).Include(b => b.Books_).ToList();
                foreach (var r in rlist)
                {
                    dataGridView1.Rows.Add(r.Id, r.Record_Date, r.Due_Date, r.Return_Date, r.Members_.Id, r.Books_.Id);
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
                var r_id = new Records()
                {
                    Id = id
                };
                db1.Records.Attach(r_id);
                db1.Records.Remove(r_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var rlist = db.Records.Include(m => m.Members_).Include(b => b.Books_).ToList();
                    foreach (var r in rlist)
                    {
                        dataGridView1.Rows.Add(r.Id, r.Record_Date, r.Due_Date, r.Return_Date, r.Members_.Id, r.Books_.Id);
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
