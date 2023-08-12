// <copyright company="Ghislain One Inc.">
//  Copyright (c) GhislainOne
//  This computer program includes confidential, proprietary
//  information and is a trade secret of GhislainOne. All use,
//  disclosure, or reproduction is prohibited unless authorized in
//  writing by an officer of Ghis. All Rights Reserved.
// </copyright>

namespace YAWS.Core;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;
 public record MyAssemblyInfo(Version? Version, string? Location, string? Name);
/// <summary>
/// Class contains information about the current executing assembly.
/// </summary>
public static class AssemblyManager
{
    /// <summary>
    /// Current executing assembly.
    /// </summary>
    public static MyAssemblyInfo Current { get; set; }

    /// <summary>
    /// Creates a new instance of the <see cref="AssemblyManager"/> class and 
    /// sets the <see cref="Current"/> property on the first call.
    /// </summary>
    static AssemblyManager()
    {
        var assembly = Assembly.GetEntryAssembly();

        var name = assembly.GetName();

        Current = new MyAssemblyInfo(name.Version, Path.GetDirectoryName(assembly.Location), name.Name);
    }
}
