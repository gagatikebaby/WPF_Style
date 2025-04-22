using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using uistyle.Service;
using uistyle.ViewModel;

namespace uistyle;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : IWindow
{
    public MainViewModel ViewModel { get; }

    public MainWindow(MainViewModel viewModel)
    {
        Wpf.Ui.Appearance.SystemThemeWatcher.Watch(this);
        DataContext = this;
        ViewModel = viewModel;
        InitializeComponent();

    }

    private void OnNavigationSelectionChanged(Wpf.Ui.Controls.NavigationView sender, RoutedEventArgs args)
    {

    }

    private void NavigationView_OnPaneOpened(Wpf.Ui.Controls.NavigationView sender, RoutedEventArgs args)
    {

    }

    private void NavigationView_OnPaneClosed(Wpf.Ui.Controls.NavigationView sender, RoutedEventArgs args)
    {

    }
}