using LifeLine.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		private static BloodDonorRepository repo;
		static void Main(string[] args)
		{
			BloodDonorInitalizeDb db = new BloodDonorInitalizeDb();
			Database.SetInitializer(db);
		    BloodDonorContext con = new BloodDonorContext();
			con.Database.Initialize(true);
			con.Database.CreateIfNotExists();
			repo = new BloodDonorRepository();
			var a = repo.GetBloodDonors();
		}


	}
}
