using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static ConsoleAppAccess.DBModel;

namespace AppSklad
{
	/// <summary>
	/// Логика взаимодействия для ReceiptProductForm.xaml
	/// </summary>
	public partial class ReceiptProductForm : Window
	{
		int idProduct;
		int idSupplier;
		public ReceiptProductForm()
		{
			InitializeComponent();
			
			using (DataContext db = new DataContext())
			{
				var productList = db.Product.ToList();
				foreach (Product xproduct in productList)
				{
					comboboxProduct.Items.Add(new ComboboxItem { Text= xproduct.Name, Value = xproduct.Id });
				}
				var supplierList = db.Supplier.ToList();
				foreach (Supplier xsupplier in supplierList)
				{
					comboboxSupplier.Items.Add(new ComboboxItem { Text = xsupplier.Name, Value = xsupplier.Id });
				}
			}
		}

		private void comboboxProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			idProduct = (comboboxProduct.SelectedItem as ComboboxItem).Value;
		}

		private void comboboxSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			idSupplier = (comboboxSupplier.SelectedItem as ComboboxItem).Value;
		}
	}
}
