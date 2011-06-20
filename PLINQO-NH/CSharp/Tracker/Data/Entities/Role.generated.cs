#pragma warning disable 1591
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
using System.Collections;
using System.Collections.Generic;
using Tracker.Data;

namespace Tracker.Data.Entities
{
    [System.Runtime.Serialization.DataContract(IsReference = true)]
    [System.ComponentModel.DataAnnotations.ScaffoldTable(true)]
    [System.Diagnostics.DebuggerDisplay("Id: {Id}")]
    public partial class Role : EntityBase
    {
        #region Static Constructor
        
        /// <summary>
        /// Initializes the <see cref="Account"/> class.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        static Role()
        {
            AddSharedRules();
        }
        
        #endregion

        #region Default Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCode]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public Role()
        {
            Initialize();
        }

        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        protected override void Initialize()
        {
            OnCreated();
        }
        
        #endregion
        
        #region Column Mapped Properties
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.Int32 _identification;
        
        [System.Runtime.Serialization.DataMember(Order = 1)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.Int32 Id
        {
            get { return _identification; }
            set
            {
                OnIdChanging(value, _identification);
                SendPropertyChanging("Id");
                _identification = value;
                SendPropertyChanged("Id");
                OnIdChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _name;
        
        [System.Runtime.Serialization.DataMember(Order = 2)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Name
        {
            get { return _name; }
            set
            {
                OnNameChanging(value, _name);
                SendPropertyChanging("Name");
                _name = value;
                SendPropertyChanged("Name");
                OnNameChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.String _description;
        
        [System.Runtime.Serialization.DataMember(Order = 3)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.String Description
        {
            get { return _description; }
            set
            {
                OnDescriptionChanging(value, _description);
                SendPropertyChanging("Description");
                _description = value;
                SendPropertyChanged("Description");
                OnDescriptionChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _createdDate;
        
        [System.Runtime.Serialization.DataMember(Order = 4)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime CreatedDate
        {
            get { return _createdDate; }
            set
            {
                OnCreatedDateChanging(value, _createdDate);
                SendPropertyChanging("CreatedDate");
                _createdDate = value;
                SendPropertyChanged("CreatedDate");
                OnCreatedDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.DateTime _modifiedDate;
        
        [System.Runtime.Serialization.DataMember(Order = 5)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.DateTime ModifiedDate
        {
            get { return _modifiedDate; }
            set
            {
                OnModifiedDateChanging(value, _modifiedDate);
                SendPropertyChanging("ModifiedDate");
                _modifiedDate = value;
                SendPropertyChanged("ModifiedDate");
                OnModifiedDateChanged(value);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private System.Byte[] _rowVersion;
        
        [System.Runtime.Serialization.DataMember(Order = 6)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual System.Byte[] RowVersion
        {
            get { return _rowVersion; }
            set
            {
                OnRowVersionChanging(value, _rowVersion);
                SendPropertyChanging("RowVersion");
                _rowVersion = value;
                SendPropertyChanged("RowVersion");
                OnRowVersionChanged(value);
            }
        }
        
        #endregion
        
        #region Associations Mappings
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        private IList<User> _userList;
        
        [System.Runtime.Serialization.DataMember(Order = 7, EmitDefaultValue = false)]
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual IList<User> UserList
        {
            get { return _userList; }
            set
            {
                OnUserListChanging(value, _userList);
                SendPropertyChanging("UserList");
                _userList = value;
                SendPropertyChanged("UserList");
                OnUserListChanged(value);
            }
        }
        
        #endregion
        
        #region Extensibility Method
        
        static partial void AddSharedRules();
        
        partial void OnCreated();
        
        partial void OnIdChanging(System.Int32 newValue, System.Int32 oldValue);
        
        partial void OnIdChanged(System.Int32 value);
        
        partial void OnNameChanging(System.String newValue, System.String oldValue);
        
        partial void OnNameChanged(System.String value);
        
        partial void OnDescriptionChanging(System.String newValue, System.String oldValue);
        
        partial void OnDescriptionChanged(System.String value);
        
        partial void OnCreatedDateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnCreatedDateChanged(System.DateTime value);
        
        partial void OnModifiedDateChanging(System.DateTime newValue, System.DateTime oldValue);
        
        partial void OnModifiedDateChanged(System.DateTime value);
        
        partial void OnRowVersionChanging(System.Byte[] newValue, System.Byte[] oldValue);
        
        partial void OnRowVersionChanged(System.Byte[] value);
        
        
        partial void OnUserListChanging(IList<User> newValue, IList<User> oldValue);
        
        partial void OnUserListChanged(IList<User> value);
        
        #endregion
        
        #region Clone
        
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public virtual Role Clone()
        {
            return (Role)((ICloneable)this).Clone();
        }
        
        #endregion
        
        #region Serialization
        
        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from XML.
        /// </summary>
        /// <param name="xml">The XML string representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the XML string.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Role FromXml(string xml)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Role));

            using (var sr = new System.IO.StringReader(xml))
            using (var reader = System.Xml.XmlReader.Create(sr))
            {
                return deserializer.ReadObject(reader) as Role;
            }
        }

        /// <summary>
        /// Deserializes an instance of <see cref="Account"/> from a byte array.
        /// </summary>
        /// <param name="buffer">The byte array representing a <see cref="Account"/> instance.</param>
        /// <returns>An instance of <see cref="Account"/> that is deserialized from the byte array.</returns>
        [System.CodeDom.Compiler.GeneratedCode("CodeSmith", "5.0.0.0")]
        public static Role FromBinary(byte[] buffer)
        {
            var deserializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Role));

            using (var ms = new System.IO.MemoryStream(buffer))
            using (var reader = System.Xml.XmlDictionaryReader.CreateBinaryReader(ms, System.Xml.XmlDictionaryReaderQuotas.Max))
            {
                return deserializer.ReadObject(reader) as Role;
            }
        }
        
        #endregion
    }
}

#pragma warning restore 1591
#pragma warning restore 0414

