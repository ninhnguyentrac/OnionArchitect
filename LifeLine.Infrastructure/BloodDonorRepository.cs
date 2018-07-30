using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeLine.Entity;
using LifeLine.Interfaces;

namespace LifeLine.Infrastructure
{
	public class BloodDonorRepository : IBloodDonorRepository
	{
		BloodDonorContext context = new BloodDonorContext();

		public void Add(BloodDonor b)
		{
			context.BloodDonors.Add(b);
			context.SaveChanges();
		}

		public void Edit(BloodDonor b)
		{
			context.Entry(b).State = EntityState.Modified;
			context.SaveChanges();
		}

		public void Remove(string bloodDonorId)
		{
			BloodDonor b = context.BloodDonors.Find(bloodDonorId);
			context.BloodDonors.Remove(b);
			context.SaveChanges();
		}

		public IEnumerable<BloodDonor> GetBloodDonors()
		{
			return context.BloodDonors;
		}

		public BloodDonor FindById(string bloodDonorId)
		{
			return context.BloodDonors.FirstOrDefault(x => x.BloodDonorID == bloodDonorId);
		}

	}

}
