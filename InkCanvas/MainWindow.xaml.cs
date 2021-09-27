using System;
using System.Windows;
using System.Windows.Controls;

namespace InkCanvas{
	public partial class MainWindow : Window{
		public MainWindow() => InitializeComponent();
		void inkCanvas_Gesture(object sender, InkCanvasGestureEventArgs e){
			String gestures = "";
			foreach(System.Windows.Ink.GestureRecognitionResult res in e.GetGestureRecognitionResults())
				gestures += res.ApplicationGesture.ToString() + "; ";
			gestureName.Text = gestures;
		}
		void Window_Loaded(object sender, RoutedEventArgs e){
			foreach(InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
				lstEditingMode.Items.Add(mode);
			lstEditingMode.SelectedItem = inkCanvas.EditingMode;
		}
		void lstEditingMode_SelectionChanged(object sender,
	   SelectionChangedEventArgs e){}
	}
}