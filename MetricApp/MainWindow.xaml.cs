using System.Windows;
using Splat;
using MetricViewModel;

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