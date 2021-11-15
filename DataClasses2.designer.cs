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

namespace LinqMvcApplication
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="newdb")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertemptable(emptable instance);
    partial void Updateemptable(emptable instance);
    partial void Deleteemptable(emptable instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["newdbConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<emptable> emptables
		{
			get
			{
				return this.GetTable<emptable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.emptable")]
	public partial class emptable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Empid;
		
		private string _Empname;
		
		private string _salary;
		
		private string _Email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpidChanging(int value);
    partial void OnEmpidChanged();
    partial void OnEmpnameChanging(string value);
    partial void OnEmpnameChanged();
    partial void OnsalaryChanging(string value);
    partial void OnsalaryChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public emptable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empid", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Empid
		{
			get
			{
				return this._Empid;
			}
			set
			{
				if ((this._Empid != value))
				{
					this.OnEmpidChanging(value);
					this.SendPropertyChanging();
					this._Empid = value;
					this.SendPropertyChanged("Empid");
					this.OnEmpidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Empname", DbType="VarChar(50)")]
		public string Empname
		{
			get
			{
				return this._Empname;
			}
			set
			{
				if ((this._Empname != value))
				{
					this.OnEmpnameChanging(value);
					this.SendPropertyChanging();
					this._Empname = value;
					this.SendPropertyChanged("Empname");
					this.OnEmpnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_salary", DbType="VarChar(50)")]
		public string salary
		{
			get
			{
				return this._salary;
			}
			set
			{
				if ((this._salary != value))
				{
					this.OnsalaryChanging(value);
					this.SendPropertyChanging();
					this._salary = value;
					this.SendPropertyChanged("salary");
					this.OnsalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
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