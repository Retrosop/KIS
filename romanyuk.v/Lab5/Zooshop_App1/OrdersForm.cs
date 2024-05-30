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
using System.Windows.Forms.VisualStyles;

namespace Zooshop_App1
{
    public partial class OrdersForm : Form
    {
        public string order_date = "";
        public int order_total = 0;
        public int order_status = 0;
        public int order_customer_ = 1;
        public int order_item_quantity = 0;
        public int order_item_total = 0;
        public int order_item_product_ = 1;
        public int order_item_order_ = 1;

        public OrdersForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var clist = db.Customers.ToList();
                foreach (var c in clist)
                {
                    comboBoxCustomer.Items.Add(c.id + ": " + c.first_name);
                }
            }
            using (var db = new DataContext())
            {
                var olist = db.Orders.Include(c => c.customer_).ToList();
                foreach(var o in olist)
                {
                    dataGridView2.Rows.Add(o.id,o.order_date,o.total,o.status,o.customer_.id);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order_date = textBoxDate.Text;
            order_total = int.Parse(textBoxTotal.Text);
            order_status = int.Parse(textBoxStatus.Text);
            order_customer_ = int.Parse(comboBoxCustomer.Text.Substring(0, comboBoxCustomer.Text.IndexOf(":")).Trim());
            if (order_date == "" || order_total == null || order_status == null)
            {
                MessageBox.Show("Необходимо заполнить все поля перед добавлением новой записи!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    Customers c = db.Customers
                        .Where(c => c.id == order_customer_)
                        .FirstOrDefault();
                    var o = new Orders()
                    {
                        order_date = order_date,
                        total = order_total,
                        status = order_status,
                        customer_ = c
                    };
                    db.Orders.Add(o);
                    db.SaveChanges();
                }
                textBoxDate.Clear();
                textBoxTotal.Clear();
                textBoxStatus.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var olist = db.Orders.Include(c => c.customer_).ToList();
                    foreach (var o in olist)
                    {
                        dataGridView2.Rows.Add(o.id, o.order_date, o.total, o.status, o.customer_.id);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = dataGridView2.RowCount;
            var db1 = new DataContext();
            for (int i = 0; i < l - 1; i++)
            {
                var orders = db1.Orders.Where(index => index.id == int.Parse(dataGridView2[0, i].Value.ToString())).FirstOrDefault();
                orders.order_date = dataGridView2[1, i].Value.ToString();
                orders.total = int.Parse(dataGridView2[2, i].Value.ToString());
                orders.status = int.Parse(dataGridView2[3, i].Value.ToString());
            }
            db1.SaveChanges();
            dataGridView2.Rows.Clear();
            using (var db = new DataContext())
            {
                var olist = db.Orders.Include(c => c.customer_).ToList();
                foreach (var o in olist)
                {
                    dataGridView2.Rows.Add(o.id, o.order_date, o.total, o.status, o.customer_.id);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int index = dataGridView2.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView2[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                var db1 = new DataContext();
                var o_id = new Orders()
                {
                    id = id
                };
                db1.Orders.Attach(o_id);
                db1.Orders.Remove(o_id);
                db1.SaveChanges();
                dataGridView2.Rows.Clear();
                using (var db = new DataContext())
                {
                    var olist = db.Orders.Include(c => c.customer_).ToList();
                    foreach (var o in olist)
                    {
                        dataGridView2.Rows.Add(o.id, o.order_date, o.total, o.status, o.customer_.id);
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
