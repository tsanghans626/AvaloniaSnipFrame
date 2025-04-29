using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace Avalonia.SnipFrame.Models;

public class MarkdownModel
{
    public string Filename { get; set; }
    public string Content { get; set; }
    public DateTime LastModified { get; set; }
    private static string _directory = "D:\\My\\Avalonia.SnipFrame\\Avalonia.SnipFrame\\Assets\\MarkdownFiles";

    public MarkdownModel(string filename, string content)
    {
        Filename = filename;
        Content = content;
    }

    // 扩展构造函数，包含LastModified属性
    public MarkdownModel(string filename, string content, DateTime lastModified)
    {
        Filename = filename;
        Content = content;
        LastModified = lastModified;
    }

    public static async Task<IEnumerable<MarkdownModel>> Load()
    {
        List<MarkdownModel> markdowns = new List<MarkdownModel>();

        try
        {
            // 获取Markdown文件夹路径
            string folderPath = Path.Combine(_directory);

            // 确保文件夹存在
            if (!Directory.Exists(folderPath))
            {
                return markdowns;
            }

            // 获取所有.md文件
            string[] files = Directory.GetFiles(folderPath, "*.md");

            // 为每个文件创建一个Markdown对象
            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                string content = await File.ReadAllTextAsync(filePath);
                DateTime lastModified = File.GetLastWriteTime(filePath);

                markdowns.Add(new MarkdownModel(fileName, content, lastModified));
            }

            // 按最后修改时间排序(最新的在前)
            return markdowns.OrderByDescending(m => m.LastModified);
        }
        catch (Exception ex)
        {
            // 记录异常，实际应用中应该使用日志系统
            Debug.WriteLine($"加载Markdown文件时出错: {ex.Message}");
            return markdowns;
        }
    }
}