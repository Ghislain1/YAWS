// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS.Scan;

using MvvmGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using YAWS.Core;

[ViewModel]
public partial class ScanViewModel : IDashbordItem
{
    
    public string Name { get; } = "Scan";

    public string Description => throw new NotImplementedException();

    public ICommand ChangePageCommand { get; }
}