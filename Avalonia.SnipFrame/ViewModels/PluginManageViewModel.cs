// ViewModels/PluginManageViewModel.cs

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.SnipFrame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveUI;
using System.Reactive.Concurrency;

namespace Avalonia.SnipFrame.ViewModels
{
    public partial class PluginManageViewModel : ObservableObject
    {
        
        [ObservableProperty] private PluginViewModel? _runningPlugin;
        [ObservableProperty] private PluginViewModel? _selectedPlugin;
        [ObservableProperty] private ObservableCollection<PluginViewModel> _availablePlugins = new();
        [ObservableProperty] private KnowledgeViewModel? _loadingKnowledge;
        [ObservableProperty] private KnowledgeViewModel? _selectedKnowledgeBase;
        [ObservableProperty] private ObservableCollection<KnowledgeViewModel> _availableKnowledgeBases = new();
        [ObservableProperty] private bool _isLoading = false;

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
            
            var pluginModels = new List<PluginModel>();
            pluginModels.Add(new PluginModel
            {
                Id = "plugin1", Name = "代码片段管理器", Description = "管理和组织代码片段", Version = "1.0.0", Author = "开发者A",
                IsEnabled = true, IsInstalled = true
            });
            pluginModels.Add(new PluginModel
            {
                Id = "plugin2", Name = "Markdown增强", Description = "提供增强的Markdown编辑功能", Version = "2.1.0",
                Author = "开发者B", IsEnabled = false, IsInstalled = true
            });
            pluginModels.Add(new PluginModel
            {
                Id = "plugin3", Name = "代码格式化", Description = "自动格式化代码", Version = "1.5.2", Author = "开发者C",
                IsEnabled = false, IsInstalled = true
            });
            foreach (var pluginModel in pluginModels)
            { 
                AvailablePlugins.Add(new PluginViewModel(pluginModel));
            }
            RunningPlugin = AvailablePlugins[0];

            // 模拟本地知识库数据
            AvailableKnowledgeBases.Clear();
            var knowledgeModels = new List<KnowledgeModel>();
            knowledgeModels.Add(new KnowledgeModel
            {
                Id = "knowledge1", Name = "祖安语录一", Description = "祖安语录一", IsEnabled = true
            });
            knowledgeModels.Add(new KnowledgeModel
            {
                Id = "knowledge2", Name = "祖安语录二", Description = "祖安语录二", IsEnabled = false
            });
            knowledgeModels.Add(new KnowledgeModel
            {
                Id = "knowledge3", Name = "祖安语录三", Description = "祖安语录三",IsEnabled = false
            });
            foreach (var knowledgeModel in knowledgeModels)
            { 
                AvailableKnowledgeBases.Add(new KnowledgeViewModel(knowledgeModel));
            }
            LoadingKnowledge = AvailableKnowledgeBases[0];

            IsLoading = false;
        }
    }
}