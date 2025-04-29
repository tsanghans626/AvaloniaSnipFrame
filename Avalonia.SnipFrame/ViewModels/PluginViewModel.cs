using System;
using System.Windows.Input;
using Avalonia.SnipFrame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.SnipFrame.ViewModels
{
    public partial class PluginViewModel : ObservableObject
    {
        private readonly PluginModel _plugin;
        
        public string Id => _plugin.Id;
        public string Name => _plugin.Name;
        public string Description => _plugin.Description;
        public string Version => _plugin.Version;
        public string Author => _plugin.Author;
        public bool IsEnabled => _plugin.IsEnabled;
        public bool IsInstalled => _plugin.IsInstalled;
        public string IconPath => _plugin.IconPath;

        // 示例构造函数
        public PluginViewModel(PluginModel plugin)
        {
            _plugin = plugin;
            // 默认示例数据
            // Name = "示例插件";
            // Version = "1.2.3";
            // Description = "这是一个示例插件，用于展示插件信息控件的布局和样式。";
            // Author = "开发者";
            // LastUpdated = DateTime.Now.AddDays(-5);
            // IsEnabled = true;
            // HasConfiguration = true;
        }
    }
}