using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class CurrencyCalculatorPage : Page
	{
		public CurrencyCalculatorPage()
		{
			this.InitializeComponent();
		}

		private void ButtonConversion_Click(object sender, RoutedEventArgs e)
		{
			if (ComboBoxFrom.SelectedIndex == 0 && ComboBoxTo.SelectedIndex == 1 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 0.85189982;

					TextBlockIntro.Text = result + " US Dollars =";
					TextBlockResult.Text = "€ " + convert.ToString("0.00") + " Euros";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}

			else if (ComboBoxFrom.SelectedIndex == 0 && ComboBoxTo.SelectedIndex == 2 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 0.72872436;

					TextBlockIntro.Text = result + " US Dollars =";
					TextBlockResult.Text = "£ " + convert.ToString("0.00") + " Pound";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 0 && ComboBoxTo.SelectedIndex == 3 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 74.257327;

					TextBlockIntro.Text = result + " US Dollars =";
					TextBlockResult.Text = "₹ " + convert.ToString("0.00") + " Indian Rupees";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 1 && ComboBoxTo.SelectedIndex == 0 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 1.1739732;

					TextBlockIntro.Text = result + " Euros =";
					TextBlockResult.Text = "$ " + convert.ToString("0.00") + " US Dollars";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 1 && ComboBoxTo.SelectedIndex == 2 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 0.8556672;

					TextBlockIntro.Text = result + " Euros =";
					TextBlockResult.Text = "£ " + convert.ToString("0.00") + " Pounds";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 1 && ComboBoxTo.SelectedIndex == 3 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 87.00755;

					TextBlockIntro.Text = result + " Euros =";
					TextBlockResult.Text = "₹ " + convert.ToString("0.00") + " Indian Rupees";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 2 && ComboBoxTo.SelectedIndex == 0 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 1.371907;

					TextBlockIntro.Text = result + " Pounds =";
					TextBlockResult.Text = "$ " + convert.ToString("0.00") + " Dollars";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 2 && ComboBoxTo.SelectedIndex == 1 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 1.1686692;

					TextBlockIntro.Text = result + " Pounds =";
					TextBlockResult.Text = "€ " + convert.ToString("0.00") + " Euros";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 2 && ComboBoxTo.SelectedIndex == 3 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 101.68635;

					TextBlockIntro.Text = result + " Pounds =";
					TextBlockResult.Text = "₹ " + convert.ToString("0.00") + " Indian Rupees";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 3 && ComboBoxTo.SelectedIndex == 0 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 0.011492628;

					TextBlockIntro.Text = result + " Indian Rupees =";
					TextBlockResult.Text = "$ " + convert.ToString("0.00") + " US Dollars";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 3 && ComboBoxTo.SelectedIndex == 1 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 0.013492774;

					TextBlockIntro.Text = result + " Indian Rupees =";
					TextBlockResult.Text = "€ " + convert.ToString("0.00") + " Euros";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else if (ComboBoxFrom.SelectedIndex == 3 && ComboBoxTo.SelectedIndex == 1 && !TextBoxAmount.Text.Equals(""))
			{
				try
				{
					double result = double.Parse(TextBoxAmount.Text);
					double convert = result * 0.0098339397;

					TextBlockIntro.Text = result + " Indian Rupees =";
					TextBlockResult.Text = "£ " + convert.ToString("0.00") + " Pounds";

					Console.WriteLine(result);
				}

				catch (FormatException)
				{
					Console.WriteLine($"Unable to parse '{TextBoxAmount.Text}'");

					TextBlockResult.Text = "Enter a number";
					TextBoxAmount.Text = "";
				}
			}
			else
			{
				TextBlockResult.Text = "Enter a number and two different choices of currency";
				TextBoxAmount.Text = "";
			}
		}

		private void ButtonExit_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(Menu));
		}
	}
}
