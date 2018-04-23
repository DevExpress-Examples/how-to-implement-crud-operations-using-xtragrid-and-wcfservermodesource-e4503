﻿' Developer Express Code Central Example:
' How to implement CRUD operations using XtraGrid and WCF Data Services
' 
' This example is similar to the http://www.devexpress.com/scid=E3866 example and
' demonstrates how to implement CRUD operations using XtraGrid and WCF Data
' Services.
' 
' This example works with the standard SQL Northwind database.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4365

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17929
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

' Original file name:
' Generation date: 11/22/2012 6:50:05 PM

Imports Microsoft.VisualBasic
Imports System
Namespace Example.ServiceReference1

	''' <summary>
	''' There are no comments for NorthwindEntities in the schema.
	''' </summary>
	Partial Public Class NorthwindEntities
		Inherits System.Data.Services.Client.DataServiceContext
		''' <summary>
		''' Initialize a new NorthwindEntities object.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Sub New(ByVal serviceRoot As Global.System.Uri)
			MyBase.New(serviceRoot)
			Me.ResolveName = New Global.System.Func(Of Global.System.Type, String)(AddressOf Me.ResolveNameFromType)
			Me.ResolveType = New Global.System.Func(Of String, Global.System.Type)(AddressOf Me.ResolveTypeFromName)
			Me.OnContextCreated()
		End Sub
		Partial Private Sub OnContextCreated()
		End Sub
		''' <summary>
		''' Since the namespace configured for this service reference
		''' in Visual Studio is different from the one indicated in the
		''' server schema, use type-mappers to map between the two.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
			If typeName.StartsWith("NorthwindModel", Global.System.StringComparison.Ordinal) Then
				Return Me.GetType().Assembly.GetType(String.Concat("Example.ServiceReference1", typeName.Substring(14)), False)
			End If
			Return Nothing
		End Function
		''' <summary>
		''' Since the namespace configured for this service reference
		''' in Visual Studio is different from the one indicated in the
		''' server schema, use type-mappers to map between the two.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
			If clientType.Namespace.Equals("Example.ServiceReference1", Global.System.StringComparison.Ordinal) Then
				Return String.Concat("NorthwindModel.", clientType.Name)
			End If
			Return Nothing
		End Function
		''' <summary>
		''' There are no comments for Customers in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public ReadOnly Property Customers() As Global.System.Data.Services.Client.DataServiceQuery(Of Customers)
			Get
				If (Me._Customers Is Nothing) Then
					Me._Customers = MyBase.CreateQuery(Of Customers)("Customers")
				End If
				Return Me._Customers
			End Get
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Customers As Global.System.Data.Services.Client.DataServiceQuery(Of Customers)
		''' <summary>
		''' There are no comments for Customers in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Sub AddToCustomers(ByVal customers As Customers)
			MyBase.AddObject("Customers", customers)
		End Sub
	End Class
	''' <summary>
	''' There are no comments for NorthwindModel.Customers in the schema.
	''' </summary>
	''' <KeyProperties>
	''' CustomerID
	''' </KeyProperties>
	<Global.System.Data.Services.Common.EntitySetAttribute("Customers"), Global.System.Data.Services.Common.DataServiceKeyAttribute("CustomerID")> _
	Partial Public Class Customers
		Implements System.ComponentModel.INotifyPropertyChanged
		''' <summary>
		''' Create a new Customers object.
		''' </summary>
		''' <param name="customerID">Initial value of CustomerID.</param>
		''' <param name="companyName">Initial value of CompanyName.</param>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Shared Function CreateCustomers(ByVal customerID As String, ByVal companyName As String) As Customers
			Dim customers As New Customers()
			customers.CustomerID = customerID
			customers.CompanyName = companyName
			Return customers
		End Function
		''' <summary>
		''' There are no comments for Property CustomerID in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property CustomerID() As String
			Get
				Return Me._CustomerID
			End Get
			Set(ByVal value As String)
				Me.OnCustomerIDChanging(value)
				Me._CustomerID = value
				Me.OnCustomerIDChanged()
				Me.OnPropertyChanged("CustomerID")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _CustomerID As String
		Partial Private Sub OnCustomerIDChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnCustomerIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property CompanyName in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property CompanyName() As String
			Get
				Return Me._CompanyName
			End Get
			Set(ByVal value As String)
				Me.OnCompanyNameChanging(value)
				Me._CompanyName = value
				Me.OnCompanyNameChanged()
				Me.OnPropertyChanged("CompanyName")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _CompanyName As String
		Partial Private Sub OnCompanyNameChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnCompanyNameChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ContactName in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property ContactName() As String
			Get
				Return Me._ContactName
			End Get
			Set(ByVal value As String)
				Me.OnContactNameChanging(value)
				Me._ContactName = value
				Me.OnContactNameChanged()
				Me.OnPropertyChanged("ContactName")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _ContactName As String
		Partial Private Sub OnContactNameChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnContactNameChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ContactTitle in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property ContactTitle() As String
			Get
				Return Me._ContactTitle
			End Get
			Set(ByVal value As String)
				Me.OnContactTitleChanging(value)
				Me._ContactTitle = value
				Me.OnContactTitleChanged()
				Me.OnPropertyChanged("ContactTitle")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _ContactTitle As String
		Partial Private Sub OnContactTitleChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnContactTitleChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Address in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Address() As String
			Get
				Return Me._Address
			End Get
			Set(ByVal value As String)
				Me.OnAddressChanging(value)
				Me._Address = value
				Me.OnAddressChanged()
				Me.OnPropertyChanged("Address")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Address As String
		Partial Private Sub OnAddressChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnAddressChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property City in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property City() As String
			Get
				Return Me._City
			End Get
			Set(ByVal value As String)
				Me.OnCityChanging(value)
				Me._City = value
				Me.OnCityChanged()
				Me.OnPropertyChanged("City")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _City As String
		Partial Private Sub OnCityChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnCityChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Region in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Region() As String
			Get
				Return Me._Region
			End Get
			Set(ByVal value As String)
				Me.OnRegionChanging(value)
				Me._Region = value
				Me.OnRegionChanged()
				Me.OnPropertyChanged("Region")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Region As String
		Partial Private Sub OnRegionChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnRegionChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property PostalCode in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property PostalCode() As String
			Get
				Return Me._PostalCode
			End Get
			Set(ByVal value As String)
				Me.OnPostalCodeChanging(value)
				Me._PostalCode = value
				Me.OnPostalCodeChanged()
				Me.OnPropertyChanged("PostalCode")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _PostalCode As String
		Partial Private Sub OnPostalCodeChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnPostalCodeChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Country in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Country() As String
			Get
				Return Me._Country
			End Get
			Set(ByVal value As String)
				Me.OnCountryChanging(value)
				Me._Country = value
				Me.OnCountryChanged()
				Me.OnPropertyChanged("Country")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Country As String
		Partial Private Sub OnCountryChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnCountryChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Phone in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Phone() As String
			Get
				Return Me._Phone
			End Get
			Set(ByVal value As String)
				Me.OnPhoneChanging(value)
				Me._Phone = value
				Me.OnPhoneChanged()
				Me.OnPropertyChanged("Phone")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Phone As String
		Partial Private Sub OnPhoneChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnPhoneChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Fax in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Fax() As String
			Get
				Return Me._Fax
			End Get
			Set(ByVal value As String)
				Me.OnFaxChanging(value)
				Me._Fax = value
				Me.OnFaxChanged()
				Me.OnPropertyChanged("Fax")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Fax As String
		Partial Private Sub OnFaxChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnFaxChanged()
		End Sub
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
			End If
		End Sub
	End Class
End Namespace
