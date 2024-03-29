﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Scheduler")>  _
Partial Public Class SchedulerDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertEvent(instance As [Event])
    End Sub
  Partial Private Sub UpdateEvent(instance As [Event])
    End Sub
  Partial Private Sub DeleteEvent(instance As [Event])
    End Sub
  Partial Private Sub InsertRecurring(instance As Recurring)
    End Sub
  Partial Private Sub UpdateRecurring(instance As Recurring)
    End Sub
  Partial Private Sub DeleteRecurring(instance As Recurring)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("SchedulerConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Events() As System.Data.Linq.Table(Of [Event])
		Get
			Return Me.GetTable(Of [Event])
		End Get
	End Property
	
	Public ReadOnly Property Recurrings() As System.Data.Linq.Table(Of Recurring)
		Get
			Return Me.GetTable(Of Recurring)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Events")>  _
Partial Public Class [Event]
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _text As String
	
	Private _start_date As System.Nullable(Of Date)
	
	Private _end_date As System.Nullable(Of Date)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OntextChanging(value As String)
    End Sub
    Partial Private Sub OntextChanged()
    End Sub
    Partial Private Sub Onstart_dateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub Onstart_dateChanged()
    End Sub
    Partial Private Sub Onend_dateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub Onend_dateChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_text", DbType:="NVarChar(250)")>  _
	Public Property text() As String
		Get
			Return Me._text
		End Get
		Set
			If (String.Equals(Me._text, value) = false) Then
				Me.OntextChanging(value)
				Me.SendPropertyChanging
				Me._text = value
				Me.SendPropertyChanged("text")
				Me.OntextChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_start_date", DbType:="DateTime")>  _
	Public Property start_date() As System.Nullable(Of Date)
		Get
			Return Me._start_date
		End Get
		Set
			If (Me._start_date.Equals(value) = false) Then
				Me.Onstart_dateChanging(value)
				Me.SendPropertyChanging
				Me._start_date = value
				Me.SendPropertyChanged("start_date")
				Me.Onstart_dateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_end_date", DbType:="DateTime")>  _
	Public Property end_date() As System.Nullable(Of Date)
		Get
			Return Me._end_date
		End Get
		Set
			If (Me._end_date.Equals(value) = false) Then
				Me.Onend_dateChanging(value)
				Me.SendPropertyChanging
				Me._end_date = value
				Me.SendPropertyChanged("end_date")
				Me.Onend_dateChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Recurring")>  _
Partial Public Class Recurring
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _id As Integer
	
	Private _text As String
	
	Private _start_date As System.Nullable(Of Date)
	
	Private _end_date As System.Nullable(Of Date)
	
	Private _event_length As System.Nullable(Of Integer)
	
	Private _rec_type As String
	
	Private _event_pid As System.Nullable(Of Integer)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnidChanging(value As Integer)
    End Sub
    Partial Private Sub OnidChanged()
    End Sub
    Partial Private Sub OntextChanging(value As String)
    End Sub
    Partial Private Sub OntextChanged()
    End Sub
    Partial Private Sub Onstart_dateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub Onstart_dateChanged()
    End Sub
    Partial Private Sub Onend_dateChanging(value As System.Nullable(Of Date))
    End Sub
    Partial Private Sub Onend_dateChanged()
    End Sub
    Partial Private Sub Onevent_lengthChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub Onevent_lengthChanged()
    End Sub
    Partial Private Sub Onrec_typeChanging(value As String)
    End Sub
    Partial Private Sub Onrec_typeChanged()
    End Sub
    Partial Private Sub Onevent_pidChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub Onevent_pidChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property id() As Integer
		Get
			Return Me._id
		End Get
		Set
			If ((Me._id = value)  _
						= false) Then
				Me.OnidChanging(value)
				Me.SendPropertyChanging
				Me._id = value
				Me.SendPropertyChanged("id")
				Me.OnidChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_text", DbType:="Text", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property text() As String
		Get
			Return Me._text
		End Get
		Set
			If (String.Equals(Me._text, value) = false) Then
				Me.OntextChanging(value)
				Me.SendPropertyChanging
				Me._text = value
				Me.SendPropertyChanged("text")
				Me.OntextChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_start_date", DbType:="DateTime")>  _
	Public Property start_date() As System.Nullable(Of Date)
		Get
			Return Me._start_date
		End Get
		Set
			If (Me._start_date.Equals(value) = false) Then
				Me.Onstart_dateChanging(value)
				Me.SendPropertyChanging
				Me._start_date = value
				Me.SendPropertyChanged("start_date")
				Me.Onstart_dateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_end_date", DbType:="DateTime")>  _
	Public Property end_date() As System.Nullable(Of Date)
		Get
			Return Me._end_date
		End Get
		Set
			If (Me._end_date.Equals(value) = false) Then
				Me.Onend_dateChanging(value)
				Me.SendPropertyChanging
				Me._end_date = value
				Me.SendPropertyChanged("end_date")
				Me.Onend_dateChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_event_length", DbType:="Int")>  _
	Public Property event_length() As System.Nullable(Of Integer)
		Get
			Return Me._event_length
		End Get
		Set
			If (Me._event_length.Equals(value) = false) Then
				Me.Onevent_lengthChanging(value)
				Me.SendPropertyChanging
				Me._event_length = value
				Me.SendPropertyChanged("event_length")
				Me.Onevent_lengthChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_rec_type", DbType:="NVarChar(50)")>  _
	Public Property rec_type() As String
		Get
			Return Me._rec_type
		End Get
		Set
			If (String.Equals(Me._rec_type, value) = false) Then
				Me.Onrec_typeChanging(value)
				Me.SendPropertyChanging
				Me._rec_type = value
				Me.SendPropertyChanged("rec_type")
				Me.Onrec_typeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_event_pid", DbType:="Int")>  _
	Public Property event_pid() As System.Nullable(Of Integer)
		Get
			Return Me._event_pid
		End Get
		Set
			If (Me._event_pid.Equals(value) = false) Then
				Me.Onevent_pidChanging(value)
				Me.SendPropertyChanging
				Me._event_pid = value
				Me.SendPropertyChanged("event_pid")
				Me.Onevent_pidChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class
