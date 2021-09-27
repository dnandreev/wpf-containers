using System.Windows;
using System.Windows.Controls;

namespace DrawErase{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();

		void CheckBox_Checked(object sender, RoutedEventArgs e) => inkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;

		void CheckBox_Unchecked(object sender, RoutedEventArgs e) => inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
	}
}