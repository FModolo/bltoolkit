﻿using System;
using BLToolkit.Data.Linq;

using NUnit.Framework;

namespace Data.Exceptions
{
	using Linq;
	using Linq.Model;

	[TestFixture]
	public class DmlTest : TestBase
	{
		[Test, ExpectedException(typeof(LinqException), ExpectedMessage = "InsertOrUpdate method requires the 'Doctor' table to have a primary key.")]
		public void InsertOrUpdate1()
		{
			ForEachProvider(db =>
				db.Doctor.InsertOrUpdate(
					() => new Doctor
					{
						PersonID  = 10,
						Taxonomy = "....",
					},
					p => new Doctor
					{
						Taxonomy = "...",
					}));
		}

		[Test, ExpectedException(typeof(LinqException), ExpectedMessage = "InsertOrUpdate method requires the 'Patient.PersonID' field to be included in the insert setter.")]
		public void InsertOrUpdate2()
		{
			ForEachProvider(db =>
				db.Patient.InsertOrUpdate(
					() => new Patient
					{
						Diagnosis = "....",
					},
					p => new Patient
					{
						Diagnosis = "...",
					}));
		}
	}
}
