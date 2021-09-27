using System.Windows;

namespace Menu{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void clearTextField(object sender, RoutedEventArgs e) => textField.Text = "";
	}
}