﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;
using System.Threading.Tasks;

using Csla;
using Csla.Data;
using System.Data.SqlClient;
using Csla.Rules;

namespace PetShop.Tests.StoredProcedures
{
    [Serializable]
    public partial class Product : BusinessBase<Product>
    {
        #region Contructor(s)

        public Product()
        { /* Require use of factory methods */ }

        #endregion

 
        #region Business Rules

        /// <summary>
        /// Contains the CodeSmith generated validation rules.
        /// </summary>
        protected override void AddBusinessRules()
        {
            // Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            base.AddBusinessRules();

            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_productIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_productIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_categoryIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_categoryIdProperty, 10));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_nameProperty, 80));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_descriptionProperty, 255));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_imageProperty, 80));
        }

        #endregion


        #region Properties

        private static readonly PropertyInfo<System.String> _productIdProperty = RegisterProperty<System.String>(p => p.ProductId, "Product Id");
        [System.ComponentModel.DataObjectField(true, false)]
        public System.String ProductId
        {
            get { return GetProperty(_productIdProperty); }
            set{ SetProperty(_productIdProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _originalProductIdProperty = RegisterProperty<System.String>(p => p.OriginalProductId, "Original Product Id");
        /// <summary>
        /// Holds the original value for ProductId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalProductId
        {
            get { return GetProperty(_originalProductIdProperty); }
            set{ SetProperty(_originalProductIdProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _categoryIdProperty = RegisterProperty<System.String>(p => p.CategoryId, "Category Id");
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _nameProperty = RegisterProperty<System.String>(p => p.Name, "Name", (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _descriptionProperty = RegisterProperty<System.String>(p => p.Description, "Description", (System.String)null);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
            set{ SetProperty(_descriptionProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _imageProperty = RegisterProperty<System.String>(p => p.Image, "Image", (System.String)null);
        public System.String Image
        {
            get { return GetProperty(_imageProperty); }
            set{ SetProperty(_imageProperty, value); }
        }

        // ManyToOne
        private static readonly PropertyInfo<Category> _categoryProperty = RegisterProperty<Category>(p => p.Category, Csla.RelationshipTypes.Child);
        public Category Category
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_categoryProperty, ref cancel);

                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_categoryProperty))
                    {
                        var criteria = new PetShop.Tests.StoredProcedures.CategoryCriteria {CategoryId = CategoryId};
                        
                        if(PetShop.Tests.StoredProcedures.Category.Exists(criteria))
                            LoadProperty(_categoryProperty, PetShop.Tests.StoredProcedures.Category.GetByCategoryId(CategoryId));
                    }
                }

                return GetProperty(_categoryProperty); 
            }
        }

        // OneToMany
        private static readonly PropertyInfo<ItemList> _itemsProperty = RegisterProperty<ItemList>(p => p.Items, Csla.RelationshipTypes.Child);
        public ItemList Items
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_itemsProperty, ref cancel);
    
                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_itemsProperty))
                    {
                        var criteria = new PetShop.Tests.StoredProcedures.ItemCriteria {ProductId = ProductId};
                        
    
                        if(!PetShop.Tests.StoredProcedures.ItemList.Exists(criteria))
                            LoadProperty(_itemsProperty, PetShop.Tests.StoredProcedures.ItemList.NewList());
                        else
                            LoadProperty(_itemsProperty, PetShop.Tests.StoredProcedures.ItemList.GetByProductId(ProductId));
                    }
                }

                return GetProperty(_itemsProperty);
            }
        }


        #endregion

        #region Synchronous Root Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="Product"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Product"/>.</returns>    
        public static Product NewProduct()
        {
            return DataPortal.Create<Product>();
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="productId">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        public static Product GetByProductId(System.String productId)
        {
            var criteria = new ProductCriteria {ProductId = productId};
            
            
            return DataPortal.Fetch<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        public static Product GetByCategoryId(System.String categoryId)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId};
            
            
            return DataPortal.Fetch<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        public static Product GetByName(System.String name)
        {
            var criteria = new ProductCriteria {Name = name};
            
            
            return DataPortal.Fetch<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        public static Product GetByCategoryIdName(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, Name = name};
            
            
            return DataPortal.Fetch<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <param name="productId">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        public static Product GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, ProductId = productId, Name = name};
            
            
            return DataPortal.Fetch<Product>(criteria);
        }

        public static void DeleteProduct(System.String productId)
        {
            DataPortal.Delete<Product>(new ProductCriteria (productId));
        }

        #endregion

        #region Asynchronous Root Factory Methods

        public static async Task<Product> NewProductAsync()
        {
            return await DataPortal.CreateAsync<Product>();
        }

        public static async Task<Product> GetByProductIdAsync(System.String productId)
        {
            var criteria = new ProductCriteria{ ProductId = productId};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        public static async Task<Product> GetByCategoryIdAsync(System.String categoryId)
        {
            var criteria = new ProductCriteria{ CategoryId = categoryId};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        public static async Task<Product> GetByNameAsync(System.String name)
        {
            var criteria = new ProductCriteria{ Name = name};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        public static async Task<Product> GetByCategoryIdNameAsync(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria{ CategoryId = categoryId, Name = name};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        public static async Task<Product> GetByCategoryIdProductIdNameAsync(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria{ CategoryId = categoryId, ProductId = productId, Name = name};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        public static async Task DeleteProductAsync(System.String productId)
        {
            var criteria = new ProductCriteria{ProductId = productId};
            
            
            await DataPortal.DeleteAsync<Product>(criteria);
        }
        
        #endregion

        #region Synchronous Child Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="Product"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="Product"/>.</returns>
        internal static Product NewProductChild()
        {
            return DataPortal.CreateChild<Product>();
        }

        internal static Product GetProduct(SafeDataReader reader)
        {
            return DataPortal.FetchChild<Product>(reader);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="productId">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        internal static Product GetByProductIdChild(System.String productId)
        {
            var criteria = new ProductCriteria {ProductId = productId};
            

            return DataPortal.FetchChild<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        internal static Product GetByCategoryIdChild(System.String categoryId)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId};
            

            return DataPortal.FetchChild<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        internal static Product GetByNameChild(System.String name)
        {
            var criteria = new ProductCriteria {Name = name};
            

            return DataPortal.FetchChild<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        internal static Product GetByCategoryIdNameChild(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, Name = name};
            

            return DataPortal.FetchChild<Product>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="Product"/> object of the specified criteria. 
        /// </summary>
        /// <param name="categoryId">No additional detail available.</param>
        /// <param name="productId">No additional detail available.</param>
        /// <param name="name">No additional detail available.</param>
        /// <returns>A <see cref="Product"/> object of the specified criteria.</returns>
        internal static Product GetByCategoryIdProductIdNameChild(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, ProductId = productId, Name = name};
            

            return DataPortal.FetchChild<Product>(criteria);
        }

        #endregion

        #region Asynchronous Child Factory Methods

        internal static async Task<Product> NewProductChildAsync()
        {
            return await DataPortal.CreateAsync<Product>();
        }

        internal static async Task<Product> GetByProductIdChildAsync(System.String productId)
        {
            var criteria = new ProductCriteria{ ProductId = productId};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        internal static async Task<Product> GetByCategoryIdChildAsync(System.String categoryId)
        {
            var criteria = new ProductCriteria{ CategoryId = categoryId};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        internal static async Task<Product> GetByNameChildAsync(System.String name)
        {
            var criteria = new ProductCriteria{ Name = name};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        internal static async Task<Product> GetByCategoryIdNameChildAsync(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria{ CategoryId = categoryId, Name = name};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        internal static async Task<Product> GetByCategoryIdProductIdNameChildAsync(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria{ CategoryId = categoryId, ProductId = productId, Name = name};
            
            
            return await DataPortal.FetchAsync<Product>(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProductCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(ProductCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="Product"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProductCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(ProductCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="Product"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region ChildPortal partial methods


        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Product"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="ProductCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(ProductCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Product"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="Product"/> object. 
        /// </summary>
        partial void OnChildInserting(Category category, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Product"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="Product"/> object. 
        /// </summary>
        partial void OnChildUpdating(Category category, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Product"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="Product"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="Product"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();
        #endregion


        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the Product table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="Product"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(ProductCriteria criteria)
        {
            return PetShop.Tests.StoredProcedures.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the Product table in the database for the specified criteria. 
        /// </summary>
        public static async Task<bool> ExistsAsync(ProductCriteria criteria)
        {
            return await PetShop.Tests.StoredProcedures.ExistsCommand.ExecuteAsync(criteria);
        }

        #endregion

    }
}