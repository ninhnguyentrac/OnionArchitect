using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeLine.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LifeLine.Tests
{
	[TestClass]
	public class BloodDonorRepositoryTest
	{
		private BloodDonorRepository repo;
		[TestInitialize]
		public void TestSetUp()
		{
			BloodDonorInitalizeDb db = new BloodDonorInitalizeDb();
			Database.SetInitializer(db);
			BloodDonorContext con = new BloodDonorContext();
			con.Database.Initialize(true);
			con.Database.CreateIfNotExists();
			repo = new BloodDonorRepository();
		}

		[TestMethod]
		public void IsRepositoryInitalizeWithValidNumberOfData()
		{
			var result = repo.GetBloodDonors();
			Assert.IsNotNull(result);
			var numberOfRecords = result.ToList().Count;
			Assert.AreEqual(2, numberOfRecords);
		}
	}
}
