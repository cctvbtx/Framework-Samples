﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'OrderStatus.cs'.
//
//     Template: Criteria.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Csla.Core;
#if SILVERLIGHT || NETFX_CORE
using Csla.Serialization;
#endif
using Csla.Serialization.Mobile;
#if !SILVERLIGHT && !NETFX_CORE
using System.Data.SqlClient;
#endif

using Csla;

namespace PetShop.Business
{
    [Serializable]
    public partial class OrderStatusCriteria : CriteriaBase<OrderStatusCriteria>, IGeneratedCriteria
    {
        private readonly Dictionary<string, object> _bag = new Dictionary<string, object>();
        
        #region Constructors

        public OrderStatusCriteria(){}

        public OrderStatusCriteria(System.Int32 orderId, System.Int32 lineNum)
        {
            OrderId = orderId;
            LineNum = lineNum;
        }

        #endregion

        #region Public Properties

        #region Read-Write

        public System.Int32 OrderId
        {
            get { return GetValue<System.Int32>("OrderId"); }
            set { _bag["OrderId"] = value; }
        }

        public System.Int32 LineNum
        {
            get { return GetValue<System.Int32>("LineNum"); }
            set { _bag["LineNum"] = value; }
        }

        public System.DateTime Timestamp
        {
            get { return GetValue<System.DateTime>("Timestamp"); }
            set { _bag["Timestamp"] = value; }
        }

        public System.String Status
        {
            get { return GetValue<System.String>("Status"); }
            set { _bag["Status"] = value; }
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
                return "[dbo].[OrderStatus]";
            }
        }

        #endregion

        #endregion

        #region Overrides
        
        public override string ToString()
        {
            var result = String.Empty;
            var cancel = false;
            
            OnToString(ref result, ref cancel);
            if(cancel && !String.IsNullOrEmpty(result))
                return result;
            
            if (_bag.Count == 0)
                return "No criterion was specified.";

            foreach (KeyValuePair<string, object> key in _bag)
            {
                result += String.Format("[{0}] = '{1}' AND ", key.Key, key.Value);
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
            if (_bag.ContainsKey("OrderId")) info.AddValue("OrderId", GetValue<System.Int32>("OrderId"));
            if (_bag.ContainsKey("LineNum")) info.AddValue("LineNum", GetValue<System.Int32>("LineNum"));
            if (_bag.ContainsKey("Timestamp")) info.AddValue("Timestamp", GetValue<System.DateTime>("Timestamp"));
            if (_bag.ContainsKey("Status")) info.AddValue("Status", GetValue<System.String>("Status"));
        }

        protected override void OnSetState(SerializationInfo info, StateMode mode)
        {
            base.OnSetState(info, mode);
            if(info.Values.ContainsKey("OrderId")) _bag["OrderId"] = info.GetValue<System.Int32>("OrderId");
            if(info.Values.ContainsKey("LineNum")) _bag["LineNum"] = info.GetValue<System.Int32>("LineNum");
            if(info.Values.ContainsKey("Timestamp")) _bag["Timestamp"] = info.GetValue<System.DateTime>("Timestamp");
            if(info.Values.ContainsKey("Status")) _bag["Status"] = info.GetValue<System.String>("Status");
        }

        #endregion
    }
}