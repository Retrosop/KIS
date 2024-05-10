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

		private void tovarShow_Click(object sender, RoutedEventArgs e)
		{
			ProductForm ProductForm = new ProductForm();
			ProductForm.Show();
		}
	}
}