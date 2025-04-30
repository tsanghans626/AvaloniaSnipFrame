using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.SnipFrame.ViewModels;

namespace Avalonia.SnipFrame.Views;

public partial class ContentView : UserControl
{
    public ContentView()
    {
        DataContext = new ContentViewModel();
        InitializeComponent();
       
    }
}