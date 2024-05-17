using System.Collections.ObjectModel;
using System.Printing;
using System.Windows;
using static ConsoleAppAccess.DBModel;

namespace AppSklad
{
	/// <summary>
	/// Логика взаимодействия для ProductForm.xaml
	/// </summary>
	public partial class ProductForm : Window
	{
		int IdSelected = 0;
		ObservableCollection<Product> products;
		public ProductForm()
		{
			InitializeComponent();
			products = new ObservableCollection<Product>();
			productList.SelectedIndex = IdSelected;

			using (DataContext db = new DataContext())
			{
				var glist = db.Product.ToList();
				foreach (Product xproduct in glist)
				{
					products.Add(xproduct);
				}

				productList.ItemsSource = products;
				if (IdSelected != 0)
				{
					var t = db.Product
						.Where(c => c.Id == (productList.SelectedItems[0] as Product).Id)
						.FirstOrDefault();
					InputName.Text = t.Name;
					InputMeasurement.Text = t.Measurement;
					InputPrice.Text = t.Price.ToString().Replace(',','.');
				}
			}
		}

		private void addProduct_Click(object sender, RoutedEventArgs e)
		{
			using (DataContext db = new DataContext())
			{
				Product product = new Product();
				product.Name = InputName.Text;
				product.Measurement = InputMeasurement.Text;
				product.Price = float.Parse(InputPrice.Text.Replace('.',','));

				try
				{
					db.Product.Add(product);
					db.SaveChanges();
				}
				catch (FormatException)
				{
					//В случае появление ошибок ввожда
				}
				//==================
				products.Clear();
				var productQuery = db.Product.ToList();
				foreach (Product xproduct in productQuery)
				{
					products.Add(xproduct);
				}
				productList.ItemsSource = products;
				//==================

			}
		}

		private void productList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			IdSelected = productList.SelectedIndex;

			using (var db = new DataContext())
			{
				if (productList.SelectedIndex == -1)
				{
					MessageBox.Show("Выделите запись");
				}
				else
				{
					Product t = db.Product
									.Where(c => c.Id == (productList.SelectedItems[0] as Product).Id).FirstOrDefault();
					InputName.Text = t.Name;
					InputMeasurement.Text = t.Measurement;
					InputPrice.Text = t.Price.ToString().Replace(',', '.'); ;
				}
			}
		}

		private void deleteProduct_Click(object sender, RoutedEventArgs e)
		{
			if (productList.SelectedIndex == -1)
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
						Product t = db.Product
										.Where(c => c.Id == (productList.SelectedItems[0] as Product).Id).FirstOrDefault();
						db.Product.Remove(t);
						db.SaveChanges();

						//==================
						products.Clear();
						var glist = db.Product.ToList();
						foreach (Product xproduct in glist)
						{
							products.Add(xproduct);
						}
						productList.ItemsSource = products;
						//==================
					}
				}
			}
		}

		private void updateProduct_Click(object sender, RoutedEventArgs e)
		{
			if (productList.SelectedIndex == -1)
			{
				MessageBox.Show("Выделите запись");
			}
			else
			{
				using (var db = new DataContext())
				{
					Product t = db.Product
									.Where(c => c.Id == (productList.SelectedItems[0] as Product).Id).FirstOrDefault();

					t.Name = InputName.Text;
					t.Measurement = InputMeasurement.Text;
					t.Price = float.Parse(InputPrice.Text.Replace('.', ','));


					db.SaveChanges();

					//==================
					products.Clear();
					var glist = db.Product.ToList();
					foreach (Product xproduct in glist)
					{
						products.Add(xproduct);
					}
					productList.ItemsSource = products;
					//==================
				}
			}
		}
	}
}
