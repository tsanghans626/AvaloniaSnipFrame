using System;
using Avalonia.SnipFrame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.SnipFrame.ViewModels
{
    public partial class KnowledgeViewModel : ObservableObject
    {
        private readonly KnowledgeModel _knowledgeModel;
        
        public string Id => _knowledgeModel.Id;
        public string Name => _knowledgeModel.Name;
        public string Description => _knowledgeModel.Description;
        public string Version => _knowledgeModel.Version;
        public string Author => _knowledgeModel.Author;
        public bool IsEnabled => _knowledgeModel.IsEnabled;

        public KnowledgeViewModel(KnowledgeModel knowledgeModel)
        {
            _knowledgeModel = knowledgeModel;
            // 默认示例数据
            // Name = "开发文档库";
            // Description = "包含项目相关的开发文档、API参考和最佳实践指南";
            // Path = "D:\\Documents\\KnowledgeBases\\Dev";
            // FileCount = 42;
            // LastUpdated = DateTime.Now.AddDays(-2);
            // IsLoaded = true;
        }
    }
}