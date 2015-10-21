﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources.Exceptions {
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
    public class Exceptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Exceptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.Exceptions.Exceptions", typeof(Exceptions).Assembly);
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
        ///   Looks up a localized string similar to Sorry, but something went wrong.
        /// </summary>
        public static string ExcServerError {
            get {
                return ResourceManager.GetString("ExcServerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are already in contact.
        /// </summary>
        public static string FriendsAlreadyException {
            get {
                return ResourceManager.GetString("FriendsAlreadyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Date.
        /// </summary>
        public static string InvalidDateTimeException {
            get {
                return ResourceManager.GetString("InvalidDateTimeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid user language.
        /// </summary>
        public static string InvalidUserLanguageException {
            get {
                return ResourceManager.GetString("InvalidUserLanguageException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Language not found.
        /// </summary>
        public static string LanguageNotFoundException {
            get {
                return ResourceManager.GetString("LanguageNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Meetup not found.
        /// </summary>
        public static string MeetupNotFoundException {
            get {
                return ResourceManager.GetString("MeetupNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You do not have access to this room.
        /// </summary>
        public static string NoAccessToRoom {
            get {
                return ResourceManager.GetString("NoAccessToRoom", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, an error has occurred, requested page was not found!.
        /// </summary>
        public static string NotFoundError {
            get {
                return ResourceManager.GetString("NotFoundError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Room does not exist.
        /// </summary>
        public static string RoomNotExist {
            get {
                return ResourceManager.GetString("RoomNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Room not found.
        /// </summary>
        public static string RoomNotFound {
            get {
                return ResourceManager.GetString("RoomNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot make a contact request to yourself.
        /// </summary>
        public static string SelfFriendShipException {
            get {
                return ResourceManager.GetString("SelfFriendShipException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sorry, something didn&apos;t go as expected!.
        /// </summary>
        public static string ServerErrorPageError {
            get {
                return ResourceManager.GetString("ServerErrorPageError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User not found.
        /// </summary>
        public static string UserNotFoundException {
            get {
                return ResourceManager.GetString("UserNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The user is not in any room.
        /// </summary>
        public static string UserNotInAnyRoom {
            get {
                return ResourceManager.GetString("UserNotInAnyRoom", resourceCulture);
            }
        }
    }
}
