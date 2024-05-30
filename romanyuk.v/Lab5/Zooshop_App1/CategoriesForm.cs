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

namespace Zooshop_App1
{
    public partial class CategoriesForm : Form
    {
        public string name = "";
        public string description = "";

        public CategoriesForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var clist = db.Categories.ToList();
                foreach(var c in clist)
                {
                    dataGridView1.Rows.Add(c.id, c.name.Trim(), c.description.Trim());
                }
            }
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            description = textBoxDesc.Text;
            if (name == "" || description == "")
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    var c = new Categories()
                    {
                        name = name,
                        description = description
                    };
                    db.Categories.Add(c);
                    db.SaveChanges();
                }
                textBoxName.Clear();
                textBoxDesc.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var clist = db.Categories.ToList();
                    foreach (var c in clist)
                    {
                        dataGridView1.Rows.Add(c.id, c.name.Trim(), c.description.Trim());
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView1.RowCount;
            var db1 = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var categories = db1.Categories.Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                categories.name = dataGridView1[1, i].Value.ToString();
                categories.description = dataGridView1[2, i].Value.ToString();
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var clist = db.Categories.ToList();
                foreach (var c in clist)
                {
                    dataGridView1.Rows.Add(c.id, c.name.Trim(), c.description.Trim());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var db1 = new DataContext();
                var c_id = new Categories()
                {
                    id = id
                };
                db1.Categories.Attach(c_id);
                db1.Categories.Remove(c_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var clist = db.Categories.ToList();
                    foreach (var c in clist)
                    {
                        dataGridView1.Rows.Add(c.id, c.name.Trim(), c.description.Trim());
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите одну или более записей для удаления!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
