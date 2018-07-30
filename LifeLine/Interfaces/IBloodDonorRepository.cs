using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeLine.Entity;

namespace LifeLine.Interfaces
{
	public interface IBloodDonorRepository
	{
		void Add(BloodDonor b);
		void Edit(BloodDonor b);
		void Remove(string BloodDonorID);
		IEnumerable<BloodDonor> GetBloodDonors();
		BloodDonor FindById(string BloodDonorID);
	}
}
