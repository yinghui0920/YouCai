﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoansItemMvc.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCIdentityTableData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCIdentityTableData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int I_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string I_NameField;
        
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
        public int I_Id {
            get {
                return this.I_IdField;
            }
            set {
                if ((this.I_IdField.Equals(value) != true)) {
                    this.I_IdField = value;
                    this.RaisePropertyChanged("I_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string I_Name {
            get {
                return this.I_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.I_NameField, value) != true)) {
                    this.I_NameField = value;
                    this.RaisePropertyChanged("I_Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCloansGoalData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCloansGoalData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IG_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IG_NameField;
        
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
        public int IG_Id {
            get {
                return this.IG_IdField;
            }
            set {
                if ((this.IG_IdField.Equals(value) != true)) {
                    this.IG_IdField = value;
                    this.RaisePropertyChanged("IG_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IG_Name {
            get {
                return this.IG_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.IG_NameField, value) != true)) {
                    this.IG_NameField = value;
                    this.RaisePropertyChanged("IG_Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCLoanTypeData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCLoanTypeData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LT_GoalIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LT_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LT_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LT_PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LT_TraitField;
        
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
        public string LT_GoalID {
            get {
                return this.LT_GoalIDField;
            }
            set {
                if ((object.ReferenceEquals(this.LT_GoalIDField, value) != true)) {
                    this.LT_GoalIDField = value;
                    this.RaisePropertyChanged("LT_GoalID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LT_Id {
            get {
                return this.LT_IdField;
            }
            set {
                if ((this.LT_IdField.Equals(value) != true)) {
                    this.LT_IdField = value;
                    this.RaisePropertyChanged("LT_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LT_Name {
            get {
                return this.LT_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.LT_NameField, value) != true)) {
                    this.LT_NameField = value;
                    this.RaisePropertyChanged("LT_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LT_Picture {
            get {
                return this.LT_PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.LT_PictureField, value) != true)) {
                    this.LT_PictureField = value;
                    this.RaisePropertyChanged("LT_Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LT_Trait {
            get {
                return this.LT_TraitField;
            }
            set {
                if ((object.ReferenceEquals(this.LT_TraitField, value) != true)) {
                    this.LT_TraitField = value;
                    this.RaisePropertyChanged("LT_Trait");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCAdminInfoData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCAdminInfoData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int A_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string A_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string A_PasswordField;
        
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
        public int A_Id {
            get {
                return this.A_IdField;
            }
            set {
                if ((this.A_IdField.Equals(value) != true)) {
                    this.A_IdField = value;
                    this.RaisePropertyChanged("A_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string A_Name {
            get {
                return this.A_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.A_NameField, value) != true)) {
                    this.A_NameField = value;
                    this.RaisePropertyChanged("A_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string A_Password {
            get {
                return this.A_PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.A_PasswordField, value) != true)) {
                    this.A_PasswordField = value;
                    this.RaisePropertyChanged("A_Password");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserDetailAndMyBill", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class UserDetailAndMyBill : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MB_AllMoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Ud_NowDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string YetTimeField;
        
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
        public string MB_AllMoney {
            get {
                return this.MB_AllMoneyField;
            }
            set {
                if ((object.ReferenceEquals(this.MB_AllMoneyField, value) != true)) {
                    this.MB_AllMoneyField = value;
                    this.RaisePropertyChanged("MB_AllMoney");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_Name {
            get {
                return this.Ud_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_NameField, value) != true)) {
                    this.Ud_NameField = value;
                    this.RaisePropertyChanged("Ud_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Ud_NowDate {
            get {
                return this.Ud_NowDateField;
            }
            set {
                if ((this.Ud_NowDateField.Equals(value) != true)) {
                    this.Ud_NowDateField = value;
                    this.RaisePropertyChanged("Ud_NowDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_Phone {
            get {
                return this.Ud_PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_PhoneField, value) != true)) {
                    this.Ud_PhoneField = value;
                    this.RaisePropertyChanged("Ud_Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string YetTime {
            get {
                return this.YetTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.YetTimeField, value) != true)) {
                    this.YetTimeField = value;
                    this.RaisePropertyChanged("YetTime");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCUserDetailsData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCUserDetailsData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LoansItemMvc.ServiceReference2.YCMyBillData MyBillIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Ud_AuditIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_BillIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_GoalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_IDCardPicField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_IdentityIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Ud_NowDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Ud_RemarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Ud_SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Ud_UserIdField;
        
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
        public LoansItemMvc.ServiceReference2.YCMyBillData MyBillId {
            get {
                return this.MyBillIdField;
            }
            set {
                if ((object.ReferenceEquals(this.MyBillIdField, value) != true)) {
                    this.MyBillIdField = value;
                    this.RaisePropertyChanged("MyBillId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Ud_AuditId {
            get {
                return this.Ud_AuditIdField;
            }
            set {
                if ((this.Ud_AuditIdField.Equals(value) != true)) {
                    this.Ud_AuditIdField = value;
                    this.RaisePropertyChanged("Ud_AuditId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_BillId {
            get {
                return this.Ud_BillIdField;
            }
            set {
                if ((this.Ud_BillIdField.Equals(value) != true)) {
                    this.Ud_BillIdField = value;
                    this.RaisePropertyChanged("Ud_BillId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_Goal {
            get {
                return this.Ud_GoalField;
            }
            set {
                if ((this.Ud_GoalField.Equals(value) != true)) {
                    this.Ud_GoalField = value;
                    this.RaisePropertyChanged("Ud_Goal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_IDCardPic {
            get {
                return this.Ud_IDCardPicField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_IDCardPicField, value) != true)) {
                    this.Ud_IDCardPicField = value;
                    this.RaisePropertyChanged("Ud_IDCardPic");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_Id {
            get {
                return this.Ud_IdField;
            }
            set {
                if ((this.Ud_IdField.Equals(value) != true)) {
                    this.Ud_IdField = value;
                    this.RaisePropertyChanged("Ud_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_IdentityID {
            get {
                return this.Ud_IdentityIDField;
            }
            set {
                if ((this.Ud_IdentityIDField.Equals(value) != true)) {
                    this.Ud_IdentityIDField = value;
                    this.RaisePropertyChanged("Ud_IdentityID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_Money {
            get {
                return this.Ud_MoneyField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_MoneyField, value) != true)) {
                    this.Ud_MoneyField = value;
                    this.RaisePropertyChanged("Ud_Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_Name {
            get {
                return this.Ud_NameField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_NameField, value) != true)) {
                    this.Ud_NameField = value;
                    this.RaisePropertyChanged("Ud_Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Ud_NowDate {
            get {
                return this.Ud_NowDateField;
            }
            set {
                if ((this.Ud_NowDateField.Equals(value) != true)) {
                    this.Ud_NowDateField = value;
                    this.RaisePropertyChanged("Ud_NowDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_Phone {
            get {
                return this.Ud_PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_PhoneField, value) != true)) {
                    this.Ud_PhoneField = value;
                    this.RaisePropertyChanged("Ud_Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ud_Remark {
            get {
                return this.Ud_RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.Ud_RemarkField, value) != true)) {
                    this.Ud_RemarkField = value;
                    this.RaisePropertyChanged("Ud_Remark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Ud_Sex {
            get {
                return this.Ud_SexField;
            }
            set {
                if ((this.Ud_SexField.Equals(value) != true)) {
                    this.Ud_SexField = value;
                    this.RaisePropertyChanged("Ud_Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_Time {
            get {
                return this.Ud_TimeField;
            }
            set {
                if ((this.Ud_TimeField.Equals(value) != true)) {
                    this.Ud_TimeField = value;
                    this.RaisePropertyChanged("Ud_Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_Type {
            get {
                return this.Ud_TypeField;
            }
            set {
                if ((this.Ud_TypeField.Equals(value) != true)) {
                    this.Ud_TypeField = value;
                    this.RaisePropertyChanged("Ud_Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ud_UserId {
            get {
                return this.Ud_UserIdField;
            }
            set {
                if ((this.Ud_UserIdField.Equals(value) != true)) {
                    this.Ud_UserIdField = value;
                    this.RaisePropertyChanged("Ud_UserId");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="YCMyBillData", Namespace="http://schemas.datacontract.org/2004/07/MyDome.Model")]
    [System.SerializableAttribute()]
    public partial class YCMyBillData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MB_AllMoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MB_IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MB_InterestField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MB_LastDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MB_MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MB_MonthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime MB_NowDateField;
        
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
        public string MB_AllMoney {
            get {
                return this.MB_AllMoneyField;
            }
            set {
                if ((object.ReferenceEquals(this.MB_AllMoneyField, value) != true)) {
                    this.MB_AllMoneyField = value;
                    this.RaisePropertyChanged("MB_AllMoney");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MB_Id {
            get {
                return this.MB_IdField;
            }
            set {
                if ((this.MB_IdField.Equals(value) != true)) {
                    this.MB_IdField = value;
                    this.RaisePropertyChanged("MB_Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MB_Interest {
            get {
                return this.MB_InterestField;
            }
            set {
                if ((object.ReferenceEquals(this.MB_InterestField, value) != true)) {
                    this.MB_InterestField = value;
                    this.RaisePropertyChanged("MB_Interest");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime MB_LastDate {
            get {
                return this.MB_LastDateField;
            }
            set {
                if ((this.MB_LastDateField.Equals(value) != true)) {
                    this.MB_LastDateField = value;
                    this.RaisePropertyChanged("MB_LastDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MB_Money {
            get {
                return this.MB_MoneyField;
            }
            set {
                if ((object.ReferenceEquals(this.MB_MoneyField, value) != true)) {
                    this.MB_MoneyField = value;
                    this.RaisePropertyChanged("MB_Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MB_Month {
            get {
                return this.MB_MonthField;
            }
            set {
                if ((object.ReferenceEquals(this.MB_MonthField, value) != true)) {
                    this.MB_MonthField = value;
                    this.RaisePropertyChanged("MB_Month");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime MB_NowDate {
            get {
                return this.MB_NowDateField;
            }
            set {
                if ((this.MB_NowDateField.Equals(value) != true)) {
                    this.MB_NowDateField = value;
                    this.RaisePropertyChanged("MB_NowDate");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IGet")]
    public interface IGet {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkTable", ReplyAction="http://tempuri.org/IGet/DoWorkTableResponse")]
        LoansItemMvc.ServiceReference2.YCIdentityTableData[] DoWorkTable(LoansItemMvc.ServiceReference2.YCIdentityTableData t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkTable", ReplyAction="http://tempuri.org/IGet/DoWorkTableResponse")]
        System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.YCIdentityTableData[]> DoWorkTableAsync(LoansItemMvc.ServiceReference2.YCIdentityTableData t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkGoal", ReplyAction="http://tempuri.org/IGet/DoWorkGoalResponse")]
        LoansItemMvc.ServiceReference2.YCloansGoalData[] DoWorkGoal(LoansItemMvc.ServiceReference2.YCloansGoalData yCloans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkGoal", ReplyAction="http://tempuri.org/IGet/DoWorkGoalResponse")]
        System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.YCloansGoalData[]> DoWorkGoalAsync(LoansItemMvc.ServiceReference2.YCloansGoalData yCloans);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkType", ReplyAction="http://tempuri.org/IGet/DoWorkTypeResponse")]
        LoansItemMvc.ServiceReference2.YCLoanTypeData[] DoWorkType(LoansItemMvc.ServiceReference2.YCLoanTypeData type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkType", ReplyAction="http://tempuri.org/IGet/DoWorkTypeResponse")]
        System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.YCLoanTypeData[]> DoWorkTypeAsync(LoansItemMvc.ServiceReference2.YCLoanTypeData type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkAdmin", ReplyAction="http://tempuri.org/IGet/DoWorkAdminResponse")]
        bool DoWorkAdmin(LoansItemMvc.ServiceReference2.YCAdminInfoData adminInfoData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/DoWorkAdmin", ReplyAction="http://tempuri.org/IGet/DoWorkAdminResponse")]
        System.Threading.Tasks.Task<bool> DoWorkAdminAsync(LoansItemMvc.ServiceReference2.YCAdminInfoData adminInfoData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/GetUserInfoAndMyBill", ReplyAction="http://tempuri.org/IGet/GetUserInfoAndMyBillResponse")]
        LoansItemMvc.ServiceReference2.UserDetailAndMyBill GetUserInfoAndMyBill(string Ud_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/GetUserInfoAndMyBill", ReplyAction="http://tempuri.org/IGet/GetUserInfoAndMyBillResponse")]
        System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.UserDetailAndMyBill> GetUserInfoAndMyBillAsync(string Ud_Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/Moeney", ReplyAction="http://tempuri.org/IGet/MoeneyResponse")]
        double Moeney(LoansItemMvc.ServiceReference2.YCUserDetailsData data);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGet/Moeney", ReplyAction="http://tempuri.org/IGet/MoeneyResponse")]
        System.Threading.Tasks.Task<double> MoeneyAsync(LoansItemMvc.ServiceReference2.YCUserDetailsData data);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGetChannel : LoansItemMvc.ServiceReference2.IGet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetClient : System.ServiceModel.ClientBase<LoansItemMvc.ServiceReference2.IGet>, LoansItemMvc.ServiceReference2.IGet {
        
        public GetClient() {
        }
        
        public GetClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GetClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GetClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LoansItemMvc.ServiceReference2.YCIdentityTableData[] DoWorkTable(LoansItemMvc.ServiceReference2.YCIdentityTableData t) {
            return base.Channel.DoWorkTable(t);
        }
        
        public System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.YCIdentityTableData[]> DoWorkTableAsync(LoansItemMvc.ServiceReference2.YCIdentityTableData t) {
            return base.Channel.DoWorkTableAsync(t);
        }
        
        public LoansItemMvc.ServiceReference2.YCloansGoalData[] DoWorkGoal(LoansItemMvc.ServiceReference2.YCloansGoalData yCloans) {
            return base.Channel.DoWorkGoal(yCloans);
        }
        
        public System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.YCloansGoalData[]> DoWorkGoalAsync(LoansItemMvc.ServiceReference2.YCloansGoalData yCloans) {
            return base.Channel.DoWorkGoalAsync(yCloans);
        }
        
        public LoansItemMvc.ServiceReference2.YCLoanTypeData[] DoWorkType(LoansItemMvc.ServiceReference2.YCLoanTypeData type) {
            return base.Channel.DoWorkType(type);
        }
        
        public System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.YCLoanTypeData[]> DoWorkTypeAsync(LoansItemMvc.ServiceReference2.YCLoanTypeData type) {
            return base.Channel.DoWorkTypeAsync(type);
        }
        
        public bool DoWorkAdmin(LoansItemMvc.ServiceReference2.YCAdminInfoData adminInfoData) {
            return base.Channel.DoWorkAdmin(adminInfoData);
        }
        
        public System.Threading.Tasks.Task<bool> DoWorkAdminAsync(LoansItemMvc.ServiceReference2.YCAdminInfoData adminInfoData) {
            return base.Channel.DoWorkAdminAsync(adminInfoData);
        }
        
        public LoansItemMvc.ServiceReference2.UserDetailAndMyBill GetUserInfoAndMyBill(string Ud_Name) {
            return base.Channel.GetUserInfoAndMyBill(Ud_Name);
        }
        
        public System.Threading.Tasks.Task<LoansItemMvc.ServiceReference2.UserDetailAndMyBill> GetUserInfoAndMyBillAsync(string Ud_Name) {
            return base.Channel.GetUserInfoAndMyBillAsync(Ud_Name);
        }
        
        public double Moeney(LoansItemMvc.ServiceReference2.YCUserDetailsData data) {
            return base.Channel.Moeney(data);
        }
        
        public System.Threading.Tasks.Task<double> MoeneyAsync(LoansItemMvc.ServiceReference2.YCUserDetailsData data) {
            return base.Channel.MoeneyAsync(data);
        }
    }
}
