﻿using EnterpriseMVVM.DesktopClient.ViewModels;
using EnterpriseMVVM.DesktopClient.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EnterpriseMVVM.DesktopClient
{
    //using ViewModels;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Overides of Application
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var window = new MainWindow
            {
                DataContext = new CustomerViewModel()
            };

            window.ShowDialog();
        }

        #endregion
    }
}
