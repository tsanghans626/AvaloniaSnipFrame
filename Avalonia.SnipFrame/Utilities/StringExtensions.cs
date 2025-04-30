namespace Avalonia.SnipFrame.Utilities;

public class StringExtensions
{
    public static string TruncateWithEllipsis(string text, int maxLength)
    {
        if (string.IsNullOrEmpty(text))
            return string.Empty;
                
        if (text.Length <= maxLength)
            return text;
                
        return text.Substring(0, maxLength) + "...";
    }
}