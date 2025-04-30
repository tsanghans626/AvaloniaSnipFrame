using System;
using System.Windows.Input;
using Avalonia.SnipFrame.Models;
using Avalonia.SnipFrame.Utilities;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Avalonia.Utilities;

namespace Avalonia.SnipFrame.ViewModels
{
    public partial class PluginViewModel : ObservableObject
    {
        private readonly PluginModel _plugin;
        
        public string Id => _plugin.Id;
        public string Name => StringExtensions.TruncateWithEllipsis(_plugin.Name, 8);
        public string Description => StringExtensions.TruncateWithEllipsis(_plugin.Description, 10);
        public string Version => _plugin.Version;
        public string Author => _plugin.Author;
        public bool IsEnabled => _plugin.IsEnabled;
        public bool IsInstalled => _plugin.IsInstalled;
        public string? IconPath => _plugin.IconPath;

        // 示例构造函数
        public PluginViewModel(PluginModel plugin)
        {
            _plugin = plugin;
        }

    }
}