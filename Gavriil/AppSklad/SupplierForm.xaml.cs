using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
	/// Логика взаимодействия для SupplierForm.xaml
	/// </summary>
	public partial class SupplierForm : Window
	{
		int IdSelected = 0;
		ObservableCollection<Supplier> suppliers;
		public SupplierForm()
		{
			InitializeComponent();
			suppliers = new ObservableCollection<Supplier>();
			supplierList.SelectedIndex = IdSelected;

			using (DataContext db = new DataContext())
			{
				var glist = db.Supplier.ToList();
				foreach (Supplier xsupplier in glist)
				{
					suppliers.Add(xsupplier);
				}

				supplierList.ItemsSource = suppliers;
				if (IdSelected != 0)
				{
					var t = db.Supplier
						.Where(c => c.Id == (supplierList.SelectedItems[0] as Supplier).Id)
						.FirstOrDefault();
					InputName.Text = t.Name;
					InputCity.Text = t.City;
					InputStreet.Text = t.Street;
					InputPhone.Text = t.Phone;
				}
			}
		}

		private void addSupplier_Click(object sender, RoutedEventArgs e)
		{
			using (DataContext db = new DataContext())
			{
				Supplier supplier = new Supplier();
				supplier.Name = InputName.Text;
				supplier.City = InputCity.Text;
				supplier.Street = InputStreet.Text;
				supplier.Phone = InputPhone.Text;


				try
				{
					db.Supplier.Add(supplier);
					db.SaveChanges();
				}
				catch (FormatException)
				{
					//В случае появление ошибок ввожда
				}
				//==================
				suppliers.Clear();
				var supplierQuery = db.Supplier.ToList();
				foreach (Supplier xsupplier in supplierQuery)
				{
					suppliers.Add(xsupplier);
				}
				supplierList.ItemsSource = suppliers;
				//==================

			}
		}

		private void supplierList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			IdSelected = supplierList.SelectedIndex;

			using (var db = new DataContext())
			{
				if (supplierList.SelectedIndex == -1)
				{
					MessageBox.Show("Выделите запись");
				}
				else
				{
					Supplier t = db.Supplier
									.Where(c => c.Id == (supplierList.SelectedItems[0] as Supplier).Id).FirstOrDefault();
					InputName.Text = t.Name;
					InputCity.Text = t.City;
					InputStreet.Text = t.Street;
					InputPhone.Text = t.Phone;
				}
			}
		}

		private void deleteSuppliern_Click(object sender, RoutedEventArgs e)
		{
			if (supplierList.SelectedIndex == -1)
			{
				MessageBox.Show("Выделите запись");
			}
			else
			{
				MessageBoxResult dialogResult = MessageBox.Show("Вы действительно хотите удалить запись"
					, "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
				if (dialogResult == MessageBoxResult.Yes)
				{
					using (var db = new DataContext())
					{
						Supplier t = db.Supplier
										.Where(c => c.Id == (supplierList.SelectedItems[0] as Supplier).Id).FirstOrDefault();
						db.Supplier.Remove(t);
						db.SaveChanges();

						//==================
						suppliers.Clear();
						var glist = db.Supplier.ToList();
						foreach (Supplier xsupplier in glist)
						{
							suppliers.Add(xsupplier);
						}
						supplierList.ItemsSource = suppliers;
						//==================
					}
				}
			}
		}

		private void updateSupplier_Click(object sender, RoutedEventArgs e)
		{
			if (supplierList.SelectedIndex == -1)
			{
				MessageBox.Show("Выделите запись");
			}
			else
			{
				using (var db = new DataContext())
				{
					Supplier t = db.Supplier
									.Where(c => c.Id == (supplierList.SelectedItems[0] as Supplier).Id).FirstOrDefault();

					t.Name = InputName.Text;
					t.City = InputCity.Text;
					t.Street = InputStreet.Text;
					t.Phone = InputPhone.Text;

					db.SaveChanges();

					//==================
					suppliers.Clear();
					var glist = db.Supplier.ToList();
					foreach (Supplier xsupplier in glist)
					{
						suppliers.Add(xsupplier);
					}
					supplierList.ItemsSource = suppliers;
					//==================
				}
			}
		}
	}
}
