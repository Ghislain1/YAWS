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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAWS.About;
using YAWS.Core;
using YAWS.Help;
using YAWS.Scan;

public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
    private INotifyPropertyChanged? currentViewModel;
    private bool isLoggedIn;
    private ObservableCollection<IDashbordItem> items = new ObservableCollection<IDashbordItem>();
    public ObservableCollection<IDashbordItem> Items
    {
        get => this.items;

    }
    public MainViewModel()
    {
        this.items.Add(new ScanViewModel());
        this.items.Add(new AboutViewModel());
        this.items.Add(new HelpViewModel());
        this.SelectedItem = this.items.First();

    }
    private IDashbordItem selectedItem;
    public IDashbordItem SelectedItem { get => selectedItem; set
        {
            selectedItem = value;
            this.OnPropertyChanged();
        } }





}