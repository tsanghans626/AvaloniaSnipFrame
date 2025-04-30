using System;
using Avalonia.SnipFrame.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Avalonia.SnipFrame.ViewModels
{
    public partial class KnowledgeViewModel : ObservableObject
    {
        private readonly KnowledgeModel? _knowledgeModel;

        public string Id =>  _knowledgeModel.Id;
        public string Name =>  _knowledgeModel.Name;
        public string Description =>  _knowledgeModel.Description;
        public bool IsEnabled =>  _knowledgeModel.IsEnabled;

        public KnowledgeViewModel(KnowledgeModel knowledgeModel)
        {
            _knowledgeModel = knowledgeModel;
        }

    }
}