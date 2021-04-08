using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Converter_CSharp
{
	/// <summary>
	/// Interaction logic for TemperatureConverter.xaml
	/// </summary>
	public partial class TemperatureConverter : Window
	{
		public TemperatureConverter()
		{
			InitializeComponent();
		}

		private void C_to_F_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				float cTemp = float.Parse(CelsiusTemp.Text);
				float fTemp = (cTemp * 9) / 5 + 32;

				FahrenheitTemp.Text = fTemp.ToString();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
			}
		}

		private void F_to_C_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				float fTemp = float.Parse(FahrenheitTemp.Text);
				float cTemp = ((fTemp - 32) * 5) / 9;

				CelsiusTemp.Text = cTemp.ToString();
			}
			catch (Exception exc)
			{
				MessageBox.Show(exc.ToString());
			}
		}
	}
}
