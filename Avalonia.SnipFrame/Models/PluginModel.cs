// Models/PluginModel.cs
using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Avalonia.SnipFrame.Models
{
    public class PluginModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsInstalled { get; set; }
        public string IconPath { get; set; }
    }
}