using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Zooshop_App1
{
    public partial class ClientsForm : Form
    {
        public string clients_first_name = "";
        public string clients_last_name = "";
        public string clients_email = "";
        public string clients_phone = "";
        public string clients_address = "";
        public ClientsForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var clist = db.Customers.ToList();
                foreach (var c in clist)
                {
                    dataGridView1.Rows.Add(c.id, c.first_name.Trim(), c.last_name.Trim(), c.email.Trim(), c.phone.Trim(), c.address.Trim());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clients_first_name = textBoxFirstName.Text;
            clients_last_name = textBoxLastName.Text;
            clients_email = textBoxEmail.Text;
            clients_phone = textBoxPhone.Text;
            clients_address = textBoxAddress.Text;
            if (clients_first_name == "" || clients_last_name == "" || clients_email == "" || clients_phone == "" || clients_address == "")
            {
                MessageBox.Show("Необходимо заполнить все поля перед добавлением новой записи!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    var c = new Customers()
                    {
                        first_name = clients_first_name,
                        last_name = clients_last_name,
                        email = clients_email,
                        phone = clients_phone,
                        address = clients_address
                    };
                    db.Customers.Add(c);
                    db.SaveChanges();
                }
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                textBoxEmail.Clear();
                textBoxPhone.Clear();
                textBoxAddress.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var clist = db.Customers.ToList();
                    foreach (var c in clist)
                    {
                        dataGridView1.Rows.Add(c.id, c.first_name.Trim(), c.last_name.Trim(), c.email.Trim(), c.phone.Trim(), c.address.Trim());
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
                var customers = db1.Customers.Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                customers.first_name = dataGridView1[1, i].Value.ToString();
                customers.last_name = dataGridView1[2, i].Value.ToString();
                customers.email = dataGridView1[3, i].Value.ToString();
                customers.phone = dataGridView1[4, i].Value.ToString();
                customers.address = dataGridView1[5, i].Value.ToString();
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var clist = db.Customers.ToList();
                foreach (var c in clist)
                {
                    dataGridView1.Rows.Add(c.id, c.first_name.Trim(), c.last_name.Trim(), c.email.Trim(), c.phone.Trim(), c.address.Trim());
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
                var c_id = new Customers()
                {
                    id = id
                };
                db1.Customers.Attach(c_id);
                db1.Customers.Remove(c_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var clist = db.Customers.ToList();
                    foreach (var c in clist)
                    {
                        dataGridView1.Rows.Add(c.id, c.first_name.Trim(), c.last_name.Trim(), c.email.Trim(), c.phone.Trim(), c.address.Trim());
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
