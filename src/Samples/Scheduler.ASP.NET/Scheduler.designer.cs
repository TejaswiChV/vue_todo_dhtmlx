﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulerNetAsp
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Scheduler")]
	public partial class SchedulerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEvent(Event instance);
    partial void UpdateEvent(Event instance);
    partial void DeleteEvent(Event instance);
    partial void InsertRecurring(Recurring instance);
    partial void UpdateRecurring(Recurring instance);
    partial void DeleteRecurring(Recurring instance);
    #endregion
		
		public SchedulerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["SchedulerConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SchedulerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Event> Events
		{
			get
			{
				return this.GetTable<Event>();
			}
		}
		
		public System.Data.Linq.Table<Recurring> Recurrings
		{
			get
			{
				return this.GetTable<Recurring>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Events")]
	public partial class Event : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _text;
		
		private System.Nullable<System.DateTime> _start_date;
		
		private System.Nullable<System.DateTime> _end_date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void Onstart_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onstart_dateChanged();
    partial void Onend_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onend_dateChanged();
    #endregion
		
		public Event()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> start_date
		{
			get
			{
				return this._start_date;
			}
			set
			{
				if ((this._start_date != value))
				{
					this.Onstart_dateChanging(value);
					this.SendPropertyChanging();
					this._start_date = value;
					this.SendPropertyChanged("start_date");
					this.Onstart_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> end_date
		{
			get
			{
				return this._end_date;
			}
			set
			{
				if ((this._end_date != value))
				{
					this.Onend_dateChanging(value);
					this.SendPropertyChanging();
					this._end_date = value;
					this.SendPropertyChanged("end_date");
					this.Onend_dateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Recurring")]
	public partial class Recurring : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _text;
		
		private System.Nullable<System.DateTime> _start_date;
		
		private System.Nullable<System.DateTime> _end_date;
		
		private System.Nullable<int> _event_length;
		
		private string _rec_type;
		
		private System.Nullable<int> _event_pid;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntextChanging(string value);
    partial void OntextChanged();
    partial void Onstart_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onstart_dateChanged();
    partial void Onend_dateChanging(System.Nullable<System.DateTime> value);
    partial void Onend_dateChanged();
    partial void Onevent_lengthChanging(System.Nullable<int> value);
    partial void Onevent_lengthChanged();
    partial void Onrec_typeChanging(string value);
    partial void Onrec_typeChanged();
    partial void Onevent_pidChanging(System.Nullable<int> value);
    partial void Onevent_pidChanged();
    #endregion
		
		public Recurring()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_text", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string text
		{
			get
			{
				return this._text;
			}
			set
			{
				if ((this._text != value))
				{
					this.OntextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("text");
					this.OntextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_start_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> start_date
		{
			get
			{
				return this._start_date;
			}
			set
			{
				if ((this._start_date != value))
				{
					this.Onstart_dateChanging(value);
					this.SendPropertyChanging();
					this._start_date = value;
					this.SendPropertyChanged("start_date");
					this.Onstart_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_end_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> end_date
		{
			get
			{
				return this._end_date;
			}
			set
			{
				if ((this._end_date != value))
				{
					this.Onend_dateChanging(value);
					this.SendPropertyChanging();
					this._end_date = value;
					this.SendPropertyChanged("end_date");
					this.Onend_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_event_length", DbType="Int")]
		public System.Nullable<int> event_length
		{
			get
			{
				return this._event_length;
			}
			set
			{
				if ((this._event_length != value))
				{
					this.Onevent_lengthChanging(value);
					this.SendPropertyChanging();
					this._event_length = value;
					this.SendPropertyChanged("event_length");
					this.Onevent_lengthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_rec_type", DbType="NVarChar(50)")]
		public string rec_type
		{
			get
			{
				return this._rec_type;
			}
			set
			{
				if ((this._rec_type != value))
				{
					this.Onrec_typeChanging(value);
					this.SendPropertyChanging();
					this._rec_type = value;
					this.SendPropertyChanged("rec_type");
					this.Onrec_typeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_event_pid", DbType="Int")]
		public System.Nullable<int> event_pid
		{
			get
			{
				return this._event_pid;
			}
			set
			{
				if ((this._event_pid != value))
				{
					this.Onevent_pidChanging(value);
					this.SendPropertyChanging();
					this._event_pid = value;
					this.SendPropertyChanged("event_pid");
					this.Onevent_pidChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
