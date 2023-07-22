// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS.Extensions;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;

public static class INotifyPropertyChangedEx
{


    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual static void OnPropertyChanged(this INotifyPropertyChanged caller ,[CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(caller, new PropertyChangedEventArgs(propertyName));
    }
}

