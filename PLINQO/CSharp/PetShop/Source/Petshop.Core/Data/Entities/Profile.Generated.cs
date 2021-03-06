﻿#pragma warning disable 1591
#pragma warning disable 0414        
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a CodeSmith Template.
//
//     DO NOT MODIFY contents of this file. Changes to this
//     file will be lost if the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Linq;

namespace PetShop.Core.Data
{
    /// <summary>
    /// The class representing the dbo.Profiles table.
    /// </summary>
    [System.Data.Linq.Mapping.Table(Name="dbo.Profiles")]
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(PetShop.Core.Data.Profile.Metadata))]
    [System.Data.Services.Common.DataServiceKey("UniqueID")]
    [System.Diagnostics.DebuggerDisplay("UniqueID: {UniqueID}")]
    public partial class Profile
        : LinqEntityBase, ICloneable 
    {
        #region Static Constructor
        /// <summary>
        /// Initializes the <see cref="Profile"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static Profile()
        {
            AddSharedRules();
        }
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Profile"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Profile()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void Initialize()
        {
            _accountList = new System.Data.Linq.EntitySet<Account>(OnAccountListAdd, OnAccountListRemove);
            _cartList = new System.Data.Linq.EntitySet<Cart>(OnCartListAdd, OnCartListRemove);
            OnCreated();
        }
        #endregion

        #region Column Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private int _uniqueID = default(int);

        /// <summary>
        /// Gets the UniqueID column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "UniqueID", Storage = "_uniqueID", DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public int UniqueID
        {
            get { return _uniqueID; }
            set
            {
                if (_uniqueID != value)
                {
                    OnUniqueIDChanging(value);
                    SendPropertyChanging("UniqueID");
                    _uniqueID = value;
                    SendPropertyChanged("UniqueID");
                    OnUniqueIDChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _username;

        /// <summary>
        /// Gets or sets the Username column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "Username", Storage = "_username", DbType = "varchar(256) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    OnUsernameChanging(value);
                    SendPropertyChanging("Username");
                    _username = value;
                    SendPropertyChanged("Username");
                    OnUsernameChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private string _applicationName;

        /// <summary>
        /// Gets or sets the ApplicationName column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "ApplicationName", Storage = "_applicationName", DbType = "varchar(256) NOT NULL", CanBeNull = false)]
        [System.ComponentModel.DataAnnotations.StringLength(256)]
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public string ApplicationName
        {
            get { return _applicationName; }
            set
            {
                if (_applicationName != value)
                {
                    OnApplicationNameChanging(value);
                    SendPropertyChanging("ApplicationName");
                    _applicationName = value;
                    SendPropertyChanged("ApplicationName");
                    OnApplicationNameChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private Nullable<bool> _isAnonymous;

        /// <summary>
        /// Gets or sets the IsAnonymous column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "IsAnonymous", Storage = "_isAnonymous", DbType = "bit")]
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Nullable<bool> IsAnonymous
        {
            get { return _isAnonymous; }
            set
            {
                if (_isAnonymous != value)
                {
                    OnIsAnonymousChanging(value);
                    SendPropertyChanging("IsAnonymous");
                    _isAnonymous = value;
                    SendPropertyChanged("IsAnonymous");
                    OnIsAnonymousChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private Nullable<System.DateTime> _lastActivityDate;

        /// <summary>
        /// Gets or sets the LastActivityDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastActivityDate", Storage = "_lastActivityDate", DbType = "datetime")]
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Nullable<System.DateTime> LastActivityDate
        {
            get { return _lastActivityDate; }
            set
            {
                if (_lastActivityDate != value)
                {
                    OnLastActivityDateChanging(value);
                    SendPropertyChanging("LastActivityDate");
                    _lastActivityDate = value;
                    SendPropertyChanged("LastActivityDate");
                    OnLastActivityDateChanged();
                }
            }
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private Nullable<System.DateTime> _lastUpdatedDate;

        /// <summary>
        /// Gets or sets the LastUpdatedDate column value.
        /// </summary>
        [System.Data.Linq.Mapping.Column(Name = "LastUpdatedDate", Storage = "_lastUpdatedDate", DbType = "datetime")]
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Nullable<System.DateTime> LastUpdatedDate
        {
            get { return _lastUpdatedDate; }
            set
            {
                if (_lastUpdatedDate != value)
                {
                    OnLastUpdatedDateChanging(value);
                    SendPropertyChanging("LastUpdatedDate");
                    _lastUpdatedDate = value;
                    SendPropertyChanged("LastUpdatedDate");
                    OnLastUpdatedDateChanged();
                }
            }
        }
        #endregion

        #region Association Mapped Properties

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<Account> _accountList;

        /// <summary>
        /// Gets or sets the <see cref="Account"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Profile_Account", Storage = "_accountList", ThisKey = "UniqueID", OtherKey = "UniqueID")]
        [System.Runtime.Serialization.DataMember(Order=7, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<Account> AccountList
        {
            get { return (serializing && !_accountList.HasLoadedOrAssignedValues) ? null : _accountList; }
            set { _accountList.Assign(value); }
        }
        
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnAccountListAdd(Account entity)
        {
            SendPropertyChanging(null);
            entity.Profile = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnAccountListRemove(Account entity)
        {
            SendPropertyChanging(null);
            entity.Profile = null;
            SendPropertyChanged(null);
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private System.Data.Linq.EntitySet<Cart> _cartList;

        /// <summary>
        /// Gets or sets the <see cref="Cart"/> association.
        /// </summary>
        [System.Data.Linq.Mapping.Association(Name = "Profile_Cart", Storage = "_cartList", ThisKey = "UniqueID", OtherKey = "UniqueID")]
        [System.Runtime.Serialization.DataMember(Order=8, EmitDefaultValue=false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public System.Data.Linq.EntitySet<Cart> CartList
        {
            get { return (serializing && !_cartList.HasLoadedOrAssignedValues) ? null : _cartList; }
            set { _cartList.Assign(value); }
        }
        
        

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnCartListAdd(Cart entity)
        {
            SendPropertyChanging(null);
            entity.Profile = this;
            SendPropertyChanged(null);
        }

        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private void OnCartListRemove(Cart entity)
        {
            SendPropertyChanging(null);
            entity.Profile = null;
            SendPropertyChanged(null);
        }
        #endregion

        #region Extensibility Method Definitions
        /// <summary>Called by the static constructor to add shared rules.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        static partial void AddSharedRules();
        /// <summary>Called when this instance is loaded.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLoaded();
        /// <summary>Called when this instance is being saved.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnValidate(System.Data.Linq.ChangeAction action);
        /// <summary>Called when this instance is created.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnCreated();
        /// <summary>Called when <see cref="UniqueID"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUniqueIDChanging(int value);
        /// <summary>Called after <see cref="UniqueID"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUniqueIDChanged();
        /// <summary>Called when <see cref="Username"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUsernameChanging(string value);
        /// <summary>Called after <see cref="Username"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnUsernameChanged();
        /// <summary>Called when <see cref="ApplicationName"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnApplicationNameChanging(string value);
        /// <summary>Called after <see cref="ApplicationName"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnApplicationNameChanged();
        /// <summary>Called when <see cref="IsAnonymous"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIsAnonymousChanging(Nullable<bool> value);
        /// <summary>Called after <see cref="IsAnonymous"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnIsAnonymousChanged();
        /// <summary>Called when <see cref="LastActivityDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLastActivityDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="LastActivityDate"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLastActivityDateChanged();
        /// <summary>Called when <see cref="LastUpdatedDate"/> is changing.</summary>
        /// <param name="value">The new value.</param>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLastUpdatedDateChanging(Nullable<System.DateTime> value);
        /// <summary>Called after <see cref="LastUpdatedDate"/> has Changed.</summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        partial void OnLastUpdatedDateChanged();

        #endregion

        #region Serialization
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        private bool serializing;

        /// <summary>
        /// Called when serializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) {
            serializing = true;
        }

        /// <summary>
        /// Called when serialized.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnSerialized]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnSerialized(System.Runtime.Serialization.StreamingContext context) {
            serializing = false;
        }

        /// <summary>
        /// Called when deserializing.
        /// </summary>
        /// <param name="context">The <see cref="System.Runtime.Serialization.StreamingContext"/> for the serialization.</param>
        [System.Runtime.Serialization.OnDeserializing]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) {
            Initialize();
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Profile"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Profile"/> instance.</param>
        /// <returns>An instance of <see cref="Profile"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Profile FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Profile));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Profile;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Profile"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Profile"/> instance.</param>
        /// <returns>An instance of <see cref="Profile"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public static Profile FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Profile));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Profile;
            }
        }
        
        #endregion

        #region Clone
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        object ICloneable.Clone()
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(GetType());
            using (var ms = new System.IO.MemoryStream())
            {
                serializer.WriteObject(ms, this);
                ms.Position = 0;
                return serializer.ReadObject(ms);
            }
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <remarks>
        /// Only loaded <see cref="T:System.Data.Linq.EntityRef`1"/> and <see cref="T:System.Data.Linq.EntitySet`1" /> child accessions will be cloned.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public Profile Clone()
        {
            return (Profile)((ICloneable)this).Clone();
        }
        #endregion

        #region Detach Methods
        /// <summary>
        /// Detach this instance from the <see cref="System.Data.Linq.DataContext"/>.
        /// </summary>
        /// <remarks>
        /// Detaching the entity will stop all lazy loading and allow it to be added to another <see cref="System.Data.Linq.DataContext"/>.
        /// </remarks>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "6.0.0.0")]
        public override void Detach()
        {
            if (!IsAttached())
                return;

            base.Detach();
            _accountList = Detach(_accountList, OnAccountListAdd, OnAccountListRemove);
            _cartList = Detach(_cartList, OnCartListAdd, OnCartListRemove);
        }
        #endregion
    }
}
#pragma warning restore 1591
#pragma warning restore 0414

