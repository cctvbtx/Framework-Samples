﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2430, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'ProductList.cs'.
//
//     Template: EditableChildList.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Collections.Generic;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class ProductList : BusinessListBase< ProductList, Product >
    {
        #region Constructor(s)

        private ProductList()
        { 
            AllowNew = true;
            MarkAsChild();
        }
        
        #endregion

        #region Synchronous Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="ProductList"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="ProductList"/>.</returns>
        internal static ProductList NewList()
        {
            return DataPortal.CreateChild< ProductList >();
        }     

        /// <summary>
        /// Returns a <see cref="ProductList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="productId">No additional detail available.</param>
        /// <returns>A <see cref="ProductList"/> object of the specified criteria.</returns>
        internal static ProductList GetByProductId(System.String productId)
        {
            var criteria = new ProductCriteria{ProductId = productId};
            
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ProductList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="ProductList"/> object of the specified criteria.</returns>
        internal static ProductList GetByName(System.String name)
        {
            var criteria = new ProductCriteria{Name = name};
            
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ProductList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <returns>A <see cref="ProductList"/> object of the specified criteria.</returns>
        internal static ProductList GetByCategoryId(System.String categoryId)
        {
            var criteria = new ProductCriteria{CategoryId = categoryId};
            
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ProductList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="ProductList"/> object of the specified criteria.</returns>
        internal static ProductList GetByCategoryIdName(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria{CategoryId = categoryId, Name = name};
            
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        /// <summary>
        /// Returns a <see cref="ProductList"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <param name="productId">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="ProductList"/> object of the specified criteria.</returns>
        internal static ProductList GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria{CategoryId = categoryId, ProductId = productId, Name = name};
            
            
            return DataPortal.FetchChild< ProductList >(criteria);
        }

        internal static ProductList GetAll()
        {
            return DataPortal.FetchChild< ProductList >(new ProductCriteria());
        }

        #endregion


        #region Method Overrides
        
        protected override Product AddNewCore()
        {
            Product item = PetShop.Tests.ParameterizedSQL.Product.NewProduct();

            bool cancel = false;
            OnAddNewCore(ref item, ref cancel);
            if (!cancel)
            {
                // Check to see if someone set the item to null in the OnAddNewCore.
                if(item == null)
                    item = PetShop.Tests.ParameterizedSQL.Product.NewProduct();

                // Pass the parent value down to the child.
                Category category = this.Parent as Category;
                if(category != null)
                    item.CategoryId = category.CategoryId;


                Add(item);
            }

            return item;
        }
        
        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// Codesmith generated stub method that is called when creating the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Product"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// Codesmith generated stub method that is called when fetching the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProductCriteria"/> object containg the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(ProductCriteria criteria, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Product"/> object has been fetched. 
        /// </summary>
        partial void OnFetched();

        /// <summary>
        /// Codesmith generated stub method that is called when mapping the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the child <see cref="Product"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// Codesmith generated stub method that is called when updating the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// Codesmith generated stub method that is called after the <see cref="Product"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();
        partial void OnAddNewCore(ref Product item, ref bool cancel);

        #endregion
        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Product in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is a <see cref="ProductList"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(ProductCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.Product.Exists(criteria);
        }

        #endregion

    }
}