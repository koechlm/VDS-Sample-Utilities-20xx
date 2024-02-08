/*=====================================================================
  
  This file is part of the Autodesk Vault API Code Samples.

  Copyright (C) Autodesk Inc.  All rights reserved.

THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
PARTICULAR PURPOSE.
=====================================================================*/

using Autodesk.Connectivity.WebServices;
using Autodesk.Connectivity.WebServicesTools;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Connections;
using Autodesk.DataManagement.Client.Framework.Vault.Results;
using Autodesk.DataManagement.Client.Framework.Vault.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VDF = Autodesk.DataManagement.Client.Framework;

namespace VdsSampleUtilities
{
    /// <summary>
    /// SDK sample utilities
    /// </summary>
    public class Util
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        public static void DoAction(Action a)
        {
            try
            {
                a();
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Get the parent application's installation path
        /// </summary>
        /// <returns></returns>
        public static string GetAssemblyPath()
        {
            string prefix = "file:///";
            string codebase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            if (codebase.StartsWith(prefix))
                codebase = codebase.Substring(prefix.Length);

            return Path.GetDirectoryName(codebase);
        }
    }

    internal static class ExtensionMethods
    {
        internal static T[] ToSingleArray<T>(this T obj)
        {
            return new T[] { obj };
        }

        internal static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || collection.Count() == 0;
        }

        internal static List<T> ShallowCopy<T>(this List<T> origList)
        {
            List<T> newList = new List<T>();
            newList.AddRange(origList);
            return newList;
        }

        internal static VDF.Currency.FilePathAbsolute ToVDFPath(this string localPath)
        {
            return new VDF.Currency.FilePathAbsolute(localPath);
        }
    }
}
