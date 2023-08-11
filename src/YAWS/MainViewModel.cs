// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS;

using MvvmGen;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using YAWS.About;
using YAWS.Core;
using YAWS.Help;
using YAWS.Scan;

// Base of MVVM ==> https://github.com/thomasclaudiushuber/mvvmgen
[ViewModel]
public partial class MainViewModel
{

    [Property]
    private ObservableCollection<IDashbordItem> items = new(new IDashbordItem[] { new ScanViewModel(), new AboutViewModel(), new HelpViewModel() });
   
   
    [Command(CanExecuteMethod = nameof(CanChangePage))]
    private void ChangePage(object? inputParameter)
    {
        this.SelectedItem = inputParameter as IDashbordItem;
        //  EventAggregator.Publish(new EmployeeSavedEvent(FirstName, LastName));
    }

    // [CommandInvalidate(nameof(FirstName))]
    private bool CanChangePage(object inputParameter)
    {
        return inputParameter is IDashbordItem;
    }

  
    [Property] 
    private IDashbordItem selectedItem ;

    public void Init()
    {
        this.SelectedItem ??= this.items.First();
    }
  
}