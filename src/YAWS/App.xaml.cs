// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS;


using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    public App()
    {
        StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
    }

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
    }

    private void Application_Exit(object sender, ExitEventArgs e)
    {
        //_log.Info("Exiting NETworkManager...");

        // Save settings, when the application is normally closed


        // _log.Info("Stop background job (if it exists)...");
        // _dispatcherTimer?.Stop();


        // _log.Info("Bye!");
    }

}