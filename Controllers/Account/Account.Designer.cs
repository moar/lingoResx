﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Controllers.Account {
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
    public class Account {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Account() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Controllers.Account.Account", typeof(Account).Assembly);
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
        ///   Looks up a localized string similar to You have to confirm your email address. Check your inbox!.
        /// </summary>
        public static string AccountConfirmEmail {
            get {
                return ResourceManager.GetString("AccountConfirmEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The email address is already taken.
        /// </summary>
        public static string ExistingEmail {
            get {
                return ResourceManager.GetString("ExistingEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The external login was removed..
        /// </summary>
        public static string ExternalLoginRemoved {
            get {
                return ResourceManager.GetString("ExternalLoginRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid username or password..
        /// </summary>
        public static string InvalidUserPw {
            get {
                return ResourceManager.GetString("InvalidUserPw", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred..
        /// </summary>
        public static string ManageError {
            get {
                return ResourceManager.GetString("ManageError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user either does not exist or is not confirmed.
        /// </summary>
        public static string NotExistingUnconfirmed {
            get {
                return ResourceManager.GetString("NotExistingUnconfirmed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password has been changed..
        /// </summary>
        public static string PwChanged {
            get {
                return ResourceManager.GetString("PwChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your password has been set..
        /// </summary>
        public static string PwSet {
            get {
                return ResourceManager.GetString("PwSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you requested to reset your password check your email inbox and follow the instructions.
        /// </summary>
        public static string ResetPasswordError {
            get {
                return ResourceManager.GetString("ResetPasswordError", resourceCulture);
            }
        }
    }
}
