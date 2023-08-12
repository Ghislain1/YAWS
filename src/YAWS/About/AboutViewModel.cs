// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS.About;

using Microsoft.VisualBasic;
using MvvmGen;
using MvvmGen.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using YAWS.Core;
using YAWS.Core.Domain;

[ViewModel]
//[Inject(typeof(IEventAggregator))]
public partial class AboutViewModel : IDashbordItem
{
    private readonly IEventAggregator eventAggregator;
    public AboutViewModel(IEventAggregator eventAggregator)
    {
        this.eventAggregator = eventAggregator;
        LibrariesView = CollectionViewSource.GetDefaultView(LibraryManager.List);
        LibrariesView.SortDescriptions.Add(new SortDescription(nameof(LibraryInfo.Name), ListSortDirection.Ascending));
    }
    public string Name { get; } = "About";

    public string Description { get; } = "About - Description";

    public string Version => $"Version {AssemblyManager.Current.Version}";
    public ICollectionView LibrariesView { get; }



}