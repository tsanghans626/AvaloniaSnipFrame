using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.SnipFrame.Models;
using ReactiveUI;


namespace Avalonia.SnipFrame.ViewModels;

public partial class MarkdownViewModel : ObservableObject
{
    [ObservableProperty]
    private MarkdownModel _selectedMarkdown;
    public ObservableCollection<MarkdownModel> Markdowns { get; } = new();

    public MarkdownViewModel()
    {
        Markdowns.Add(new MarkdownModel("1.md","# Hello World 1!"));
        Markdowns.Add(new MarkdownModel("2.md","# Hello World 2!"));
        Markdowns.Add(new MarkdownModel("3.md","# Hello World 3!"));
        _selectedMarkdown = Markdowns[0];
    }
    
    // partial void OnSelectedMarkdownChanged(MarkdownModel value)
    // {
    //     // 打印日志以确认 SelectedMarkdown 的变化
    //     Console.WriteLine($"SelectedMarkdown changed to: {value?.Filename}");
    // }
    
    
    // public MarkdownModel SelectedMarkdown
    // {
    //     get => _selectedMarkdown;
    //     set => this.SetProperty(ref this._selectedMarkdown, value);
    // }

}