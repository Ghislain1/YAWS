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
using YAWS.Core.Domain;

/// <summary>
/// This class provides information about libraries used within the program.
/// </summary>
public static class LibraryManager
    {
        /// <summary>
        /// Name of the license folder.
        /// </summary>
        private const string LicenseFolderName = "Licenses";

        /// <summary>
        /// Method to get the license folder location.
        /// </summary>
        /// <returns>Location of the license folder.</returns>
        public static string GetLicenseLocation()
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) ?? throw new DirectoryNotFoundException("Program execution directory not found, while trying to build path to license directory!"), LicenseFolderName);
        }

        /// <summary>
        /// Static list with all libraries that are used.
        /// </summary>
        public static List<LibraryInfo> List => new()
    {
        new LibraryInfo("MahApps.Metro", "https://github.com/mahapps/mahapps.metro", "Description","MITLicense", "https://github.com/MahApps/MahApps.Metro/blob/master/LICENSE"),
        new LibraryInfo("MahApps.Metro.IconPacks", "https://github.com/mahapps/mahapps.metro",  "Description","_MITLicense", "https://github.com/MahApps/MahApps.Metro.IconPacks/blob/master/LICENSE"),
        
       // new LibraryInfo("Microsoft.PowerShell.SDK", "https://github.com/PowerShell/PowerShell", Localization.Resources.Strings.Library_PowerShellSDK_Description, Localization.Resources.Strings.License_MITLicense, "https://github.com/PowerShell/PowerShell/blob/master/LICENSE.txt"),
        
      //  new LibraryInfo("log4net", "https://logging.apache.org/log4net/", Localization.Resources.Strings.Library_log4net_Description, Localization.Resources.Strings.License_ApacheLicense2dot0, "https://github.com/apache/logging-log4net/blob/master/LICENSE"),
 
    };
    }