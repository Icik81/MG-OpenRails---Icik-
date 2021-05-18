﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ORTS.cz.aspone.lkpr {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class WebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetMirelSignalsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetLastVersionOperationCompleted;
        
        private System.Threading.SendOrPostCallback SaveMirelSignalOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateMirelVersionOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WebService() {
            this.Url = global::ORTS.Properties.Settings.Default.Menu_cz_aspone_lkpr_WebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetMirelSignalsCompletedEventHandler GetMirelSignalsCompleted;
        
        /// <remarks/>
        public event GetLastVersionCompletedEventHandler GetLastVersionCompleted;
        
        /// <remarks/>
        public event SaveMirelSignalCompletedEventHandler SaveMirelSignalCompleted;
        
        /// <remarks/>
        public event UpdateMirelVersionCompletedEventHandler UpdateMirelVersionCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetMirelSignals", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable GetMirelSignals(string TrackName, string Version) {
            object[] results = this.Invoke("GetMirelSignals", new object[] {
                        TrackName,
                        Version});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public void GetMirelSignalsAsync(string TrackName, string Version) {
            this.GetMirelSignalsAsync(TrackName, Version, null);
        }
        
        /// <remarks/>
        public void GetMirelSignalsAsync(string TrackName, string Version, object userState) {
            if ((this.GetMirelSignalsOperationCompleted == null)) {
                this.GetMirelSignalsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMirelSignalsOperationCompleted);
            }
            this.InvokeAsync("GetMirelSignals", new object[] {
                        TrackName,
                        Version}, this.GetMirelSignalsOperationCompleted, userState);
        }
        
        private void OnGetMirelSignalsOperationCompleted(object arg) {
            if ((this.GetMirelSignalsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMirelSignalsCompleted(this, new GetMirelSignalsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetLastVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetLastVersion(string Track) {
            object[] results = this.Invoke("GetLastVersion", new object[] {
                        Track});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetLastVersionAsync(string Track) {
            this.GetLastVersionAsync(Track, null);
        }
        
        /// <remarks/>
        public void GetLastVersionAsync(string Track, object userState) {
            if ((this.GetLastVersionOperationCompleted == null)) {
                this.GetLastVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLastVersionOperationCompleted);
            }
            this.InvokeAsync("GetLastVersion", new object[] {
                        Track}, this.GetLastVersionOperationCompleted, userState);
        }
        
        private void OnGetLastVersionOperationCompleted(object arg) {
            if ((this.GetLastVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLastVersionCompleted(this, new GetLastVersionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SaveMirelSignal", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SaveMirelSignal(string TrackName, int SectionID, string MirelState, int DatabaseVersion) {
            this.Invoke("SaveMirelSignal", new object[] {
                        TrackName,
                        SectionID,
                        MirelState,
                        DatabaseVersion});
        }
        
        /// <remarks/>
        public void SaveMirelSignalAsync(string TrackName, int SectionID, string MirelState, int DatabaseVersion) {
            this.SaveMirelSignalAsync(TrackName, SectionID, MirelState, DatabaseVersion, null);
        }
        
        /// <remarks/>
        public void SaveMirelSignalAsync(string TrackName, int SectionID, string MirelState, int DatabaseVersion, object userState) {
            if ((this.SaveMirelSignalOperationCompleted == null)) {
                this.SaveMirelSignalOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSaveMirelSignalOperationCompleted);
            }
            this.InvokeAsync("SaveMirelSignal", new object[] {
                        TrackName,
                        SectionID,
                        MirelState,
                        DatabaseVersion}, this.SaveMirelSignalOperationCompleted, userState);
        }
        
        private void OnSaveMirelSignalOperationCompleted(object arg) {
            if ((this.SaveMirelSignalCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SaveMirelSignalCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateMirelVersion", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UpdateMirelVersion(int Version, string Track) {
            this.Invoke("UpdateMirelVersion", new object[] {
                        Version,
                        Track});
        }
        
        /// <remarks/>
        public void UpdateMirelVersionAsync(int Version, string Track) {
            this.UpdateMirelVersionAsync(Version, Track, null);
        }
        
        /// <remarks/>
        public void UpdateMirelVersionAsync(int Version, string Track, object userState) {
            if ((this.UpdateMirelVersionOperationCompleted == null)) {
                this.UpdateMirelVersionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateMirelVersionOperationCompleted);
            }
            this.InvokeAsync("UpdateMirelVersion", new object[] {
                        Version,
                        Track}, this.UpdateMirelVersionOperationCompleted, userState);
        }
        
        private void OnUpdateMirelVersionOperationCompleted(object arg) {
            if ((this.UpdateMirelVersionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateMirelVersionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetMirelSignalsCompletedEventHandler(object sender, GetMirelSignalsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMirelSignalsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetMirelSignalsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataTable Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataTable)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void GetLastVersionCompletedEventHandler(object sender, GetLastVersionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLastVersionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLastVersionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void SaveMirelSignalCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3761.0")]
    public delegate void UpdateMirelVersionCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591