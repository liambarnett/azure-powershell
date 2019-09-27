﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.HealthcareApis.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.PowerShell.Cmdlets.HealthcareApis.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Creating CosmosDbConfig.
        /// </summary>
        internal static string createCosmosDbConfiguration {
            get {
                return ResourceManager.GetString("createCosmosDbConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Service.
        /// </summary>
        internal static string createService {
            get {
                return ResourceManager.GetString("createService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid FhirVersion. Valid values are Stu3 and R4..
        /// </summary>
        internal static string createService_InvalidFhirVersionMessage {
            get {
                return ResourceManager.GetString("createService_InvalidFhirVersionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid service kind. Valid values are fhir, fhir-Stu3 and fhir-R4..
        /// </summary>
        internal static string createService_InvalidKindMessage {
            get {
                return ResourceManager.GetString("createService_InvalidKindMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one of the supplied access policy object IDs is invalid. Object ID must be a valid GUID..
        /// </summary>
        internal static string invalidAccessPolicyObjectIdMessage {
            get {
                return ResourceManager.GetString("invalidAccessPolicyObjectIdMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Object Id couldn&apos;t be retrieved from the current context. Please specify at least one accesspolicy object id.
        /// </summary>
        internal static string keyNotFoundExceptionMessage {
            get {
                return ResourceManager.GetString("keyNotFoundExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to User is not logged in to any subscription. Run Connect-AzAccount to login.
        /// </summary>
        internal static string nullPointerExceptionMessage {
            get {
                return ResourceManager.GetString("nullPointerExceptionMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing service.
        /// </summary>
        internal static string RemoveService_ProcessMessage {
            get {
                return ResourceManager.GetString("RemoveService_ProcessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to AllowCorsCredentials and DisableCorsCredentials are mutually exclusive parameters. Please specify only one parameter..
        /// </summary>
        internal static string updatedService_InvalidAllowCorsCredentialsInput {
            get {
                return ResourceManager.GetString("updatedService_InvalidAllowCorsCredentialsInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to EnableSmartProxy and DisableSmartProxy are mutually exclusive parameters. Please specify only one.
        /// </summary>
        internal static string updatedService_InvalidSmartOnProxyInput {
            get {
                return ResourceManager.GetString("updatedService_InvalidSmartOnProxyInput", resourceCulture);
            }
        }
    }
}
