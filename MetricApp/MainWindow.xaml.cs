using System.Windows;
using Splat;

namespace MetricApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Locator.Current.GetService<IMainWindowViewModel>();
        }
    }
}