﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jering.KeyValueStore {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Jering.KeyValueStore.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to LogCompacted. safe-readonly region byte size before compaction = {0}, after compaction = {1}. Num consecutive compactions = {2}..
        /// </summary>
        internal static string LogTrace_LogCompacted {
            get {
                return ResourceManager.GetString("LogTrace_LogCompacted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Log compaction threshold increased. Previous = {0}, current = {1}..
        /// </summary>
        internal static string LogTrace_LogCompactionThresholdIncreased {
            get {
                return ResourceManager.GetString("LogTrace_LogCompactionThresholdIncreased", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping log compaction. Current safe-readonly region byte size = {0}, log compaction threshold = {1}..
        /// </summary>
        internal static string LogTrace_SkippingLogCompaction {
            get {
                return ResourceManager.GetString("LogTrace_SkippingLogCompaction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception thrown in log compaction loop:
        ///{0}.
        /// </summary>
        internal static string LogWarning_Exception {
            get {
                return ResourceManager.GetString("LogWarning_Exception", resourceCulture);
            }
        }
    }
}
