using PatronMVVM.Stores;
using PatronMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PatronMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedUserStore _selectedUserStore;

        public App() 
        {
            _selectedUserStore = new SelectedUserStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow() 
            { 
                DataContext = new UsersViewModel(_selectedUserStore)
            };
            MainWindow.Show();
            base.OnStartup(e);

        }
    }
}
