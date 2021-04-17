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
	/// Interaction logic for CurrencyConverter.xaml
	/// </summary>
	public partial class CurrencyConverter : Window
	{
		public CurrencyConverter()
		{
			InitializeComponent();
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			value.Text = value.Text.Trim();

			if (initialcurr.SelectedIndex == nextcurr.SelectedIndex|| initialcurr.SelectedIndex < 0 || nextcurr.SelectedIndex < 0)
			{
				MessageBox.Show("You may have not selected what you want to convert to/from or what you want to convert to/from might be the same. Try again.");
				return;
			}

			double n = ConvertToNumber(value.Text);

			if (n == -1) return;

			double number = CalculateConversion(n, nextcurr.SelectedIndex, initialcurr.SelectedIndex);
			string message = "";

			if (nextcurr.SelectedIndex == 0) message += "€";
			else if (nextcurr.SelectedIndex == 1) message += "$";
			else if (nextcurr.SelectedIndex == 2) message += "£";

			message += " " + number.ToString();
			MessageBox.Show(message);
			
		}
		private double ConvertToNumber(string text)
		{
			string answer = "";

			foreach (char c in text)
			{
				if ('0' <= c && c <= '9') answer += c;
				else if (c == 'k' || c == 'K') answer += "000";
				else
				{
					MessageBox.Show("You can only enter numbers and 'k'. Your input is invalid. Try again.");
					return -1;
				}
			}

			return double.Parse(answer);
		}
		private double CalculateConversion(double initial, int nextindex, int initindex)
		{
			double number;

			if (initindex == 0)
			{
				if (nextindex == 1) number = initial * 1.19;
				else number = 0.86 * initial;
			}

			else if (initindex == 1)
			{
				if (nextindex == 0) number = initial * 0.84;
				else number = 0.73 * initial;
			}

			else
			{
				if (nextindex == 0) number = initial * 1.16;
				else number = 1.37 * initial;
			}

			return number;
		}
	}
}
