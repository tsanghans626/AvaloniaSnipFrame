using HotAvalonia;
using Avalonia.Controls;

namespace Avalonia.SnipFrame.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
    
        [AvaloniaHotReload]
        private void Initialize()
        {
            // Code to initialize or refresh
            // the control during hot reload.
        }
    }
}

