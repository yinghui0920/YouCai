﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoansItemMvc.ServiceReference4 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCUserInfoData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCUserInfoData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int U_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string U_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string U_PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string U_PhoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int U_Id {
            get {
                return this.U_IdField;
            }
            set {
                if ((this.U_IdField.Equals(value) != true)) {
                    this.U_IdField = value;
                    this.RaisePropertyChanged("U_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string U_Name {
            get {
                return this.U_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.U_NameField, value) != true)) {
                    this.U_NameField = value;
                    this.RaisePropertyChanged("U_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string U_Password {
            get {
                return this.U_PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.U_PasswordField, value) != true)) {
                    this.U_PasswordField = value;
                    this.RaisePropertyChanged("U_Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string U_Phone {
            get {
                return this.U_PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.U_PhoneField, value) != true)) {
                    this.U_PhoneField = value;
                    this.RaisePropertyChanged("U_Phone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference4.IGetLogin")]
    public interface IGetLogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetLogin/DoWork", ReplyAction="http://tempuri.org/IGetLogin/DoWorkResponse")]
        bool DoWork(LoansItemMvc.ServiceReference4.YCUserInfoData yCUserLogin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGetLogin/DoWork", ReplyAction="http://tempuri.org/IGetLogin/DoWorkResponse")]
        System.Threading.Tasks.Task<bool> DoWorkAsync(LoansItemMvc.ServiceReference4.YCUserInfoData yCUserLogin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetLoginChannel : LoansItemMvc.ServiceReference4.IGetLogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetLoginClient : System.ServiceModel.ClientBase<LoansItemMvc.ServiceReference4.IGetLogin>, LoansItemMvc.ServiceReference4.IGetLogin {
        
        public GetLoginClient() {
        }
        
        public GetLoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetLoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetLoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetLoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool DoWork(LoansItemMvc.ServiceReference4.YCUserInfoData yCUserLogin) {
            return base.Channel.DoWork(yCUserLogin);
        }
        
        public System.Threading.Tasks.Task<bool> DoWorkAsync(LoansItemMvc.ServiceReference4.YCUserInfoData yCUserLogin) {
            return base.Channel.DoWorkAsync(yCUserLogin);
        }
    }
}