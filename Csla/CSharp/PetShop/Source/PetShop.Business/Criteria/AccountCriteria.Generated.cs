﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Account.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Csla.Core;
#if SILVERLIGHT
using Csla.Serialization;
#endif
using Csla.Serialization.Mobile;

#if !SILVERLIGHT
using System.Data.SqlClient;
#endif

using Csla;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class AccountCriteria : CriteriaBase<AccountCriteria>, IGeneratedCriteria
    {
        #region Private Read-Only Members
        
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #endregion
        
        #region Constructors

        public AccountCriteria(){}

        public AccountCriteria(System.Int32 accountId)
        {
            AccountId = accountId;
        }
        
        #endregion
        
        #region Public Properties
        
        #region Read-Write

        public System.Int32 AccountId
        {
            get { return GetValue< System.Int32 >("AccountId"); }
            set { _bag["AccountId"] = value; }
        }

        public System.Int32 UniqueID
        {
            get { return GetValue< System.Int32 >("UniqueID"); }
            set { _bag["UniqueID"] = value; }
        }

        public System.String Email
        {
            get { return GetValue< System.String >("Email"); }
            set { _bag["Email"] = value; }
        }

        public System.String FirstName
        {
            get { return GetValue< System.String >("FirstName"); }
            set { _bag["FirstName"] = value; }
        }

        public System.String LastName
        {
            get { return GetValue< System.String >("LastName"); }
            set { _bag["LastName"] = value; }
        }

        public System.String Address1
        {
            get { return GetValue< System.String >("Address1"); }
            set { _bag["Address1"] = value; }
        }

        public System.String Address2
        {
            get { return GetValue< System.String >("Address2"); }
            set { _bag["Address2"] = value; }
        }

        public System.String City
        {
            get { return GetValue< System.String >("City"); }
            set { _bag["City"] = value; }
        }

        public System.String State
        {
            get { return GetValue< System.String >("State"); }
            set { _bag["State"] = value; }
        }

        public System.String Zip
        {
            get { return GetValue< System.String >("Zip"); }
            set { _bag["Zip"] = value; }
        }

        public System.String Country
        {
            get { return GetValue< System.String >("Country"); }
            set { _bag["Country"] = value; }
        }

        public System.String Phone
        {
            get { return GetValue< System.String >("Phone"); }
            set { _bag["Phone"] = value; }
        }

        #endregion
        
        #region Read-Only

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public Dictionary<string, object> StateBag
        {
            get
            {
                return _bag;
            }
        }

        /// <summary>
        /// Returns a list of all the modified properties and values.
        /// </summary>
        public string TableFullName
        {
            get
            {
                return "[dbo].[Account]";
            }
        }

		
        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = string.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !string.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += string.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
            }

            return result.Remove(result.Length - 5, 5);
        }

        #endregion

        #region Private Methods
        
        private T GetValue<T>(string name)
        {
            object value;
            if (_bag.TryGetValue(name, out value))
                return (T) value;
        
            return default(T);
        }
        
        #endregion
        
        #region Partial Methods
        
        partial void OnToString(ref string result, ref bool cancel);
        
        #endregion
        
        #region Serialization
        
        protected override void OnGetState(SerializationInfo info, StateMode mode)
        {
            base.OnGetState(info, mode);
            if (_bag.ContainsKey("AccountId")) info.AddValue("AccountId", GetValue< System.Int32 >("AccountId"));
            if (_bag.ContainsKey("UniqueID")) info.AddValue("UniqueID", GetValue< System.Int32 >("UniqueID"));
            if (_bag.ContainsKey("Email")) info.AddValue("Email", GetValue< System.String >("Email"));
            if (_bag.ContainsKey("FirstName")) info.AddValue("FirstName", GetValue< System.String >("FirstName"));
            if (_bag.ContainsKey("LastName")) info.AddValue("LastName", GetValue< System.String >("LastName"));
            if (_bag.ContainsKey("Address1")) info.AddValue("Address1", GetValue< System.String >("Address1"));
            if (_bag.ContainsKey("Address2")) info.AddValue("Address2", GetValue< System.String >("Address2"));
            if (_bag.ContainsKey("City")) info.AddValue("City", GetValue< System.String >("City"));
            if (_bag.ContainsKey("State")) info.AddValue("State", GetValue< System.String >("State"));
            if (_bag.ContainsKey("Zip")) info.AddValue("Zip", GetValue< System.String >("Zip"));
            if (_bag.ContainsKey("Country")) info.AddValue("Country", GetValue< System.String >("Country"));
            if (_bag.ContainsKey("Phone")) info.AddValue("Phone", GetValue< System.String >("Phone"));
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);
            if(info.Values.ContainsKey("AccountId")) _bag["AccountId"] = info.GetValue< System.Int32 >("AccountId");
            if(info.Values.ContainsKey("UniqueID")) _bag["UniqueID"] = info.GetValue< System.Int32 >("UniqueID");
            if(info.Values.ContainsKey("Email")) _bag["Email"] = info.GetValue< System.String >("Email");
            if(info.Values.ContainsKey("FirstName")) _bag["FirstName"] = info.GetValue< System.String >("FirstName");
            if(info.Values.ContainsKey("LastName")) _bag["LastName"] = info.GetValue< System.String >("LastName");
            if(info.Values.ContainsKey("Address1")) _bag["Address1"] = info.GetValue< System.String >("Address1");
            if(info.Values.ContainsKey("Address2")) _bag["Address2"] = info.GetValue< System.String >("Address2");
            if(info.Values.ContainsKey("City")) _bag["City"] = info.GetValue< System.String >("City");
            if(info.Values.ContainsKey("State")) _bag["State"] = info.GetValue< System.String >("State");
            if(info.Values.ContainsKey("Zip")) _bag["Zip"] = info.GetValue< System.String >("Zip");
            if(info.Values.ContainsKey("Country")) _bag["Country"] = info.GetValue< System.String >("Country");
            if(info.Values.ContainsKey("Phone")) _bag["Phone"] = info.GetValue< System.String >("Phone");
        }

        #endregion
    }
}