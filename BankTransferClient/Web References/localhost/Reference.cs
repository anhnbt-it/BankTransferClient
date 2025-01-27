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

namespace BankTransferClient.localhost {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BankTransferSoap", Namespace="http://tempuri.org/")]
    public partial class BankTransfer : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback HelloWorldOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckUserLoginOperationCompleted;
        
        private System.Threading.SendOrPostCallback CheckAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAccountsByUserIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUsersInforOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUsersInforByAccountsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetTransactionLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback TransferOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BankTransfer() {
            this.Url = global::BankTransferClient.Properties.Settings.Default.BankTransferClient_localhost_BankTransfer;
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
        public event HelloWorldCompletedEventHandler HelloWorldCompleted;
        
        /// <remarks/>
        public event CheckUserLoginCompletedEventHandler CheckUserLoginCompleted;
        
        /// <remarks/>
        public event CheckAccountCompletedEventHandler CheckAccountCompleted;
        
        /// <remarks/>
        public event GetAccountsByUserIDCompletedEventHandler GetAccountsByUserIDCompleted;
        
        /// <remarks/>
        public event GetUsersInforCompletedEventHandler GetUsersInforCompleted;
        
        /// <remarks/>
        public event GetUsersInforByAccountsCompletedEventHandler GetUsersInforByAccountsCompleted;
        
        /// <remarks/>
        public event GetTransactionLogCompletedEventHandler GetTransactionLogCompleted;
        
        /// <remarks/>
        public event TransferCompletedEventHandler TransferCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/HelloWorld", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string HelloWorld() {
            object[] results = this.Invoke("HelloWorld", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void HelloWorldAsync() {
            this.HelloWorldAsync(null);
        }
        
        /// <remarks/>
        public void HelloWorldAsync(object userState) {
            if ((this.HelloWorldOperationCompleted == null)) {
                this.HelloWorldOperationCompleted = new System.Threading.SendOrPostCallback(this.OnHelloWorldOperationCompleted);
            }
            this.InvokeAsync("HelloWorld", new object[0], this.HelloWorldOperationCompleted, userState);
        }
        
        private void OnHelloWorldOperationCompleted(object arg) {
            if ((this.HelloWorldCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.HelloWorldCompleted(this, new HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckUserLogin", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckUserLogin(string Username, string Password, out int UserID) {
            object[] results = this.Invoke("CheckUserLogin", new object[] {
                        Username,
                        Password});
            UserID = ((int)(results[1]));
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckUserLoginAsync(string Username, string Password) {
            this.CheckUserLoginAsync(Username, Password, null);
        }
        
        /// <remarks/>
        public void CheckUserLoginAsync(string Username, string Password, object userState) {
            if ((this.CheckUserLoginOperationCompleted == null)) {
                this.CheckUserLoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckUserLoginOperationCompleted);
            }
            this.InvokeAsync("CheckUserLogin", new object[] {
                        Username,
                        Password}, this.CheckUserLoginOperationCompleted, userState);
        }
        
        private void OnCheckUserLoginOperationCompleted(object arg) {
            if ((this.CheckUserLoginCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckUserLoginCompleted(this, new CheckUserLoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool CheckAccount(int AccountIDReceiver, int AccountIDRequest) {
            object[] results = this.Invoke("CheckAccount", new object[] {
                        AccountIDReceiver,
                        AccountIDRequest});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void CheckAccountAsync(int AccountIDReceiver, int AccountIDRequest) {
            this.CheckAccountAsync(AccountIDReceiver, AccountIDRequest, null);
        }
        
        /// <remarks/>
        public void CheckAccountAsync(int AccountIDReceiver, int AccountIDRequest, object userState) {
            if ((this.CheckAccountOperationCompleted == null)) {
                this.CheckAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCheckAccountOperationCompleted);
            }
            this.InvokeAsync("CheckAccount", new object[] {
                        AccountIDReceiver,
                        AccountIDRequest}, this.CheckAccountOperationCompleted, userState);
        }
        
        private void OnCheckAccountOperationCompleted(object arg) {
            if ((this.CheckAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CheckAccountCompleted(this, new CheckAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAccountsByUserID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetAccountsByUserID(int userID) {
            object[] results = this.Invoke("GetAccountsByUserID", new object[] {
                        userID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetAccountsByUserIDAsync(int userID) {
            this.GetAccountsByUserIDAsync(userID, null);
        }
        
        /// <remarks/>
        public void GetAccountsByUserIDAsync(int userID, object userState) {
            if ((this.GetAccountsByUserIDOperationCompleted == null)) {
                this.GetAccountsByUserIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAccountsByUserIDOperationCompleted);
            }
            this.InvokeAsync("GetAccountsByUserID", new object[] {
                        userID}, this.GetAccountsByUserIDOperationCompleted, userState);
        }
        
        private void OnGetAccountsByUserIDOperationCompleted(object arg) {
            if ((this.GetAccountsByUserIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAccountsByUserIDCompleted(this, new GetAccountsByUserIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUsersInfor", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetUsersInfor(int userID) {
            object[] results = this.Invoke("GetUsersInfor", new object[] {
                        userID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetUsersInforAsync(int userID) {
            this.GetUsersInforAsync(userID, null);
        }
        
        /// <remarks/>
        public void GetUsersInforAsync(int userID, object userState) {
            if ((this.GetUsersInforOperationCompleted == null)) {
                this.GetUsersInforOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUsersInforOperationCompleted);
            }
            this.InvokeAsync("GetUsersInfor", new object[] {
                        userID}, this.GetUsersInforOperationCompleted, userState);
        }
        
        private void OnGetUsersInforOperationCompleted(object arg) {
            if ((this.GetUsersInforCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUsersInforCompleted(this, new GetUsersInforCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUsersInforByAccounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetUsersInforByAccounts(int accountID) {
            object[] results = this.Invoke("GetUsersInforByAccounts", new object[] {
                        accountID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetUsersInforByAccountsAsync(int accountID) {
            this.GetUsersInforByAccountsAsync(accountID, null);
        }
        
        /// <remarks/>
        public void GetUsersInforByAccountsAsync(int accountID, object userState) {
            if ((this.GetUsersInforByAccountsOperationCompleted == null)) {
                this.GetUsersInforByAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUsersInforByAccountsOperationCompleted);
            }
            this.InvokeAsync("GetUsersInforByAccounts", new object[] {
                        accountID}, this.GetUsersInforByAccountsOperationCompleted, userState);
        }
        
        private void OnGetUsersInforByAccountsOperationCompleted(object arg) {
            if ((this.GetUsersInforByAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUsersInforByAccountsCompleted(this, new GetUsersInforByAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTransactionLog", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetTransactionLog(int AccountID) {
            object[] results = this.Invoke("GetTransactionLog", new object[] {
                        AccountID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetTransactionLogAsync(int AccountID) {
            this.GetTransactionLogAsync(AccountID, null);
        }
        
        /// <remarks/>
        public void GetTransactionLogAsync(int AccountID, object userState) {
            if ((this.GetTransactionLogOperationCompleted == null)) {
                this.GetTransactionLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTransactionLogOperationCompleted);
            }
            this.InvokeAsync("GetTransactionLog", new object[] {
                        AccountID}, this.GetTransactionLogOperationCompleted, userState);
        }
        
        private void OnGetTransactionLogOperationCompleted(object arg) {
            if ((this.GetTransactionLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTransactionLogCompleted(this, new GetTransactionLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Transfer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Transfer(int requestID, int receiverID, decimal amount, string Reason) {
            object[] results = this.Invoke("Transfer", new object[] {
                        requestID,
                        receiverID,
                        amount,
                        Reason});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void TransferAsync(int requestID, int receiverID, decimal amount, string Reason) {
            this.TransferAsync(requestID, receiverID, amount, Reason, null);
        }
        
        /// <remarks/>
        public void TransferAsync(int requestID, int receiverID, decimal amount, string Reason, object userState) {
            if ((this.TransferOperationCompleted == null)) {
                this.TransferOperationCompleted = new System.Threading.SendOrPostCallback(this.OnTransferOperationCompleted);
            }
            this.InvokeAsync("Transfer", new object[] {
                        requestID,
                        receiverID,
                        amount,
                        Reason}, this.TransferOperationCompleted, userState);
        }
        
        private void OnTransferOperationCompleted(object arg) {
            if ((this.TransferCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.TransferCompleted(this, new TransferCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void HelloWorldCompletedEventHandler(object sender, HelloWorldCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class HelloWorldCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal HelloWorldCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckUserLoginCompletedEventHandler(object sender, CheckUserLoginCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckUserLoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckUserLoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public int UserID {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void CheckAccountCompletedEventHandler(object sender, CheckAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CheckAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CheckAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetAccountsByUserIDCompletedEventHandler(object sender, GetAccountsByUserIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAccountsByUserIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAccountsByUserIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUsersInforCompletedEventHandler(object sender, GetUsersInforCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUsersInforCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUsersInforCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetUsersInforByAccountsCompletedEventHandler(object sender, GetUsersInforByAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUsersInforByAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUsersInforByAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetTransactionLogCompletedEventHandler(object sender, GetTransactionLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTransactionLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTransactionLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void TransferCompletedEventHandler(object sender, TransferCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class TransferCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal TransferCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591