﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Views.Feedback {
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
    public class Feedback {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Feedback() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Views.Feedback.Feedback", typeof(Feedback).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Insert your feedback....
        /// </summary>
        public static string FbPlaceholder {
            get {
                return ResourceManager.GetString("FbPlaceholder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximun length of the feedback is 3000 characters.
        /// </summary>
        public static string MaxLength {
            get {
                return ResourceManager.GetString("MaxLength", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Give us your opinion.
        /// </summary>
        public static string Opinion {
            get {
                return ResourceManager.GetString("Opinion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select a feature.
        /// </summary>
        public static string SelectFeature {
            get {
                return ResourceManager.GetString("SelectFeature", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Thanks for taking the time to give us feedback. We will review it and will respond you if it&apos;s possible.
        /// </summary>
        public static string Thanks {
            get {
                return ResourceManager.GetString("Thanks", resourceCulture);
            }
        }
    }
}
