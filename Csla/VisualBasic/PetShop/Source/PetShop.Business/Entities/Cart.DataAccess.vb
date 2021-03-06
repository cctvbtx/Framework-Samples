﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
'     Changes to this file will be lost after each regeneration.
'     To extend the functionality of this class, please modify the partial class 'Cart.vb.
'
'     Template: EditableChild.DataAccess.ParameterizedSQL.cst
'     Template website: http://code.google.com/p/codesmith/
' </autogenerated>
'------------------------------------------------------------------------------
Option Explicit On
Option Strict On
#If Not SILVERLIGHT Then

Imports System
Imports System.Data
Imports System.Data.SqlClient

Imports Csla
Imports Csla.Data

Namespace PetShop.Business
    Public Partial Class Cart
        <RunLocal()> _
        Protected Overrides Sub Child_Create()
            Dim cancel As Boolean = False
            OnChildCreating(cancel)
            If (cancel) Then
                Return
            End If
    

            BusinessRules.CheckRules()
    
            OnChildCreated()
        End Sub
        
        Private Sub Child_Fetch(ByVal criteria As CartCriteria)
            Dim cancel As Boolean = False
            OnChildFetching(criteria, cancel)
            If (cancel) Then
                Return
            End If
    
            Dim commandText As String = String.Format("SELECT [CartId], [UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity] FROM [dbo].[Cart] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using connection As New SqlConnection(ADOHelper.ConnectionString)
                connection.Open()
                Using command As New SqlCommand(commandText, connection)
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
                    Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                        If reader.Read() Then
                            Map(reader)
                        Else
                            Throw New Exception(String.Format("The record was not found In 'dbo.Cart' using the following criteria: {0}.", criteria))
                        End If
                    End Using
                End Using
            End Using
    
            OnChildFetched()
        End Sub
    
#Region "Child_Insert"
    
        Private Sub Child_Insert(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Cart] ([UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity]) VALUES (@p_UniqueID, @p_ItemId, @p_Name, @p_Type, @p_Price, @p_CategoryId, @p_ProductId, @p_IsShoppingCart, @p_Quantity); SELECT [CartId] FROM [dbo].[Cart] WHERE CartId = SCOPE_IDENTITY()"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UniqueID", Me.UniqueID)
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
                command.Parameters.AddWithValue("@p_Name", Me.Name)
                command.Parameters.AddWithValue("@p_Type", Me.Type)
                command.Parameters.AddWithValue("@p_Price", Me.Price)
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
                command.Parameters.AddWithValue("@p_IsShoppingCart", Me.IsShoppingCart)
                command.Parameters.AddWithValue("@p_Quantity", Me.Quantity)
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
    
                        ' Update identity or guid primary key value.
                        LoadProperty(_cartIdProperty, reader.GetInt32("CartId"))
                    End If
                End Using
            End Using
    
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
        Private Sub Child_Insert(ByVal profile As Profile, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildInserting(profile, connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not (connection.State = ConnectionState.Open) Then connection.Open()
            Const commandText As String = "INSERT INTO [dbo].[Cart] ([UniqueID], [ItemId], [Name], [Type], [Price], [CategoryId], [ProductId], [IsShoppingCart], [Quantity]) VALUES (@p_UniqueID, @p_ItemId, @p_Name, @p_Type, @p_Price, @p_CategoryId, @p_ProductId, @p_IsShoppingCart, @p_Quantity); SELECT [CartId] FROM [dbo].[Cart] WHERE CartId = SCOPE_IDENTITY()"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_UniqueID", If(Not(profile Is Nothing), profile.UniqueID, Me.UniqueID))
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
                command.Parameters.AddWithValue("@p_Name", Me.Name)
                command.Parameters.AddWithValue("@p_Type", Me.Type)
                command.Parameters.AddWithValue("@p_Price", Me.Price)
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
                command.Parameters.AddWithValue("@p_IsShoppingCart", Me.IsShoppingCart)
                command.Parameters.AddWithValue("@p_Quantity", Me.Quantity)
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
    
                        ' Update identity or guid primary key value.
                        LoadProperty(_cartIdProperty, reader.GetInt32("CartId"))
                    End If
                End Using
            End Using
    
            ' Update foreign keys values. This code will update the values passed In from the parent only if no errors occurred after executing the query.
            If(Not IsNothing(profile) AndAlso Not profile.UniqueID = Me.UniqueID) Then
                LoadProperty(_uniqueIDProperty, profile.UniqueID)
            End If
    
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildInserted() and insert this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildInserted()
        End Sub
    
    
#End Region
    
#Region "Child_Update"
    
        Private Sub Child_Update(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Cart] SET [UniqueID] = @p_UniqueID, [ItemId] = @p_ItemId, [Name] = @p_Name, [Type] = @p_Type, [Price] = @p_Price, [CategoryId] = @p_CategoryId, [ProductId] = @p_ProductId, [IsShoppingCart] = @p_IsShoppingCart, [Quantity] = @p_Quantity WHERE [CartId] = @p_CartId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_CartId", Me.CartId)
                command.Parameters.AddWithValue("@p_UniqueID", Me.UniqueID)
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
                command.Parameters.AddWithValue("@p_Name", Me.Name)
                command.Parameters.AddWithValue("@p_Type", Me.Type)
                command.Parameters.AddWithValue("@p_Price", Me.Price)
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
                command.Parameters.AddWithValue("@p_IsShoppingCart", Me.IsShoppingCart)
                command.Parameters.AddWithValue("@p_Quantity", Me.Quantity)
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                    End If
                End Using
    
            End Using
            FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
        Private Sub Child_Update(ByVal profile As Profile, ByVal connection As SqlConnection)
            Dim cancel As Boolean = False
            OnChildUpdating(profile, connection, cancel)
            If (cancel) Then
                Return
            End If

            If Not connection.State = ConnectionState.Open Then connection.Open()
            Const commandText As String = "UPDATE [dbo].[Cart] SET [UniqueID] = @p_UniqueID, [ItemId] = @p_ItemId, [Name] = @p_Name, [Type] = @p_Type, [Price] = @p_Price, [CategoryId] = @p_CategoryId, [ProductId] = @p_ProductId, [IsShoppingCart] = @p_IsShoppingCart, [Quantity] = @p_Quantity WHERE [CartId] = @p_CartId"
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddWithValue("@p_CartId", Me.CartId)
                command.Parameters.AddWithValue("@p_UniqueID", If(Not(profile Is Nothing), profile.UniqueID, Me.UniqueID))
                command.Parameters.AddWithValue("@p_ItemId", Me.ItemId)
                command.Parameters.AddWithValue("@p_Name", Me.Name)
                command.Parameters.AddWithValue("@p_Type", Me.Type)
                command.Parameters.AddWithValue("@p_Price", Me.Price)
                command.Parameters.AddWithValue("@p_CategoryId", Me.CategoryId)
                command.Parameters.AddWithValue("@p_ProductId", Me.ProductId)
                command.Parameters.AddWithValue("@p_IsShoppingCart", Me.IsShoppingCart)
                command.Parameters.AddWithValue("@p_Quantity", Me.Quantity)
    
                Using reader As SafeDataReader = New SafeDataReader(command.ExecuteReader())
                    If reader.Read() Then
                    End If
                End Using
    
                ' Update foreign keys values. This code will update the values passed In from the parent only if no errors occurred after executing the query.
                If(Not IsNothing(profile) AndAlso Not profile.UniqueID = Me.UniqueID) Then
                    LoadProperty(_uniqueIDProperty, profile.UniqueID)
                End If
    
            End Using
            ' A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            ' TODO: Please override OnChildUpdated() and update this child manually.
            'FieldManager.UpdateChildren(Me, connection)
    
            OnChildUpdated()
        End Sub
    
    
#End Region
    
    Private Sub Child_DeleteSelf(ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnChildSelfDeleting(connection, cancel)
            If (cancel) Then
                Return
            End If
        
            DataPortal_Delete(New CartCriteria (CartId), connection)
        
            OnChildSelfDeleted()
        End Sub
        
        Protected Shadows Sub DataPortal_Delete(ByVal criteria As CartCriteria, ByVal connection as SqlConnection)
            Dim cancel As Boolean = False
            OnDeleting(criteria, connection, cancel)
            If (cancel) Then
                Return
            End If

            Dim commandText As String = String.Format("DELETE FROM [dbo].[Cart] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag))
            Using command As New SqlCommand(commandText, connection)
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag))
    
                'result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                Dim result As Integer = command.ExecuteNonQuery()
                If result = 0 Then
                    Throw New DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.")
                End If
    
            End Using
    
        OnDeleted()
        End Sub
        
#Region "Map"

        Private Sub Map(ByVal reader As SafeDataReader)
            Dim cancel As Boolean = False
            OnMapping(reader, cancel)
            If (cancel) Then
                Return
            End If
    
            Using(BypassPropertyChecks)
                LoadProperty(_cartIdProperty, reader.Item("CartId"))
                LoadProperty(_uniqueIDProperty, reader.Item("UniqueID"))
                LoadProperty(_itemIdProperty, reader.Item("ItemId"))
                LoadProperty(_nameProperty, reader.Item("Name"))
                LoadProperty(_typeProperty, reader.Item("Type"))
                LoadProperty(_priceProperty, reader.Item("Price"))
                LoadProperty(_categoryIdProperty, reader.Item("CategoryId"))
                LoadProperty(_productIdProperty, reader.Item("ProductId"))
                LoadProperty(_isShoppingCartProperty, reader.Item("IsShoppingCart"))
                LoadProperty(_quantityProperty, reader.Item("Quantity"))
            End Using
    
            OnMapped()
        End Sub

        Private Sub Child_Fetch(reader As SafeDataReader)
            Map(reader)
        End Sub

#End Region
    End Class
End Namespace
#End If
