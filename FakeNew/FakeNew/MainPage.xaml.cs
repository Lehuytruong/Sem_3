using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using FakeNew.Model;



namespace FakeNew
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<NewsItem> NewsItems;
        public MainPage()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<NewsItem>();
        }
        private void HamburgerButton_click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e )
        {
            if(Financial.IsSelected)
            {
                NewManager.GetNews("Financial", NewsItems);
                TitleTextBlock.Text = "Financial";
            }else if(Food.IsSelected)
            {
                NewManager.GetNews("Food", NewsItems);
                TitleTextBlock.Text = "Food";
            }
        }
        private void Page_loaded(object sender, RoutedEventArgs e)
        {
            Financial.IsSelected = true;
        }
    }
}
