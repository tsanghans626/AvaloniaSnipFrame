using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.SnipFrame.ViewModels;

namespace Avalonia.SnipFrame.Views;

public partial class DocumentView : UserControl
{
    public DocumentView()
    {
        this.DataContext = new DocumentViewModel();
        InitializeComponent();
    }
}