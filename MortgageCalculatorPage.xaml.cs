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
	public sealed partial class MortgageCalculatorPage : Page
	{
		public MortgageCalculatorPage()
		{
			this.InitializeComponent();
		}

		private void CalculateClick(object sender, RoutedEventArgs e)
		{
			try
			{
				double loanAmount = double.Parse(principalLoanAmount.Text);
				int year = int.Parse(yearRepayment.Text);
				int months = int.Parse(monthRepayment.Text) + year * 12;
				double yearlyInterestRate = double.Parse(YearlyInterestRate.Text) / 100;
				double monthlyInterestRate = yearlyInterestRate / 12;

				MonthlyInterestRate.Text = monthlyInterestRate.ToString() + "%";

				double formula = (Math.Pow((1 + monthlyInterestRate), months));
				double repayment = Math.Round(loanAmount * ((monthlyInterestRate * formula) / (formula - 1 )), 2);
				MonthlyRepayment.Text = repayment.ToString();
			}
			catch (FormatException)
			{

				Console.WriteLine("happy");

			}
		}


	}
}
