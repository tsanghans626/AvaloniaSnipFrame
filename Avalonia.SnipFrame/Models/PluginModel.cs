// Models/PluginModel.cs
using System;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia.SnipFrame.Models
{
    public class PluginModel
    {
        public required string  Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Version { get; set; }
        public required string Author { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsInstalled { get; set; }
        public string? IconPath { get; set; }
    }
}