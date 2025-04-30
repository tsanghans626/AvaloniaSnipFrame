using ReactiveUI;

namespace Avalonia.SnipFrame.ViewModels;

using System.Collections.ObjectModel;
using ReactiveUI;
using System;
using System.Windows.Input;

public class TabItemViewModel : ViewModelBase
{
    private string _header;
    private object _content;
    private bool _canClose;
    public ICommand CloseCommand { get; set; }

    public TabItemViewModel(string header, object content, bool canClose = true)
    {
        Header = header;
        Content = content;
        CanClose = canClose;
    }

    public string Header
    {
        get => _header;
        set => this.RaiseAndSetIfChanged(ref _header, value);
    }

    public object Content
    {
        get => _content;
        set => this.RaiseAndSetIfChanged(ref _content, value);
    }

    public bool CanClose
    {
        get => _canClose;
        set => this.RaiseAndSetIfChanged(ref _canClose, value);
    }
}

public class ContentViewModel : ViewModelBase
{
    private ObservableCollection<TabItemViewModel> _tabs;
    private TabItemViewModel _selectedTab;
    private DocumentViewModel _documentViewModel;

    public ContentViewModel()
    {
        DocumentViewModel = new DocumentViewModel();
        Tabs = new ObservableCollection<TabItemViewModel>();
        
        // 添加默认的文档标签页（不可关闭）
        var docTab = new TabItemViewModel("文档", DocumentViewModel, true);
        Tabs.Add(docTab);
        SelectedTab = docTab;
        
        // 创建关闭标签页命令
        CloseTabCommand = ReactiveCommand.Create<TabItemViewModel>(CloseTab);
        
        // 为所有标签页设置关闭命令
        foreach (var tab in Tabs)
        {
            tab.CloseCommand = CloseTabCommand;
        }
    }

    public ObservableCollection<TabItemViewModel> Tabs
    {
        get => _tabs;
        set => this.RaiseAndSetIfChanged(ref _tabs, value);
    }

    public TabItemViewModel SelectedTab
    {
        get => _selectedTab;
        set => this.RaiseAndSetIfChanged(ref _selectedTab, value);
    }

    public DocumentViewModel DocumentViewModel
    {
        get => _documentViewModel;
        set => this.RaiseAndSetIfChanged(ref _documentViewModel, value);
    }

    public ICommand CloseTabCommand { get; }

    public void AddTab(string header, object content, bool canClose = true)
    {
        var tab = new TabItemViewModel(header, content, canClose);
        tab.CloseCommand = CloseTabCommand;
        Tabs.Add(tab);
        SelectedTab = tab;
    }

    private void CloseTab(TabItemViewModel tab)
    {
        if (tab.CanClose && Tabs.Count > 1)
        {
            int index = Tabs.IndexOf(tab);
            Tabs.Remove(tab);
            
            // 如果关闭的是当前选中的标签页，选择相邻的标签页
            if (SelectedTab == tab)
            {
                SelectedTab = Tabs[Math.Max(0, index - 1)];
            }
        }
    }
}