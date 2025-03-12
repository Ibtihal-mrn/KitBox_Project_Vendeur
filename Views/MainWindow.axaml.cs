using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace KitBox_Project.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                var homePage = new HomePage();
                
    
                MainContent.Content = homePage;
        }

        // Ouvre/ferme le menu proprement
        private void ToggleMenu(object? sender, RoutedEventArgs e)
        {
            MenuPanel.IsPaneOpen = !MenuPanel.IsPaneOpen;
        }

        // Gérer la navigation
       
        private void GoToInspirations(object? sender, RoutedEventArgs e) => MainContent.Content = new Inspirations();
       
        private void GoToHelpSupport(object? sender, RoutedEventArgs e) => MainContent.Content = new HelpSupport();

        private void GoToOrder(object? sender, RoutedEventArgs e) => MainContent.Content = new Order();

        private void GoToHome(object? sender, RoutedEventArgs e) => MainContent.Content = new HomePage();
    }
}
