﻿using System;

using BLToolkit.Data.Linq;
using BLToolkit.Data.DataProvider;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;

using NUnit.Framework;

namespace Data.Linq.ProviderSpecific
{
	[TestFixture]
	public class PostgreSQL : TestBase
	{
		[TableName(Owner="public", Name="entity")]
		public class Entity
		{
			[MapField("the_name") ] public string TheName { get; set; }
		}

		[Test]
		public void SqlTest1()
		{
			using (var db = new TestDbManager(ProviderName.PostgreSQL))
			{
				db.BeginTransaction();

				db
					.SetSpCommand("add_if_not_exists", db.Parameter("p_name", "one"))
					.ExecuteNonQuery();

				db.Insert(new Entity { TheName = "two" });
			}
		}
	}
}
