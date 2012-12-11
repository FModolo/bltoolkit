﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by BLToolkit template for T4.
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;

using BLToolkit.Data;
using BLToolkit.Data.Linq;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Validation;

namespace MySqlDataModel
{
	public partial class MySqlDataContext : DbManager
	{
		public Table<binarydata>    binarydata    { get { return this.GetTable<binarydata>();    } }
		public Table<child>         child         { get { return this.GetTable<child>();         } }
		public Table<datatypetest>  datatypetest  { get { return this.GetTable<datatypetest>();  } }
		public Table<doctor>        doctor        { get { return this.GetTable<doctor>();        } }
		public Table<grandchild>    grandchild    { get { return this.GetTable<grandchild>();    } }
		public Table<linqdatatypes> linqdatatypes { get { return this.GetTable<linqdatatypes>(); } }
		public Table<parent>        parent        { get { return this.GetTable<parent>();        } }
		public Table<patient>       patient       { get { return this.GetTable<patient>();       } }
		public Table<person>        person        { get { return this.GetTable<person>();        } }
		public Table<testidentity>  testidentity  { get { return this.GetTable<testidentity>();  } }
	}

	[TableName(Name="binarydata")]
	public partial class binarydata
	{
		[Identity, PrimaryKey(1), Required                                                ] public int      BinaryDataID { get; set; } // int(10)
		[                         NonUpdatable(OnInsert = true, OnUpdate = true), Required] public DateTime Stamp        { get; set; } // timestamp
		[                         Required                                                ] public byte[]   Data         { get; set; } // varbinary(1024)
	}

	[TableName(Name="child")]
	public partial class child
	{
		[Nullable] public int? ParentID { get; set; } // int(10)
		[Nullable] public int? ChildID  { get; set; } // int(10)
	}

	[TableName(Name="datatypetest")]
	public partial class datatypetest
	{
		[Identity, PrimaryKey(1), Required       ] public int       DataTypeID { get; set; } // int(10)
		[Nullable                                ] public byte[]    Binary_    { get; set; } // binary(50)
		[                         Required       ] public bool      Boolean_   { get; set; } // bit(1)
		[Nullable                                ] public sbyte?    Byte_      { get; set; } // tinyint(3)
		[Nullable                                ] public byte[]    Bytes_     { get; set; } // varbinary(50)
		[Nullable,                MaxLength(   1)] public string    Char_      { get; set; } // char(1)
		[Nullable                                ] public DateTime? DateTime_  { get; set; } // datetime
		[Nullable                                ] public decimal?  Decimal_   { get; set; } // decimal(20,2)
		[Nullable                                ] public float?    Double_    { get; set; } // float(12)
		[Nullable                                ] public byte[]    Guid_      { get; set; } // varbinary(50)
		[Nullable                                ] public short?    Int16_     { get; set; } // smallint(5)
		[Nullable                                ] public int?      Int32_     { get; set; } // int(10)
		[Nullable                                ] public long?     Int64_     { get; set; } // bigint(19)
		[Nullable                                ] public decimal?  Money_     { get; set; } // decimal(20,4)
		[Nullable                                ] public sbyte?    SByte_     { get; set; } // tinyint(3)
		[Nullable                                ] public double?   Single_    { get; set; } // double(22)
		[Nullable                                ] public byte[]    Stream_    { get; set; } // varbinary(50)
		[Nullable,                MaxLength(  50)] public string    String_    { get; set; } // varchar(50)
		[Nullable                                ] public short?    UInt16_    { get; set; } // smallint(5)
		[Nullable                                ] public int?      UInt32_    { get; set; } // int(10)
		[Nullable                                ] public long?     UInt64_    { get; set; } // bigint(19)
		[Nullable,                MaxLength(1000)] public string    Xml_       { get; set; } // varchar(1000)
	}

	[TableName(Name="doctor")]
	public partial class doctor
	{
		[PrimaryKey(1), Required               ] public int    PersonID { get; set; } // int(10)
		[               MaxLength(50), Required] public string Taxonomy { get; set; } // varchar(50)

		// FK_Doctor_Person
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public person DoctorPerson { get; set; }
	}

	[TableName(Name="grandchild")]
	public partial class grandchild
	{
		[Nullable] public int? ParentID     { get; set; } // int(10)
		[Nullable] public int? ChildID      { get; set; } // int(10)
		[Nullable] public int? GrandChildID { get; set; } // int(10)
	}

	[TableName(Name="linqdatatypes")]
	public partial class linqdatatypes
	{
		[Nullable               ] public int?      ID             { get; set; } // int(10)
		[Nullable               ] public decimal?  MoneyValue     { get; set; } // decimal(10,4)
		[Nullable               ] public DateTime? DateTimeValue  { get; set; } // datetime
		[Nullable               ] public DateTime? DateTimeValue2 { get; set; } // datetime
		[Nullable               ] public bool?     BoolValue      { get; set; } // tinyint(3)
		[Nullable, MaxLength(36)] public string    GuidValue      { get; set; } // char(36)
		[Nullable               ] public byte[]    BinaryValue    { get; set; } // varbinary(5000)
		[Nullable               ] public short?    SmallIntValue  { get; set; } // smallint(5)
		[Nullable               ] public int?      IntValue       { get; set; } // int(10)
		[Nullable               ] public long?     BigIntValue    { get; set; } // bigint(19)
	}

	[TableName(Name="parent")]
	public partial class parent
	{
		[Nullable] public int? ParentID { get; set; } // int(10)
		[Nullable] public int? Value1   { get; set; } // int(10)
	}

	[TableName(Name="patient")]
	public partial class patient
	{
		[PrimaryKey(1), Required                ] public int    PersonID  { get; set; } // int(10)
		[               MaxLength(256), Required] public string Diagnosis { get; set; } // varchar(256)

		// FK_Patient_Person
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false)]
		public person PatientPerson { get; set; }
	}

	[TableName(Name="person")]
	public partial class person
	{
		[Identity, PrimaryKey(1), Required               ] public int    PersonID   { get; set; } // int(10)
		[                         MaxLength(50), Required] public string FirstName  { get; set; } // varchar(50)
		[                         MaxLength(50), Required] public string LastName   { get; set; } // varchar(50)
		[Nullable,                MaxLength(50)          ] public string MiddleName { get; set; } // varchar(50)
		[                         MaxLength( 1), Required] public string Gender     { get; set; } // char(1)

		// FK_Doctor_Person_BackReference
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public doctor DoctorPerson { get; set; }

		// FK_Patient_Person_BackReference
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true)]
		public patient PatientPerson { get; set; }
	}

	[TableName(Name="testidentity")]
	public partial class testidentity
	{
		[Identity, PrimaryKey(1), Required] public int ID { get; set; } // int(10)
	}
}
