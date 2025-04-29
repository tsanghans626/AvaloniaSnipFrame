using Avalonia.SnipFrame.Models;
namespace Avalonia.SnipFrame.ViewModels;

public class MarkdownViewModel: ViewModelBase
{
    private readonly MarkdownModel _markdown;
    
    public string Filename => _markdown.Filename;
    
    public string Content => _markdown.Content;
    
    public MarkdownViewModel(MarkdownModel markdown)
    {
        _markdown = markdown;
    }
}