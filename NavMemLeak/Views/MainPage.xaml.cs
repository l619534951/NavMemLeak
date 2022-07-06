using Microsoft.UI.Xaml.Controls;

using NavMemLeak.ViewModels;

namespace NavMemLeak.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
