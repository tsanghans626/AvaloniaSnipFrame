using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.SnipFrame.ViewModels;

namespace Avalonia.SnipFrame.Views;

public partial class PluginManageView : UserControl
{
    public PluginManageView()
    {
        InitializeComponent();
        DataContext = new PluginManageViewModel();
    }
}