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

namespace TechOnlineMobile.TechOnlineService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_IService1", Namespace="http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getUsersOperationCompleted;
        
        private System.Threading.SendOrPostCallback getLoginUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUserDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback addUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback editUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteUserOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service1() {
            this.Url = "http://localhost:62081/Service1.svc";
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
        public event getUsersCompletedEventHandler getUsersCompleted;
        
        /// <remarks/>
        public event getLoginUserCompletedEventHandler getLoginUserCompleted;
        
        /// <remarks/>
        public event getUserDetailsCompletedEventHandler getUserDetailsCompleted;
        
        /// <remarks/>
        public event addUserCompletedEventHandler addUserCompleted;
        
        /// <remarks/>
        public event editUserCompletedEventHandler editUserCompleted;
        
        /// <remarks/>
        public event deleteUserCompletedEventHandler deleteUserCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/getUsers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/TechOnlineMobileWCF")]
        public UserAccount[] getUsers() {
            object[] results = this.Invoke("getUsers", new object[0]);
            return ((UserAccount[])(results[0]));
        }
        
        /// <remarks/>
        public void getUsersAsync() {
            this.getUsersAsync(null);
        }
        
        /// <remarks/>
        public void getUsersAsync(object userState) {
            if ((this.getUsersOperationCompleted == null)) {
                this.getUsersOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUsersOperationCompleted);
            }
            this.InvokeAsync("getUsers", new object[0], this.getUsersOperationCompleted, userState);
        }
        
        private void OngetUsersOperationCompleted(object arg) {
            if ((this.getUsersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUsersCompleted(this, new getUsersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/getLoginUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void getLoginUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string password, out bool getLoginUserResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool getLoginUserResultSpecified) {
            object[] results = this.Invoke("getLoginUser", new object[] {
                        email,
                        password});
            getLoginUserResult = ((bool)(results[0]));
            getLoginUserResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void getLoginUserAsync(string email, string password) {
            this.getLoginUserAsync(email, password, null);
        }
        
        /// <remarks/>
        public void getLoginUserAsync(string email, string password, object userState) {
            if ((this.getLoginUserOperationCompleted == null)) {
                this.getLoginUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLoginUserOperationCompleted);
            }
            this.InvokeAsync("getLoginUser", new object[] {
                        email,
                        password}, this.getLoginUserOperationCompleted, userState);
        }
        
        private void OngetLoginUserOperationCompleted(object arg) {
            if ((this.getLoginUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLoginUserCompleted(this, new getLoginUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/getUserDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UserAccount getUserDetails(int id, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified) {
            object[] results = this.Invoke("getUserDetails", new object[] {
                        id,
                        idSpecified});
            return ((UserAccount)(results[0]));
        }
        
        /// <remarks/>
        public void getUserDetailsAsync(int id, bool idSpecified) {
            this.getUserDetailsAsync(id, idSpecified, null);
        }
        
        /// <remarks/>
        public void getUserDetailsAsync(int id, bool idSpecified, object userState) {
            if ((this.getUserDetailsOperationCompleted == null)) {
                this.getUserDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUserDetailsOperationCompleted);
            }
            this.InvokeAsync("getUserDetails", new object[] {
                        id,
                        idSpecified}, this.getUserDetailsOperationCompleted, userState);
        }
        
        private void OngetUserDetailsOperationCompleted(object arg) {
            if ((this.getUserDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUserDetailsCompleted(this, new getUserDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/addUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void addUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strSurname, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strEmail, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strphoneNumber, System.DateTime dateOfBirth, [System.Xml.Serialization.XmlIgnoreAttribute()] bool dateOfBirthSpecified, bool isActive, [System.Xml.Serialization.XmlIgnoreAttribute()] bool isActiveSpecified, int roleId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool roleIdSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strPassword, System.DateTime capturedDate, [System.Xml.Serialization.XmlIgnoreAttribute()] bool capturedDateSpecified, int genderId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool genderIdSpecified) {
            this.Invoke("addUser", new object[] {
                        strName,
                        strSurname,
                        strEmail,
                        strphoneNumber,
                        dateOfBirth,
                        dateOfBirthSpecified,
                        isActive,
                        isActiveSpecified,
                        roleId,
                        roleIdSpecified,
                        strPassword,
                        capturedDate,
                        capturedDateSpecified,
                        genderId,
                        genderIdSpecified});
        }
        
        /// <remarks/>
        public void addUserAsync(string strName, string strSurname, string strEmail, string strphoneNumber, System.DateTime dateOfBirth, bool dateOfBirthSpecified, bool isActive, bool isActiveSpecified, int roleId, bool roleIdSpecified, string strPassword, System.DateTime capturedDate, bool capturedDateSpecified, int genderId, bool genderIdSpecified) {
            this.addUserAsync(strName, strSurname, strEmail, strphoneNumber, dateOfBirth, dateOfBirthSpecified, isActive, isActiveSpecified, roleId, roleIdSpecified, strPassword, capturedDate, capturedDateSpecified, genderId, genderIdSpecified, null);
        }
        
        /// <remarks/>
        public void addUserAsync(
                    string strName, 
                    string strSurname, 
                    string strEmail, 
                    string strphoneNumber, 
                    System.DateTime dateOfBirth, 
                    bool dateOfBirthSpecified, 
                    bool isActive, 
                    bool isActiveSpecified, 
                    int roleId, 
                    bool roleIdSpecified, 
                    string strPassword, 
                    System.DateTime capturedDate, 
                    bool capturedDateSpecified, 
                    int genderId, 
                    bool genderIdSpecified, 
                    object userState) {
            if ((this.addUserOperationCompleted == null)) {
                this.addUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddUserOperationCompleted);
            }
            this.InvokeAsync("addUser", new object[] {
                        strName,
                        strSurname,
                        strEmail,
                        strphoneNumber,
                        dateOfBirth,
                        dateOfBirthSpecified,
                        isActive,
                        isActiveSpecified,
                        roleId,
                        roleIdSpecified,
                        strPassword,
                        capturedDate,
                        capturedDateSpecified,
                        genderId,
                        genderIdSpecified}, this.addUserOperationCompleted, userState);
        }
        
        private void OnaddUserOperationCompleted(object arg) {
            if ((this.addUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/editUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void editUser([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strName, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strSurname, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strEmail, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strphoneNumber, System.DateTime dateOfBirth, [System.Xml.Serialization.XmlIgnoreAttribute()] bool dateOfBirthSpecified, bool isActive, [System.Xml.Serialization.XmlIgnoreAttribute()] bool isActiveSpecified, int roleId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool roleIdSpecified, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string strPassword, System.DateTime capturedDate, [System.Xml.Serialization.XmlIgnoreAttribute()] bool capturedDateSpecified, int genderId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool genderIdSpecified) {
            this.Invoke("editUser", new object[] {
                        strName,
                        strSurname,
                        strEmail,
                        strphoneNumber,
                        dateOfBirth,
                        dateOfBirthSpecified,
                        isActive,
                        isActiveSpecified,
                        roleId,
                        roleIdSpecified,
                        strPassword,
                        capturedDate,
                        capturedDateSpecified,
                        genderId,
                        genderIdSpecified});
        }
        
        /// <remarks/>
        public void editUserAsync(string strName, string strSurname, string strEmail, string strphoneNumber, System.DateTime dateOfBirth, bool dateOfBirthSpecified, bool isActive, bool isActiveSpecified, int roleId, bool roleIdSpecified, string strPassword, System.DateTime capturedDate, bool capturedDateSpecified, int genderId, bool genderIdSpecified) {
            this.editUserAsync(strName, strSurname, strEmail, strphoneNumber, dateOfBirth, dateOfBirthSpecified, isActive, isActiveSpecified, roleId, roleIdSpecified, strPassword, capturedDate, capturedDateSpecified, genderId, genderIdSpecified, null);
        }
        
        /// <remarks/>
        public void editUserAsync(
                    string strName, 
                    string strSurname, 
                    string strEmail, 
                    string strphoneNumber, 
                    System.DateTime dateOfBirth, 
                    bool dateOfBirthSpecified, 
                    bool isActive, 
                    bool isActiveSpecified, 
                    int roleId, 
                    bool roleIdSpecified, 
                    string strPassword, 
                    System.DateTime capturedDate, 
                    bool capturedDateSpecified, 
                    int genderId, 
                    bool genderIdSpecified, 
                    object userState) {
            if ((this.editUserOperationCompleted == null)) {
                this.editUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OneditUserOperationCompleted);
            }
            this.InvokeAsync("editUser", new object[] {
                        strName,
                        strSurname,
                        strEmail,
                        strphoneNumber,
                        dateOfBirth,
                        dateOfBirthSpecified,
                        isActive,
                        isActiveSpecified,
                        roleId,
                        roleIdSpecified,
                        strPassword,
                        capturedDate,
                        capturedDateSpecified,
                        genderId,
                        genderIdSpecified}, this.editUserOperationCompleted, userState);
        }
        
        private void OneditUserOperationCompleted(object arg) {
            if ((this.editUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.editUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/deleteUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void deleteUser(int clientId, [System.Xml.Serialization.XmlIgnoreAttribute()] bool clientIdSpecified) {
            this.Invoke("deleteUser", new object[] {
                        clientId,
                        clientIdSpecified});
        }
        
        /// <remarks/>
        public void deleteUserAsync(int clientId, bool clientIdSpecified) {
            this.deleteUserAsync(clientId, clientIdSpecified, null);
        }
        
        /// <remarks/>
        public void deleteUserAsync(int clientId, bool clientIdSpecified, object userState) {
            if ((this.deleteUserOperationCompleted == null)) {
                this.deleteUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteUserOperationCompleted);
            }
            this.InvokeAsync("deleteUser", new object[] {
                        clientId,
                        clientIdSpecified}, this.deleteUserOperationCompleted, userState);
        }
        
        private void OndeleteUserOperationCompleted(object arg) {
            if ((this.deleteUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1099.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/TechOnlineMobileWCF")]
    public partial class UserAccount {
        
        private System.Nullable<bool> activeField;
        
        private bool activeFieldSpecified;
        
        private System.Nullable<System.DateTime> capturedDateField;
        
        private bool capturedDateFieldSpecified;
        
        private System.Nullable<System.DateTime> dateOfBirthField;
        
        private bool dateOfBirthFieldSpecified;
        
        private string emailField;
        
        private string firstNameField;
        
        private System.Nullable<int> genderIdField;
        
        private bool genderIdFieldSpecified;
        
        private string lastNameField;
        
        private string passwordField;
        
        private string phoneNumberField;
        
        private System.Nullable<int> roleIdField;
        
        private bool roleIdFieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<bool> Active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveSpecified {
            get {
                return this.activeFieldSpecified;
            }
            set {
                this.activeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> CapturedDate {
            get {
                return this.capturedDateField;
            }
            set {
                this.capturedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapturedDateSpecified {
            get {
                return this.capturedDateFieldSpecified;
            }
            set {
                this.capturedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> DateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                this.dateOfBirthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateOfBirthSpecified {
            get {
                return this.dateOfBirthFieldSpecified;
            }
            set {
                this.dateOfBirthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string FirstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> GenderId {
            get {
                return this.genderIdField;
            }
            set {
                this.genderIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GenderIdSpecified {
            get {
                return this.genderIdFieldSpecified;
            }
            set {
                this.genderIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string PhoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<int> RoleId {
            get {
                return this.roleIdField;
            }
            set {
                this.roleIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RoleIdSpecified {
            get {
                return this.roleIdFieldSpecified;
            }
            set {
                this.roleIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified {
            get {
                return this.idFieldSpecified;
            }
            set {
                this.idFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void getUsersCompletedEventHandler(object sender, getUsersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UserAccount[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UserAccount[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void getLoginUserCompletedEventHandler(object sender, getLoginUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLoginUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getLoginUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool getLoginUserResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool getLoginUserResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void getUserDetailsCompletedEventHandler(object sender, getUserDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUserDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUserDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public UserAccount Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((UserAccount)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void addUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void editUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1099.0")]
    public delegate void deleteUserCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591