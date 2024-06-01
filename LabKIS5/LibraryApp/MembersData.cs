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
    public partial class MembersData : Form
    {
        public string name = "";
        public int age = 0;
        public string phone = "";
        public string address = "";
        public string year = "";

        public MembersData()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var mlist = db.Members.ToList();
                foreach (var m in mlist)
                {
                    dataGridView1.Rows.Add(m.Id, m.Name.Trim(), m.Age, m.Phone.Trim(), m.Address.Trim(), m.Join_Date.Trim());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            age = int.Parse(textBoxAge.Text);
            phone = textBoxPhone.Text;
            address = textBoxAddress.Text;
            year = textBoxJoin.Text;
            if (name == "" || age == null || phone == "" || address == "" || year == null)
            {
                MessageBox.Show("Необходимо заполнить все поля!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    var m = new Members()
                    {
                        Name = name,
                        Age = age,
                        Phone = phone,
                        Address = address,
                        Join_Date = year
                    };
                    db.Members.Add(m);
                    db.SaveChanges();
                }
                textBoxName.Clear(); textBoxAge.Clear();
                textBoxPhone.Clear(); textBoxAddress.Clear();
                textBoxJoin.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var mlist = db.Members.ToList();
                    foreach (var m in mlist)
                    {
                        dataGridView1.Rows.Add(m.Id, m.Name.Trim(), m.Age, m.Phone.Trim(), m.Address.Trim(), m.Join_Date.Trim());
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
                var members = db1.Members.Where(index => index.Id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                members.Name = dataGridView1[1, i].Value.ToString();
                members.Age = int.Parse(dataGridView1[2, i].Value.ToString());
                members.Phone = dataGridView1[3, i].Value.ToString();
                members.Address = dataGridView1[3, i].Value.ToString();
                members.Join_Date = dataGridView1[4, i].Value.ToString();
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var mlist = db.Members.ToList();
                foreach (var m in mlist)
                {
                    dataGridView1.Rows.Add(m.Id, m.Name.Trim(), m.Age, m.Phone.Trim(), m.Address.Trim(), m.Join_Date.Trim());
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
                var m_id = new Members()
                {
                    Id = id
                };
                db1.Members.Attach(m_id);
                db1.Members.Remove(m_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var mlist = db.Members.ToList();
                    foreach (var m in mlist)
                    {
                        dataGridView1.Rows.Add(m.Id, m.Name.Trim(), m.Age, m.Phone.Trim(), m.Address.Trim(), m.Join_Date.Trim());
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
