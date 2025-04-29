using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.SnipFrame.ViewModels;

namespace Avalonia.SnipFrame.Views;

public partial class MarkdownView : UserControl
{
    public MarkdownView()
    {
        this.DataContext = new MarkdownViewModel();
        InitializeComponent();
    }
}