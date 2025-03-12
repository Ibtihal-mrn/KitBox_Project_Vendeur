using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Timers; // Utilisation de System.Timers.Timer
using Avalonia.Interactivity;

namespace KitBox_Project.Views
{
    public partial class HomePage : UserControl
    {
       

        public HomePage()
        {
            InitializeComponent();
            
        }

        
        

       

        private void GoToHelpSupport(object? sender, RoutedEventArgs e)
        {
            if (this.VisualRoot is MainWindow mainWindow)
                {
                    mainWindow.MainContent.Content = new HelpSupport();
                }
        }

    }
}