using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UsersListMVVM.View;
using UsersListMVVM.ViewModel;

namespace UsersListMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        MainPage window = new MainPage();
        UserViewModel VM = new UserViewModel();
        window.DataContext = VM;
        window.Show();
    }
}
