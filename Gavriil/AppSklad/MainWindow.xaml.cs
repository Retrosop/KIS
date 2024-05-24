using System.Collections.ObjectModel;
using System.Windows;
using static ConsoleAppAccess.DBModel;

namespace AppSklad
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void productShow_Click(object sender, RoutedEventArgs e)
		{
			ProductForm productForm = new ProductForm();
			productForm.Show();
		}

		private void supplierShow_Click(object sender, RoutedEventArgs e)
		{
			SupplierForm supplierForm = new SupplierForm();
			supplierForm.Show();
		}

		private void receiptProductShow_Click(object sender, RoutedEventArgs e)
		{

			ReceiptProductForm receiptProductForm = new ReceiptProductForm();
			receiptProductForm.Show();
		}
	}
}