﻿using System.Linq;
using System.Windows;

namespace CV19
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool IsDesignMode { get; private set; } = true;
        protected override void OnStartup(StartupEventArgs e)
        {
            IsDesignMode = false;
            base.OnStartup(e);
            Services.DataService dataService = new Services.DataService();
            var countries = dataService.GetData().ToArray();
        }
    }
}
