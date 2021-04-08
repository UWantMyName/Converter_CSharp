using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Converter_CSharp
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


		private void TemperatureConvClick(object sender, RoutedEventArgs e)
		{
			TemperatureConverter w = new TemperatureConverter();
			w.Show();
		}

		private void CurrencyConvClick(object sender, RoutedEventArgs e)
		{
			CurrencyConverter w = new CurrencyConverter();
			w.Show();
		}

		private void ExitClick(object sender, RoutedEventArgs e)
		{
			this.Close();
		}
	}
}
