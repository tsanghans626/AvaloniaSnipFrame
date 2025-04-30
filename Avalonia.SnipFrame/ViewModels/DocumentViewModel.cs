using System.Collections.ObjectModel;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using Avalonia.SnipFrame.Models;
using System.Reactive.Concurrency;
using ReactiveUI;


namespace Avalonia.SnipFrame.ViewModels;

public partial class DocumentViewModel : ObservableObject
{
    [ObservableProperty] private MarkdownViewModel? _selectedMarkdown;
    public ObservableCollection<MarkdownViewModel> Markdowns { get; } = new();

    public DocumentViewModel()
    {
        RxApp.MainThreadScheduler.Schedule(LoadMarkdowns);
    }

    private async void LoadMarkdowns()
    {
        var markdowns = (await MarkdownModel.Load()).Select(x => new MarkdownViewModel(x));
        Markdowns.Clear();
        foreach (var markdown in markdowns)
        {
            Markdowns.Add(markdown);
        }

        if (Markdowns.Any())
        {
            SelectedMarkdown = Markdowns.First();
        }
    }
}