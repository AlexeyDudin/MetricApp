using System.Configuration;
using System.Data;
using System.Windows;
using MetricApp.DependencyInjection;
using Splat;

namespace MetricApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App() => Bootstrapper.Register(Locator.CurrentMutable, Locator.Current);
    }

}
