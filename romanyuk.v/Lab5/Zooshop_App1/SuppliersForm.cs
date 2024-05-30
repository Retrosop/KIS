using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zooshop_App1
{
    public partial class SuppliersForm : Form
    {
        public string sup_name = "";
        public string sup_email = "";
        public string sup_phone = "";
        public string sup_address = "";
        public SuppliersForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var slist = db.Suppliers.ToList();
                foreach (var s in slist)
                {
                    dataGridView1.Rows.Add(s.id, s.name.Trim(), s.email.Trim(), s.phone.Trim(), s.address.Trim());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sup_name = textBoxSupName.Text;
            sup_email = textBoxSupEmail.Text;
            sup_phone = textBoxSupPhone.Text;
            sup_address = textBoxSupAddress.Text;
            if (sup_name == "" || sup_email == "" || sup_phone == "" || sup_address == "")
            {
                MessageBox.Show("Необходимо заполнить все поля перед добавлением новой записи!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    var s = new Suppliers()
                    {
                        name = sup_name,
                        email = sup_email,
                        phone = sup_phone,
                        address = sup_address
                    };
                    db.Suppliers.Add(s);
                    db.SaveChanges();
                }
                textBoxSupName.Clear();
                textBoxSupEmail.Clear();
                textBoxSupPhone.Clear();
                textBoxSupAddress.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var slist = db.Suppliers.ToList();
                    foreach (var s in slist)
                    {
                        dataGridView1.Rows.Add(s.id, s.name.Trim(), s.email.Trim(), s.phone.Trim(), s.address.Trim());
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
                var suppliers = db1.Suppliers.Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                suppliers.name = dataGridView1[1, i].Value.ToString();
                suppliers.email = dataGridView1[2, i].Value.ToString();
                suppliers.phone = dataGridView1[3, i].Value.ToString();
                suppliers.address = dataGridView1[4, i].Value.ToString();
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var slist = db.Suppliers.ToList();
                foreach (var s in slist)
                {
                    dataGridView1.Rows.Add(s.id, s.name.Trim(), s.email.Trim(), s.phone.Trim(), s.address.Trim());
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
                var s_id = new Suppliers()
                {
                    id = id
                };
                db1.Suppliers.Attach(s_id);
                db1.Suppliers.Remove(s_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var slist = db.Suppliers.ToList();
                    foreach (var s in slist)
                    {
                        dataGridView1.Rows.Add(s.id, s.name.Trim(), s.email.Trim(), s.phone.Trim(), s.address.Trim());
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
