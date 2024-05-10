using System.Windows;

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

		private void addTovar_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Товар добавлен!");
		}
    }
}