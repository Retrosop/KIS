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
    public partial class ProductsForm : Form
    {
        public string prod_name = "";
        public string prod_description = "";
        public int prod_price = 0;
        public int prod_quantity = 0;
        public int prod_category_ = 1;
        public int prod_supplier_ = 1;
        public ProductsForm()
        {
            InitializeComponent();
            using (var db = new DataContext())
            {
                var clist = db.Categories.ToList();
                foreach (var c in clist)
                {
                    comboBoxCategories.Items.Add(c.id + ": " + c.name);
                }
            }
            using (var db = new DataContext())
            {
                var slist = db.Suppliers.ToList();
                foreach (var s in slist)
                {
                    comboBoxProdSup.Items.Add(s.id + ": " + s.name);
                }
            }
            using (var db = new DataContext())
            {
                var plist = db.Products.Include(c => c.categories_).Include(s => s.suppliers_).ToList();
                foreach (var p in plist)
                {
                    dataGridView1.Rows.Add(p.id, p.name.Trim(), p.description.Trim(), p.price, p.quantity, p.categories_.id, p.suppliers_.id);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categoriesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            prod_name = textBoxProdName.Text;
            prod_description = textBoxProdDesc.Text;
            prod_price = int.Parse(textBoxProdPrice.Text);
            prod_quantity = int.Parse(textBoxProdQuantity.Text);
            prod_category_ = int.Parse(comboBoxCategories.Text.Substring(0, comboBoxCategories.Text.IndexOf(":")).Trim());
            prod_supplier_ = int.Parse(comboBoxProdSup.Text.Substring(0, comboBoxCategories.Text.IndexOf(":")).Trim());
            if (prod_name == "" || prod_description == "" || prod_price == null || prod_quantity == null)
            {
                MessageBox.Show("Необходимо заполнить все поля перед добавлением новой записи!");
            }
            else
            {
                using (var db = new DataContext())
                {
                    Categories c = db.Categories
                        .Where(c => c.id == prod_category_)
                        .FirstOrDefault();
                    Suppliers s = db.Suppliers
                        .Where(s => s.id == prod_supplier_)
                        .FirstOrDefault();
                    Console.WriteLine(c.id);
                    var p = new Products() 
                    {
                        name = prod_name,
                        description = prod_description,
                        price = prod_price,
                        quantity = prod_quantity,
                        categories_ = c,
                        suppliers_ = s
                    };
                    db.Products.Add(p);
                    db.SaveChanges();
                }
                textBoxProdName.Clear();
                textBoxProdDesc.Clear();
                textBoxProdPrice.Clear();
                textBoxProdQuantity.Clear();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var plist = db.Products.Include(c => c.categories_).Include(s => s.suppliers_).ToList();
                    foreach (var p in plist)
                    {
                        dataGridView1.Rows.Add(p.id, p.name.Trim(), p.description.Trim(), p.price, p.quantity, p.categories_.id, p.suppliers_.id);
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
                var products = db1.Products.Where(index => index.id == int.Parse(dataGridView1[0, i].Value.ToString())).FirstOrDefault();
                products.name = dataGridView1[1, i].Value.ToString();
                products.description = dataGridView1[2, i].Value.ToString();
                products.price = int.Parse(dataGridView1[3, i].Value.ToString());
                products.quantity = int.Parse(dataGridView1[4, i].Value.ToString());
            }
            db1.SaveChanges();
            dataGridView1.Rows.Clear();
            using (var db = new DataContext())
            {
                var plist = db.Products.Include(c => c.categories_).Include(s => s.suppliers_).ToList();
                foreach (var p in plist)
                {
                    dataGridView1.Rows.Add(p.id, p.name.Trim(), p.description.Trim(), p.price, p.quantity, p.categories_.id, p.suppliers_.id);
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
                var p_id = new Products()
                {
                    id = id
                };
                db1.Products.Attach(p_id);
                db1.Products.Remove(p_id);
                db1.SaveChanges();
                dataGridView1.Rows.Clear();
                using (var db = new DataContext())
                {
                    var plist = db.Products.Include(c => c.categories_).Include(s => s.suppliers_).ToList();
                    foreach (var p in plist)
                    {
                        dataGridView1.Rows.Add(p.id, p.name.Trim(), p.description.Trim(), p.price, p.quantity, p.categories_.id, p.suppliers_.id);
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
