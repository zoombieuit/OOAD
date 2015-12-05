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

namespace CoffeeManagement.DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CoffeeDB")]
	public partial class CoffeeDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBAN(BAN instance);
    partial void UpdateBAN(BAN instance);
    partial void DeleteBAN(BAN instance);
    partial void InsertKHU_VUC(KHU_VUC instance);
    partial void UpdateKHU_VUC(KHU_VUC instance);
    partial void DeleteKHU_VUC(KHU_VUC instance);
    partial void InsertMON(MON instance);
    partial void UpdateMON(MON instance);
    partial void DeleteMON(MON instance);
    partial void InsertNGUYEN_LIEU(NGUYEN_LIEU instance);
    partial void UpdateNGUYEN_LIEU(NGUYEN_LIEU instance);
    partial void DeleteNGUYEN_LIEU(NGUYEN_LIEU instance);
    partial void InsertLOAI_MON(LOAI_MON instance);
    partial void UpdateLOAI_MON(LOAI_MON instance);
    partial void DeleteLOAI_MON(LOAI_MON instance);
    #endregion
		
		public CoffeeDBDataContext() : 
				base(global::CoffeeManagement.Properties.Settings.Default.CoffeeDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CoffeeDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BAN> BANs
		{
			get
			{
				return this.GetTable<BAN>();
			}
		}
		
		public System.Data.Linq.Table<KHU_VUC> KHU_VUCs
		{
			get
			{
				return this.GetTable<KHU_VUC>();
			}
		}
		
		public System.Data.Linq.Table<MON> MONs
		{
			get
			{
				return this.GetTable<MON>();
			}
		}
		
		public System.Data.Linq.Table<NGUYEN_LIEU> NGUYEN_LIEUs
		{
			get
			{
				return this.GetTable<NGUYEN_LIEU>();
			}
		}
		
		public System.Data.Linq.Table<LOAI_MON> LOAI_MONs
		{
			get
			{
				return this.GetTable<LOAI_MON>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BAN")]
	public partial class BAN : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Ban;
		
		private string _Ten_Ban;
		
		private int _Trang_Thai;
		
		private int _ID_Khu_Vuc;
		
		private EntityRef<KHU_VUC> _KHU_VUC;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_BanChanging(int value);
    partial void OnID_BanChanged();
    partial void OnTen_BanChanging(string value);
    partial void OnTen_BanChanged();
    partial void OnTrang_ThaiChanging(int value);
    partial void OnTrang_ThaiChanged();
    partial void OnID_Khu_VucChanging(int value);
    partial void OnID_Khu_VucChanged();
    #endregion
		
		public BAN()
		{
			this._KHU_VUC = default(EntityRef<KHU_VUC>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Ban", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Ban
		{
			get
			{
				return this._ID_Ban;
			}
			set
			{
				if ((this._ID_Ban != value))
				{
					this.OnID_BanChanging(value);
					this.SendPropertyChanging();
					this._ID_Ban = value;
					this.SendPropertyChanged("ID_Ban");
					this.OnID_BanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Ban", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ten_Ban
		{
			get
			{
				return this._Ten_Ban;
			}
			set
			{
				if ((this._Ten_Ban != value))
				{
					this.OnTen_BanChanging(value);
					this.SendPropertyChanging();
					this._Ten_Ban = value;
					this.SendPropertyChanged("Ten_Ban");
					this.OnTen_BanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Trang_Thai", DbType="Int NOT NULL")]
		public int Trang_Thai
		{
			get
			{
				return this._Trang_Thai;
			}
			set
			{
				if ((this._Trang_Thai != value))
				{
					this.OnTrang_ThaiChanging(value);
					this.SendPropertyChanging();
					this._Trang_Thai = value;
					this.SendPropertyChanged("Trang_Thai");
					this.OnTrang_ThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Khu_Vuc", DbType="Int NOT NULL")]
		public int ID_Khu_Vuc
		{
			get
			{
				return this._ID_Khu_Vuc;
			}
			set
			{
				if ((this._ID_Khu_Vuc != value))
				{
					if (this._KHU_VUC.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_Khu_VucChanging(value);
					this.SendPropertyChanging();
					this._ID_Khu_Vuc = value;
					this.SendPropertyChanged("ID_Khu_Vuc");
					this.OnID_Khu_VucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHU_VUC_BAN", Storage="_KHU_VUC", ThisKey="ID_Khu_Vuc", OtherKey="ID_Khu_Vuc", IsForeignKey=true)]
		public KHU_VUC KHU_VUC
		{
			get
			{
				return this._KHU_VUC.Entity;
			}
			set
			{
				KHU_VUC previousValue = this._KHU_VUC.Entity;
				if (((previousValue != value) 
							|| (this._KHU_VUC.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHU_VUC.Entity = null;
						previousValue.BANs.Remove(this);
					}
					this._KHU_VUC.Entity = value;
					if ((value != null))
					{
						value.BANs.Add(this);
						this._ID_Khu_Vuc = value.ID_Khu_Vuc;
					}
					else
					{
						this._ID_Khu_Vuc = default(int);
					}
					this.SendPropertyChanged("KHU_VUC");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHU_VUC")]
	public partial class KHU_VUC : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Khu_Vuc;
		
		private string _Ten_Khu_Vuc;
		
		private EntitySet<BAN> _BANs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_Khu_VucChanging(int value);
    partial void OnID_Khu_VucChanged();
    partial void OnTen_Khu_VucChanging(string value);
    partial void OnTen_Khu_VucChanged();
    #endregion
		
		public KHU_VUC()
		{
			this._BANs = new EntitySet<BAN>(new Action<BAN>(this.attach_BANs), new Action<BAN>(this.detach_BANs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Khu_Vuc", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Khu_Vuc
		{
			get
			{
				return this._ID_Khu_Vuc;
			}
			set
			{
				if ((this._ID_Khu_Vuc != value))
				{
					this.OnID_Khu_VucChanging(value);
					this.SendPropertyChanging();
					this._ID_Khu_Vuc = value;
					this.SendPropertyChanged("ID_Khu_Vuc");
					this.OnID_Khu_VucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Khu_Vuc", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ten_Khu_Vuc
		{
			get
			{
				return this._Ten_Khu_Vuc;
			}
			set
			{
				if ((this._Ten_Khu_Vuc != value))
				{
					this.OnTen_Khu_VucChanging(value);
					this.SendPropertyChanging();
					this._Ten_Khu_Vuc = value;
					this.SendPropertyChanged("Ten_Khu_Vuc");
					this.OnTen_Khu_VucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHU_VUC_BAN", Storage="_BANs", ThisKey="ID_Khu_Vuc", OtherKey="ID_Khu_Vuc")]
		public EntitySet<BAN> BANs
		{
			get
			{
				return this._BANs;
			}
			set
			{
				this._BANs.Assign(value);
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
		
		private void attach_BANs(BAN entity)
		{
			this.SendPropertyChanging();
			entity.KHU_VUC = this;
		}
		
		private void detach_BANs(BAN entity)
		{
			this.SendPropertyChanging();
			entity.KHU_VUC = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MON")]
	public partial class MON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Mon;
		
		private string _Ten_Mon;
		
		private System.Nullable<int> _ID_Loai_Mon;
		
		private System.Nullable<decimal> _Don_Gia;
		
		private System.Data.Linq.Binary _Hinh_Anh;
		
		private EntityRef<LOAI_MON> _LOAI_MON;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_MonChanging(int value);
    partial void OnID_MonChanged();
    partial void OnTen_MonChanging(string value);
    partial void OnTen_MonChanged();
    partial void OnID_Loai_MonChanging(System.Nullable<int> value);
    partial void OnID_Loai_MonChanged();
    partial void OnDon_GiaChanging(System.Nullable<decimal> value);
    partial void OnDon_GiaChanged();
    partial void OnHinh_AnhChanging(System.Data.Linq.Binary value);
    partial void OnHinh_AnhChanged();
    #endregion
		
		public MON()
		{
			this._LOAI_MON = default(EntityRef<LOAI_MON>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Mon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Mon
		{
			get
			{
				return this._ID_Mon;
			}
			set
			{
				if ((this._ID_Mon != value))
				{
					this.OnID_MonChanging(value);
					this.SendPropertyChanging();
					this._ID_Mon = value;
					this.SendPropertyChanged("ID_Mon");
					this.OnID_MonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Mon", DbType="NVarChar(50)")]
		public string Ten_Mon
		{
			get
			{
				return this._Ten_Mon;
			}
			set
			{
				if ((this._Ten_Mon != value))
				{
					this.OnTen_MonChanging(value);
					this.SendPropertyChanging();
					this._Ten_Mon = value;
					this.SendPropertyChanged("Ten_Mon");
					this.OnTen_MonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Loai_Mon", DbType="Int")]
		public System.Nullable<int> ID_Loai_Mon
		{
			get
			{
				return this._ID_Loai_Mon;
			}
			set
			{
				if ((this._ID_Loai_Mon != value))
				{
					if (this._LOAI_MON.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnID_Loai_MonChanging(value);
					this.SendPropertyChanging();
					this._ID_Loai_Mon = value;
					this.SendPropertyChanged("ID_Loai_Mon");
					this.OnID_Loai_MonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Don_Gia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Don_Gia
		{
			get
			{
				return this._Don_Gia;
			}
			set
			{
				if ((this._Don_Gia != value))
				{
					this.OnDon_GiaChanging(value);
					this.SendPropertyChanging();
					this._Don_Gia = value;
					this.SendPropertyChanged("Don_Gia");
					this.OnDon_GiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hinh_Anh", DbType="Image NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary Hinh_Anh
		{
			get
			{
				return this._Hinh_Anh;
			}
			set
			{
				if ((this._Hinh_Anh != value))
				{
					this.OnHinh_AnhChanging(value);
					this.SendPropertyChanging();
					this._Hinh_Anh = value;
					this.SendPropertyChanged("Hinh_Anh");
					this.OnHinh_AnhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_MON_MON", Storage="_LOAI_MON", ThisKey="ID_Loai_Mon", OtherKey="ID_Loai_Mon", IsForeignKey=true)]
		public LOAI_MON LOAI_MON
		{
			get
			{
				return this._LOAI_MON.Entity;
			}
			set
			{
				LOAI_MON previousValue = this._LOAI_MON.Entity;
				if (((previousValue != value) 
							|| (this._LOAI_MON.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LOAI_MON.Entity = null;
						previousValue.MONs.Remove(this);
					}
					this._LOAI_MON.Entity = value;
					if ((value != null))
					{
						value.MONs.Add(this);
						this._ID_Loai_Mon = value.ID_Loai_Mon;
					}
					else
					{
						this._ID_Loai_Mon = default(Nullable<int>);
					}
					this.SendPropertyChanged("LOAI_MON");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NGUYEN_LIEU")]
	public partial class NGUYEN_LIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Nguyen_Lieu;
		
		private string _Ten_Nguyen_Lieu;
		
		private System.Nullable<int> _So_Luong_Ton;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_Nguyen_LieuChanging(int value);
    partial void OnID_Nguyen_LieuChanged();
    partial void OnTen_Nguyen_LieuChanging(string value);
    partial void OnTen_Nguyen_LieuChanged();
    partial void OnSo_Luong_TonChanging(System.Nullable<int> value);
    partial void OnSo_Luong_TonChanged();
    #endregion
		
		public NGUYEN_LIEU()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Nguyen_Lieu", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Nguyen_Lieu
		{
			get
			{
				return this._ID_Nguyen_Lieu;
			}
			set
			{
				if ((this._ID_Nguyen_Lieu != value))
				{
					this.OnID_Nguyen_LieuChanging(value);
					this.SendPropertyChanging();
					this._ID_Nguyen_Lieu = value;
					this.SendPropertyChanged("ID_Nguyen_Lieu");
					this.OnID_Nguyen_LieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Nguyen_Lieu", DbType="NVarChar(50)")]
		public string Ten_Nguyen_Lieu
		{
			get
			{
				return this._Ten_Nguyen_Lieu;
			}
			set
			{
				if ((this._Ten_Nguyen_Lieu != value))
				{
					this.OnTen_Nguyen_LieuChanging(value);
					this.SendPropertyChanging();
					this._Ten_Nguyen_Lieu = value;
					this.SendPropertyChanged("Ten_Nguyen_Lieu");
					this.OnTen_Nguyen_LieuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_So_Luong_Ton", DbType="Int")]
		public System.Nullable<int> So_Luong_Ton
		{
			get
			{
				return this._So_Luong_Ton;
			}
			set
			{
				if ((this._So_Luong_Ton != value))
				{
					this.OnSo_Luong_TonChanging(value);
					this.SendPropertyChanging();
					this._So_Luong_Ton = value;
					this.SendPropertyChanged("So_Luong_Ton");
					this.OnSo_Luong_TonChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LOAI_MON")]
	public partial class LOAI_MON : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID_Loai_Mon;
		
		private string _Ten_Loai_Mon;
		
		private EntitySet<MON> _MONs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnID_Loai_MonChanging(int value);
    partial void OnID_Loai_MonChanged();
    partial void OnTen_Loai_MonChanging(string value);
    partial void OnTen_Loai_MonChanged();
    #endregion
		
		public LOAI_MON()
		{
			this._MONs = new EntitySet<MON>(new Action<MON>(this.attach_MONs), new Action<MON>(this.detach_MONs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID_Loai_Mon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID_Loai_Mon
		{
			get
			{
				return this._ID_Loai_Mon;
			}
			set
			{
				if ((this._ID_Loai_Mon != value))
				{
					this.OnID_Loai_MonChanging(value);
					this.SendPropertyChanging();
					this._ID_Loai_Mon = value;
					this.SendPropertyChanged("ID_Loai_Mon");
					this.OnID_Loai_MonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ten_Loai_Mon", DbType="NVarChar(50)")]
		public string Ten_Loai_Mon
		{
			get
			{
				return this._Ten_Loai_Mon;
			}
			set
			{
				if ((this._Ten_Loai_Mon != value))
				{
					this.OnTen_Loai_MonChanging(value);
					this.SendPropertyChanging();
					this._Ten_Loai_Mon = value;
					this.SendPropertyChanged("Ten_Loai_Mon");
					this.OnTen_Loai_MonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LOAI_MON_MON", Storage="_MONs", ThisKey="ID_Loai_Mon", OtherKey="ID_Loai_Mon")]
		public EntitySet<MON> MONs
		{
			get
			{
				return this._MONs;
			}
			set
			{
				this._MONs.Assign(value);
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
		
		private void attach_MONs(MON entity)
		{
			this.SendPropertyChanging();
			entity.LOAI_MON = this;
		}
		
		private void detach_MONs(MON entity)
		{
			this.SendPropertyChanging();
			entity.LOAI_MON = null;
		}
	}
}
#pragma warning restore 1591