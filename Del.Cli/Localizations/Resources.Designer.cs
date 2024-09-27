﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Del.Cli.Localizations {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Del.Cli.Localizations.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete files or directories either recursively or non-recursively..
        /// </summary>
        internal static string Command_Delete_Many_Description {
            get {
                return ResourceManager.GetString("Command.Delete.Many.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete a file or director either recursively or non-recursively..
        /// </summary>
        internal static string Command_Delete_Single_Description {
            get {
                return ResourceManager.GetString("Command.Delete.Single.Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want directory {x} to be deleted?.
        /// </summary>
        internal static string DeleteConfirmation_Directory {
            get {
                return ResourceManager.GetString("DeleteConfirmation.Directory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter Y for yes OR N for no..
        /// </summary>
        internal static string DeleteConfirmation_YesOrNo {
            get {
                return ResourceManager.GetString("DeleteConfirmation.YesOrNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want file {x} to be deleted?.
        /// </summary>
        internal static string DeleteConfrmation_File {
            get {
                return ResourceManager.GetString("DeleteConfrmation.File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {x}, which was an Empty Directory, was deleted..
        /// </summary>
        internal static string EmptyDirectory_Deleted {
            get {
                return ResourceManager.GetString("EmptyDirectory.Deleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate directory {x}. If this directory previously existed it may have been moved or deleted..
        /// </summary>
        internal static string Exceptions_DirectoryNotFound {
            get {
                return ResourceManager.GetString("Exceptions.DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to locate file {x}. If the file previously existed it may have been moved or deleted..
        /// </summary>
        internal static string Exceptions_FileNotFound {
            get {
                return ResourceManager.GetString("Exceptions.FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid file or directory was passed as an argument..
        /// </summary>
        internal static string Exceptions_InvalidArgumentsProvided {
            get {
                return ResourceManager.GetString("Exceptions.InvalidArgumentsProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An invalid value was provided. Please try again..
        /// </summary>
        internal static string Exceptions_InvalidDeleteConfirmation {
            get {
                return ResourceManager.GetString("Exceptions.InvalidDeleteConfirmation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory argument passed is not allowed in this program for the safety of your system..
        /// </summary>
        internal static string Exceptions_InvalidSlashArgument {
            get {
                return ResourceManager.GetString("Exceptions.InvalidSlashArgument", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No files or directories were provided..
        /// </summary>
        internal static string Exceptions_NoArgumentsProvided {
            get {
                return ResourceManager.GetString("Exceptions.NoArgumentsProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to no.
        /// </summary>
        internal static string Input_No {
            get {
                return ResourceManager.GetString("Input.No", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to yes.
        /// </summary>
        internal static string Input_Yes {
            get {
                return ResourceManager.GetString("Input.Yes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {x} was deleted..
        /// </summary>
        internal static string Item_Deleted {
            get {
                return ResourceManager.GetString("Item.Deleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Force deletion of files or directories.
        /// </summary>
        internal static string Parameters_Force_Description {
            get {
                return ResourceManager.GetString("Parameters.Force.Description", resourceCulture);
            }
        }
    }
}
