﻿using System.Text.Json;
using WPFGallery.Models;
using WPFGallery.Navigation;
using System.IO;
using System.Reflection;

namespace WPFGallery.ViewModels
{
    public partial class IconsPageViewModel : BasePageViewModel
    {
        [ObservableProperty]
        private ICollection<IconData> _icons;

        [ObservableProperty]
        private IconData? _selectedIcon;

        public IconsPageViewModel()
        {
            PageTitle = "Icons";
            PageDescription = "Guide showing how to use icons in your application.";
            var jsonText = ReadIconData();
            _icons = JsonSerializer.Deserialize<List<IconData>>(jsonText);
            _selectedIcon = _icons.FirstOrDefault();
        }

        private string ReadIconData()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "WPFGallery.Models.IconsData.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
