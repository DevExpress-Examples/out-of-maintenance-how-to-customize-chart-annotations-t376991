using System.Windows;

namespace MarsTemperature {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
    }
    public class AnnotationContent {
        public string Text { get; set; }
        public string ImageSource { get; set; }
    }
}
