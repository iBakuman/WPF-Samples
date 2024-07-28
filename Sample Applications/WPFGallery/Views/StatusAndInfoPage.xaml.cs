﻿using System.Windows.Controls;
using WPFGallery.ViewModels;

namespace WPFGallery.Views
{
    /// <summary>
    /// Interaction logic for StatusAndInfoPage.xaml
    /// </summary>
    public partial class StatusAndInfoPage : Page
    {
        public StatusAndInfoPageViewModel ViewModel { get; } 
		public StatusAndInfoPage(StatusAndInfoPageViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            DataContext = this;
       }
    }
}
