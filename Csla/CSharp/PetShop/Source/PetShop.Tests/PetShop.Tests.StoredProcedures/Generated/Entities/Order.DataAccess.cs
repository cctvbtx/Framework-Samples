﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: SwitchableObject.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

namespace PetShop.Tests.StoredProcedures
{
    public partial class Order
    {
        #region Root Data Access

        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(OrderCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[CSLA_Order_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_ShipAddr2HasValue", criteria.ShipAddr2HasValue);
                command.Parameters.AddWithValue("@p_BillAddr2HasValue", criteria.BillAddr2HasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Orders' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand("[dbo].[CSLA_Order_Insert]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
                command.Parameters["@p_OrderId"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_UserId", this.UserId);
                command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
                command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
                command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
                command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
                command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
                command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
                command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
                command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
                command.Parameters.AddWithValue("@p_BillState", this.BillState);
                command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
                command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
                command.Parameters.AddWithValue("@p_Courier", this.Courier);
                command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
                command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
                command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
                command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
                command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
                command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
                command.Parameters.AddWithValue("@p_Locale", this.Locale);
                    command.ExecuteNonQuery();

                    using (BypassPropertyChecks)
                    {
                        LoadProperty(_orderIdProperty,(System.Int32)command.Parameters["@p_OrderId"].Value);
                    }
                }
                

                FieldManager.UpdateChildren(this, connection);
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand("[dbo].[CSLA_Order_Update]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
                command.Parameters.AddWithValue("@p_UserId", this.UserId);
                command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
                command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
                command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
                command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
                command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
                command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
                command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
                command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
                command.Parameters.AddWithValue("@p_BillState", this.BillState);
                command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
                command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
                command.Parameters.AddWithValue("@p_Courier", this.Courier);
                command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
                command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
                command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
                command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
                command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
                command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
                command.Parameters.AddWithValue("@p_Locale", this.Locale);
                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new OrderCriteria (OrderId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(OrderCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[CSLA_Order_Delete]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(OrderCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (var command = new SqlCommand("[dbo].[CSLA_Order_Delete]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnDeleted();
        }

        #endregion

        #region Child Data Access

        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(OrderCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("[dbo].[CSLA_Order_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_ShipAddr2HasValue", criteria.ShipAddr2HasValue);
                command.Parameters.AddWithValue("@p_BillAddr2HasValue", criteria.BillAddr2HasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Orders' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();


            MarkAsChild();
        }

        #region Child_Insert

        private void Child_Insert(SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[CSLA_Order_Insert]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
                command.Parameters["@p_OrderId"].Direction = ParameterDirection.Output;
                command.Parameters.AddWithValue("@p_UserId", this.UserId);
                command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
                command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
                command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
                command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
                command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
                command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
                command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
                command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
                command.Parameters.AddWithValue("@p_BillState", this.BillState);
                command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
                command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
                command.Parameters.AddWithValue("@p_Courier", this.Courier);
                command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
                command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
                command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
                command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
                command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
                command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
                command.Parameters.AddWithValue("@p_Locale", this.Locale);

                command.ExecuteNonQuery();
               
                // Update identity primary key value.
                LoadProperty(_orderIdProperty,(System.Int32)command.Parameters["@p_OrderId"].Value);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        private void Child_Update(SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            using(var command = new SqlCommand("[dbo].[CSLA_Order_Update]", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_OrderId", this.OrderId);
                command.Parameters.AddWithValue("@p_UserId", this.UserId);
                command.Parameters.AddWithValue("@p_OrderDate", this.OrderDate);
                command.Parameters.AddWithValue("@p_ShipAddr1", this.ShipAddr1);
                command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(this.ShipAddr2));
                command.Parameters.AddWithValue("@p_ShipCity", this.ShipCity);
                command.Parameters.AddWithValue("@p_ShipState", this.ShipState);
                command.Parameters.AddWithValue("@p_ShipZip", this.ShipZip);
                command.Parameters.AddWithValue("@p_ShipCountry", this.ShipCountry);
                command.Parameters.AddWithValue("@p_BillAddr1", this.BillAddr1);
                command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(this.BillAddr2));
                command.Parameters.AddWithValue("@p_BillCity", this.BillCity);
                command.Parameters.AddWithValue("@p_BillState", this.BillState);
                command.Parameters.AddWithValue("@p_BillZip", this.BillZip);
                command.Parameters.AddWithValue("@p_BillCountry", this.BillCountry);
                command.Parameters.AddWithValue("@p_Courier", this.Courier);
                command.Parameters.AddWithValue("@p_TotalPrice", this.TotalPrice);
                command.Parameters.AddWithValue("@p_BillToFirstName", this.BillToFirstName);
                command.Parameters.AddWithValue("@p_BillToLastName", this.BillToLastName);
                command.Parameters.AddWithValue("@p_ShipToFirstName", this.ShipToFirstName);
                command.Parameters.AddWithValue("@p_ShipToLastName", this.ShipToLastName);
                command.Parameters.AddWithValue("@p_AuthorizationNumber", this.AuthorizationNumber);
                command.Parameters.AddWithValue("@p_Locale", this.Locale);

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new OrderCriteria (OrderId));
        
            OnChildSelfDeleted();
        }

        private void Child_DeleteSelf(params object[] args)
        {
            var connection = args.OfType<SqlConnection>().FirstOrDefault();
            if(connection == null)
                throw new ArgumentNullException("args", "Must contain a SqlConnection parameter.");

            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;

            DataPortal_Delete(new OrderCriteria (OrderId), connection);

            OnChildSelfDeleted();
        }

        #endregion

        #region Map

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_orderIdProperty, reader["OrderId"]);
                LoadProperty(_userIdProperty, reader["UserId"]);
                LoadProperty(_orderDateProperty, reader["OrderDate"]);
                LoadProperty(_shipAddr1Property, reader["ShipAddr1"]);
                LoadProperty(_shipAddr2Property, reader["ShipAddr2"]);
                LoadProperty(_shipCityProperty, reader["ShipCity"]);
                LoadProperty(_shipStateProperty, reader["ShipState"]);
                LoadProperty(_shipZipProperty, reader["ShipZip"]);
                LoadProperty(_shipCountryProperty, reader["ShipCountry"]);
                LoadProperty(_billAddr1Property, reader["BillAddr1"]);
                LoadProperty(_billAddr2Property, reader["BillAddr2"]);
                LoadProperty(_billCityProperty, reader["BillCity"]);
                LoadProperty(_billStateProperty, reader["BillState"]);
                LoadProperty(_billZipProperty, reader["BillZip"]);
                LoadProperty(_billCountryProperty, reader["BillCountry"]);
                LoadProperty(_courierProperty, reader["Courier"]);
                LoadProperty(_totalPriceProperty, reader["TotalPrice"]);
                LoadProperty(_billToFirstNameProperty, reader["BillToFirstName"]);
                LoadProperty(_billToLastNameProperty, reader["BillToLastName"]);
                LoadProperty(_shipToFirstNameProperty, reader["ShipToFirstName"]);
                LoadProperty(_shipToLastNameProperty, reader["ShipToLastName"]);
                LoadProperty(_authorizationNumberProperty, reader["AuthorizationNumber"]);
                LoadProperty(_localeProperty, reader["Locale"]);
            }

            OnMapped();
        }
        
        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }

        #endregion
    }
}
