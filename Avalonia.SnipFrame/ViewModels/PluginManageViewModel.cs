// ViewModels/PluginManageViewModel.cs

using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia.SnipFrame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.SnipFrame.ViewModels
{
    public partial class PluginManageViewModel : ObservableObject
    {
        
        [ObservableProperty] private PluginModel _runningPlugin;
        [ObservableProperty] private PluginModel _selectedPlugin;
        [ObservableProperty] private ObservableCollection<PluginModel> _availablePlugins = new();
        [ObservableProperty] private KnowledgeBaseModel _loadingKnowledgeBase;
        [ObservableProperty] private PluginModel _selectedKnowledgeBase;
        [ObservableProperty] private ObservableCollection<KnowledgeBaseModel> _availableKnowledgeBases = new();
        [ObservableProperty] private bool _isLoading;

        public PluginManageViewModel()
        {
            // 模拟数据加载
            LoadPluginsAsync();
        }

        [RelayCommand]
        private async Task LoadPluginsAsync()
        {
            IsLoading = true;

            // 在实际应用中，这里应该从服务或仓库加载数据
            await Task.Delay(500); // 模拟网络延迟

            // 模拟已安装插件数据
            AvailablePlugins.Clear();
            AvailablePlugins.Add(new PluginModel
            {
                Id = "plugin1", Name = "代码片段管理器", Description = "管理和组织代码片段", Version = "1.0.0", Author = "开发者A",
                IsEnabled = true, IsInstalled = true
            });
            AvailablePlugins.Add(new PluginModel
            {
                Id = "plugin2", Name = "Markdown增强", Description = "提供增强的Markdown编辑功能", Version = "2.1.0",
                Author = "开发者B", IsEnabled = true, IsInstalled = true
            });
            AvailablePlugins.Add(new PluginModel
            {
                Id = "plugin3", Name = "代码格式化", Description = "自动格式化代码", Version = "1.5.2", Author = "开发者C",
                IsEnabled = false, IsInstalled = true
            });
            RunningPlugin = AvailablePlugins[0];

            // 模拟本地知识库数据
            AvailableKnowledgeBases.Clear();
            AvailableKnowledgeBases.Add(new KnowledgeBaseModel
            {
                Id = "knowledge1", Name = "祖安语录一", Description = "祖安语录一", Version = "1.0.1", Author = "开发者D",
            });
            AvailableKnowledgeBases.Add(new KnowledgeBaseModel
            {
                Id = "knowledge2", Name = "祖安语录二", Description = "祖安语录二", Version = "0.9.0", Author = "开发者E",
            });
            AvailableKnowledgeBases.Add(new KnowledgeBaseModel
            {
                Id = "knowledge3", Name = "祖安语录三", Description = "祖安语录三", Version = "1.2.0", Author = "开发者F",
            });
            LoadingKnowledgeBase = AvailableKnowledgeBases[0];

            IsLoading = false;
        }
    }
}