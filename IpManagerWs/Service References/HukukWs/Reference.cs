﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IpManagerWs.HukukWs {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HsResponseOfstring", Namespace="http://schemas.datacontract.org/2004/07/IpManagerWs.Model")]
    [System.SerializableAttribute()]
    public partial class HsResponseOfstring : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Messagek__BackingFieldField;
        
        private string Operationk__BackingFieldField;
        
        private IpManagerWs.HukukWs.Statu Statuk__BackingFieldField;
        
        private string[] genericListk__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Message>k__BackingField", IsRequired=true)]
        public string Messagek__BackingField {
            get {
                return this.Messagek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Messagek__BackingFieldField, value) != true)) {
                    this.Messagek__BackingFieldField = value;
                    this.RaisePropertyChanged("Messagek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Operation>k__BackingField", IsRequired=true)]
        public string Operationk__BackingField {
            get {
                return this.Operationk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Operationk__BackingFieldField, value) != true)) {
                    this.Operationk__BackingFieldField = value;
                    this.RaisePropertyChanged("Operationk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Statu>k__BackingField", IsRequired=true)]
        public IpManagerWs.HukukWs.Statu Statuk__BackingField {
            get {
                return this.Statuk__BackingFieldField;
            }
            set {
                if ((this.Statuk__BackingFieldField.Equals(value) != true)) {
                    this.Statuk__BackingFieldField = value;
                    this.RaisePropertyChanged("Statuk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<genericList>k__BackingField", IsRequired=true)]
        public string[] genericListk__BackingField {
            get {
                return this.genericListk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.genericListk__BackingFieldField, value) != true)) {
                    this.genericListk__BackingFieldField = value;
                    this.RaisePropertyChanged("genericListk__BackingField");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Statu", Namespace="http://schemas.datacontract.org/2004/07/IpManagerWs.Model")]
    public enum Statu : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        fail = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetMattersResponse", Namespace="http://schemas.datacontract.org/2004/07/IpManagerWs.Model")]
    [System.SerializableAttribute()]
    public partial class GetMattersResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IpManagerWs.HukukWs.Matter[] MattersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IpManagerWs.HukukWs.Statu StatuField;
        
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
        public IpManagerWs.HukukWs.Matter[] Matters {
            get {
                return this.MattersField;
            }
            set {
                if ((object.ReferenceEquals(this.MattersField, value) != true)) {
                    this.MattersField = value;
                    this.RaisePropertyChanged("Matters");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation {
            get {
                return this.OperationField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationField, value) != true)) {
                    this.OperationField = value;
                    this.RaisePropertyChanged("Operation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IpManagerWs.HukukWs.Statu Statu {
            get {
                return this.StatuField;
            }
            set {
                if ((this.StatuField.Equals(value) != true)) {
                    this.StatuField = value;
                    this.RaisePropertyChanged("Statu");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Matter", Namespace="http://schemas.datacontract.org/2004/07/IpManagerWs.Model")]
    [System.SerializableAttribute()]
    public partial class Matter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DevirKaydiVark__BackingFieldField;
        
        private string DevirTarihik__BackingFieldField;
        
        private int DevirTutariBirimiIDk__BackingFieldField;
        
        private double DevirTutarik__BackingFieldField;
        
        private double DevredenSurek__BackingFieldField;
        
        private int IDk__BackingFieldField;
        
        private string KapanmisProjek__BackingFieldField;
        
        private int MusteriIDk__BackingFieldField;
        
        private string Notlark__BackingFieldField;
        
        private double OzelDovizKuru1k__BackingFieldField;
        
        private double OzelDovizKuru2k__BackingFieldField;
        
        private string OzelDovizKuruVark__BackingFieldField;
        
        private string ProjeAdik__BackingFieldField;
        
        private string ProjeBaslangick__BackingFieldField;
        
        private string ProjeBitisk__BackingFieldField;
        
        private string ProjeKoduk__BackingFieldField;
        
        private int ProjeTipiIDk__BackingFieldField;
        
        private string VeriGirisDilik__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DevirKaydiVar>k__BackingField", IsRequired=true)]
        public string DevirKaydiVark__BackingField {
            get {
                return this.DevirKaydiVark__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.DevirKaydiVark__BackingFieldField, value) != true)) {
                    this.DevirKaydiVark__BackingFieldField = value;
                    this.RaisePropertyChanged("DevirKaydiVark__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DevirTarihi>k__BackingField", IsRequired=true)]
        public string DevirTarihik__BackingField {
            get {
                return this.DevirTarihik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.DevirTarihik__BackingFieldField, value) != true)) {
                    this.DevirTarihik__BackingFieldField = value;
                    this.RaisePropertyChanged("DevirTarihik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DevirTutariBirimiID>k__BackingField", IsRequired=true)]
        public int DevirTutariBirimiIDk__BackingField {
            get {
                return this.DevirTutariBirimiIDk__BackingFieldField;
            }
            set {
                if ((this.DevirTutariBirimiIDk__BackingFieldField.Equals(value) != true)) {
                    this.DevirTutariBirimiIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("DevirTutariBirimiIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DevirTutari>k__BackingField", IsRequired=true)]
        public double DevirTutarik__BackingField {
            get {
                return this.DevirTutarik__BackingFieldField;
            }
            set {
                if ((this.DevirTutarik__BackingFieldField.Equals(value) != true)) {
                    this.DevirTutarik__BackingFieldField = value;
                    this.RaisePropertyChanged("DevirTutarik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<DevredenSure>k__BackingField", IsRequired=true)]
        public double DevredenSurek__BackingField {
            get {
                return this.DevredenSurek__BackingFieldField;
            }
            set {
                if ((this.DevredenSurek__BackingFieldField.Equals(value) != true)) {
                    this.DevredenSurek__BackingFieldField = value;
                    this.RaisePropertyChanged("DevredenSurek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ID>k__BackingField", IsRequired=true)]
        public int IDk__BackingField {
            get {
                return this.IDk__BackingFieldField;
            }
            set {
                if ((this.IDk__BackingFieldField.Equals(value) != true)) {
                    this.IDk__BackingFieldField = value;
                    this.RaisePropertyChanged("IDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<KapanmisProje>k__BackingField", IsRequired=true)]
        public string KapanmisProjek__BackingField {
            get {
                return this.KapanmisProjek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.KapanmisProjek__BackingFieldField, value) != true)) {
                    this.KapanmisProjek__BackingFieldField = value;
                    this.RaisePropertyChanged("KapanmisProjek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<MusteriID>k__BackingField", IsRequired=true)]
        public int MusteriIDk__BackingField {
            get {
                return this.MusteriIDk__BackingFieldField;
            }
            set {
                if ((this.MusteriIDk__BackingFieldField.Equals(value) != true)) {
                    this.MusteriIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("MusteriIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Notlar>k__BackingField", IsRequired=true)]
        public string Notlark__BackingField {
            get {
                return this.Notlark__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Notlark__BackingFieldField, value) != true)) {
                    this.Notlark__BackingFieldField = value;
                    this.RaisePropertyChanged("Notlark__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<OzelDovizKuru1>k__BackingField", IsRequired=true)]
        public double OzelDovizKuru1k__BackingField {
            get {
                return this.OzelDovizKuru1k__BackingFieldField;
            }
            set {
                if ((this.OzelDovizKuru1k__BackingFieldField.Equals(value) != true)) {
                    this.OzelDovizKuru1k__BackingFieldField = value;
                    this.RaisePropertyChanged("OzelDovizKuru1k__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<OzelDovizKuru2>k__BackingField", IsRequired=true)]
        public double OzelDovizKuru2k__BackingField {
            get {
                return this.OzelDovizKuru2k__BackingFieldField;
            }
            set {
                if ((this.OzelDovizKuru2k__BackingFieldField.Equals(value) != true)) {
                    this.OzelDovizKuru2k__BackingFieldField = value;
                    this.RaisePropertyChanged("OzelDovizKuru2k__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<OzelDovizKuruVar>k__BackingField", IsRequired=true)]
        public string OzelDovizKuruVark__BackingField {
            get {
                return this.OzelDovizKuruVark__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.OzelDovizKuruVark__BackingFieldField, value) != true)) {
                    this.OzelDovizKuruVark__BackingFieldField = value;
                    this.RaisePropertyChanged("OzelDovizKuruVark__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProjeAdi>k__BackingField", IsRequired=true)]
        public string ProjeAdik__BackingField {
            get {
                return this.ProjeAdik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjeAdik__BackingFieldField, value) != true)) {
                    this.ProjeAdik__BackingFieldField = value;
                    this.RaisePropertyChanged("ProjeAdik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProjeBaslangic>k__BackingField", IsRequired=true)]
        public string ProjeBaslangick__BackingField {
            get {
                return this.ProjeBaslangick__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjeBaslangick__BackingFieldField, value) != true)) {
                    this.ProjeBaslangick__BackingFieldField = value;
                    this.RaisePropertyChanged("ProjeBaslangick__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProjeBitis>k__BackingField", IsRequired=true)]
        public string ProjeBitisk__BackingField {
            get {
                return this.ProjeBitisk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjeBitisk__BackingFieldField, value) != true)) {
                    this.ProjeBitisk__BackingFieldField = value;
                    this.RaisePropertyChanged("ProjeBitisk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProjeKodu>k__BackingField", IsRequired=true)]
        public string ProjeKoduk__BackingField {
            get {
                return this.ProjeKoduk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.ProjeKoduk__BackingFieldField, value) != true)) {
                    this.ProjeKoduk__BackingFieldField = value;
                    this.RaisePropertyChanged("ProjeKoduk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ProjeTipiID>k__BackingField", IsRequired=true)]
        public int ProjeTipiIDk__BackingField {
            get {
                return this.ProjeTipiIDk__BackingFieldField;
            }
            set {
                if ((this.ProjeTipiIDk__BackingFieldField.Equals(value) != true)) {
                    this.ProjeTipiIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("ProjeTipiIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<VeriGirisDili>k__BackingField", IsRequired=true)]
        public string VeriGirisDilik__BackingField {
            get {
                return this.VeriGirisDilik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.VeriGirisDilik__BackingFieldField, value) != true)) {
                    this.VeriGirisDilik__BackingFieldField = value;
                    this.RaisePropertyChanged("VeriGirisDilik__BackingField");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetKullanicilarResponse", Namespace="http://schemas.datacontract.org/2004/07/IpManagerWs.Model")]
    [System.SerializableAttribute()]
    public partial class GetKullanicilarResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IpManagerWs.HukukWs.Kullanicilar[] KullanicilarField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private IpManagerWs.HukukWs.Statu StatuField;
        
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
        public IpManagerWs.HukukWs.Kullanicilar[] Kullanicilar {
            get {
                return this.KullanicilarField;
            }
            set {
                if ((object.ReferenceEquals(this.KullanicilarField, value) != true)) {
                    this.KullanicilarField = value;
                    this.RaisePropertyChanged("Kullanicilar");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Operation {
            get {
                return this.OperationField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationField, value) != true)) {
                    this.OperationField = value;
                    this.RaisePropertyChanged("Operation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public IpManagerWs.HukukWs.Statu Statu {
            get {
                return this.StatuField;
            }
            set {
                if ((this.StatuField.Equals(value) != true)) {
                    this.StatuField = value;
                    this.RaisePropertyChanged("Statu");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Kullanicilar", Namespace="http://schemas.datacontract.org/2004/07/IpManagerWs.Model")]
    [System.SerializableAttribute()]
    public partial class Kullanicilar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string Blokek__BackingFieldField;
        
        private string CalisanAdik__BackingFieldField;
        
        private string CalisanSoyadik__BackingFieldField;
        
        private string Emailk__BackingFieldField;
        
        private int GorevIDk__BackingFieldField;
        
        private int IDk__BackingFieldField;
        
        private string IseGirisTarihik__BackingFieldField;
        
        private string IstenCikisTarihik__BackingFieldField;
        
        private string KullaniciKoduk__BackingFieldField;
        
        private string SaatUcretlik__BackingFieldField;
        
        private string Sifrek__BackingFieldField;
        
        private string Sistemdek__BackingFieldField;
        
        private string YetkiDizisik__BackingFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Bloke>k__BackingField", IsRequired=true)]
        public string Blokek__BackingField {
            get {
                return this.Blokek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Blokek__BackingFieldField, value) != true)) {
                    this.Blokek__BackingFieldField = value;
                    this.RaisePropertyChanged("Blokek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CalisanAdi>k__BackingField", IsRequired=true)]
        public string CalisanAdik__BackingField {
            get {
                return this.CalisanAdik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.CalisanAdik__BackingFieldField, value) != true)) {
                    this.CalisanAdik__BackingFieldField = value;
                    this.RaisePropertyChanged("CalisanAdik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<CalisanSoyadi>k__BackingField", IsRequired=true)]
        public string CalisanSoyadik__BackingField {
            get {
                return this.CalisanSoyadik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.CalisanSoyadik__BackingFieldField, value) != true)) {
                    this.CalisanSoyadik__BackingFieldField = value;
                    this.RaisePropertyChanged("CalisanSoyadik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Email>k__BackingField", IsRequired=true)]
        public string Emailk__BackingField {
            get {
                return this.Emailk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Emailk__BackingFieldField, value) != true)) {
                    this.Emailk__BackingFieldField = value;
                    this.RaisePropertyChanged("Emailk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<GorevID>k__BackingField", IsRequired=true)]
        public int GorevIDk__BackingField {
            get {
                return this.GorevIDk__BackingFieldField;
            }
            set {
                if ((this.GorevIDk__BackingFieldField.Equals(value) != true)) {
                    this.GorevIDk__BackingFieldField = value;
                    this.RaisePropertyChanged("GorevIDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<ID>k__BackingField", IsRequired=true)]
        public int IDk__BackingField {
            get {
                return this.IDk__BackingFieldField;
            }
            set {
                if ((this.IDk__BackingFieldField.Equals(value) != true)) {
                    this.IDk__BackingFieldField = value;
                    this.RaisePropertyChanged("IDk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<IseGirisTarihi>k__BackingField", IsRequired=true)]
        public string IseGirisTarihik__BackingField {
            get {
                return this.IseGirisTarihik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.IseGirisTarihik__BackingFieldField, value) != true)) {
                    this.IseGirisTarihik__BackingFieldField = value;
                    this.RaisePropertyChanged("IseGirisTarihik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<IstenCikisTarihi>k__BackingField", IsRequired=true)]
        public string IstenCikisTarihik__BackingField {
            get {
                return this.IstenCikisTarihik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.IstenCikisTarihik__BackingFieldField, value) != true)) {
                    this.IstenCikisTarihik__BackingFieldField = value;
                    this.RaisePropertyChanged("IstenCikisTarihik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<KullaniciKodu>k__BackingField", IsRequired=true)]
        public string KullaniciKoduk__BackingField {
            get {
                return this.KullaniciKoduk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.KullaniciKoduk__BackingFieldField, value) != true)) {
                    this.KullaniciKoduk__BackingFieldField = value;
                    this.RaisePropertyChanged("KullaniciKoduk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<SaatUcretli>k__BackingField", IsRequired=true)]
        public string SaatUcretlik__BackingField {
            get {
                return this.SaatUcretlik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.SaatUcretlik__BackingFieldField, value) != true)) {
                    this.SaatUcretlik__BackingFieldField = value;
                    this.RaisePropertyChanged("SaatUcretlik__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Sifre>k__BackingField", IsRequired=true)]
        public string Sifrek__BackingField {
            get {
                return this.Sifrek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Sifrek__BackingFieldField, value) != true)) {
                    this.Sifrek__BackingFieldField = value;
                    this.RaisePropertyChanged("Sifrek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Sistemde>k__BackingField", IsRequired=true)]
        public string Sistemdek__BackingField {
            get {
                return this.Sistemdek__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Sistemdek__BackingFieldField, value) != true)) {
                    this.Sistemdek__BackingFieldField = value;
                    this.RaisePropertyChanged("Sistemdek__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<YetkiDizisi>k__BackingField", IsRequired=true)]
        public string YetkiDizisik__BackingField {
            get {
                return this.YetkiDizisik__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.YetkiDizisik__BackingFieldField, value) != true)) {
                    this.YetkiDizisik__BackingFieldField = value;
                    this.RaisePropertyChanged("YetkiDizisik__BackingField");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HukukWs.IHsClient")]
    public interface IHsClient {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHsClient/AuthenticateUser", ReplyAction="http://tempuri.org/IHsClient/AuthenticateUserResponse")]
        IpManagerWs.HukukWs.HsResponseOfstring AuthenticateUser(int userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHsClient/AuthenticateUser", ReplyAction="http://tempuri.org/IHsClient/AuthenticateUserResponse")]
        System.Threading.Tasks.Task<IpManagerWs.HukukWs.HsResponseOfstring> AuthenticateUserAsync(int userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHsClient/GetMatters", ReplyAction="http://tempuri.org/IHsClient/GetMattersResponse")]
        IpManagerWs.HukukWs.GetMattersResponse GetMatters(string dbname, int reporttype);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHsClient/GetMatters", ReplyAction="http://tempuri.org/IHsClient/GetMattersResponse")]
        System.Threading.Tasks.Task<IpManagerWs.HukukWs.GetMattersResponse> GetMattersAsync(string dbname, int reporttype);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHsClient/GetKullanicilar", ReplyAction="http://tempuri.org/IHsClient/GetKullanicilarResponse")]
        IpManagerWs.HukukWs.GetKullanicilarResponse GetKullanicilar(string dbname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHsClient/GetKullanicilar", ReplyAction="http://tempuri.org/IHsClient/GetKullanicilarResponse")]
        System.Threading.Tasks.Task<IpManagerWs.HukukWs.GetKullanicilarResponse> GetKullanicilarAsync(string dbname);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHsClientChannel : IpManagerWs.HukukWs.IHsClient, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HsClientClient : System.ServiceModel.ClientBase<IpManagerWs.HukukWs.IHsClient>, IpManagerWs.HukukWs.IHsClient {
        
        public HsClientClient() {
        }
        
        public HsClientClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HsClientClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HsClientClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HsClientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IpManagerWs.HukukWs.HsResponseOfstring AuthenticateUser(int userId, string password) {
            return base.Channel.AuthenticateUser(userId, password);
        }
        
        public System.Threading.Tasks.Task<IpManagerWs.HukukWs.HsResponseOfstring> AuthenticateUserAsync(int userId, string password) {
            return base.Channel.AuthenticateUserAsync(userId, password);
        }
        
        public IpManagerWs.HukukWs.GetMattersResponse GetMatters(string dbname, int reporttype) {
            return base.Channel.GetMatters(dbname, reporttype);
        }
        
        public System.Threading.Tasks.Task<IpManagerWs.HukukWs.GetMattersResponse> GetMattersAsync(string dbname, int reporttype) {
            return base.Channel.GetMattersAsync(dbname, reporttype);
        }
        
        public IpManagerWs.HukukWs.GetKullanicilarResponse GetKullanicilar(string dbname) {
            return base.Channel.GetKullanicilar(dbname);
        }
        
        public System.Threading.Tasks.Task<IpManagerWs.HukukWs.GetKullanicilarResponse> GetKullanicilarAsync(string dbname) {
            return base.Channel.GetKullanicilarAsync(dbname);
        }
    }
}