using System;
using System.Windows;
using System.Windows.Input;

namespace NumberOfTwoDigits{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		bool isNaturalNumber(string text) => System.Text.RegularExpressions.Regex.IsMatch(text, @"^\d+$");

		void unhandleNumbers(object sender, TextCompositionEventArgs e) => e.Handled = !isNaturalNumber(e.Text);

		void enhandleSpaces(object sender, KeyEventArgs e) => e.Handled = e.Key == Key.Space;

		void handlePasting(object sender, DataObjectPastingEventArgs e){
			if(!e.DataObject.GetDataPresent(typeof(String)))
				e.CancelCommand();
			else if(!isNaturalNumber((String)e.DataObject.GetData(typeof(String))))
				e.CancelCommand();
		}

		void processNumber(object sender, RoutedEventArgs e){
			if(number.Text.Length < 2){
				divisibleBy3.Text = "";
				divisibleBy2.Text = "";
				digitsSum.Text = "";
				digitsProduct.Text = "";
				MessageBox.Show("Введите двузначное число.");
			}
			else{
				byte n = Convert.ToByte(number.Text);
				divisibleBy3.Text = n % 3 == 0 ? "Да" : "Нет";
				divisibleBy2.Text = n % 2 == 0 ? "Да" : "Нет";
				digitsSum.Text = (n / 10 + n % 10).ToString();
				digitsProduct.Text = (n / 10 * (n % 10)).ToString();
			}
		}
	}
}