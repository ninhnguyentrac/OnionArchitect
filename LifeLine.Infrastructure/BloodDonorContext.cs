using LifeLine.Entity;
using System.Data.Entity;

namespace LifeLine.Infrastructure
{
	public class BloodDonorContext : DbContext
	{
		public BloodDonorContext() : base("name=BloodDonorContextConnectionString")
		{
		
		}

		public DbSet<BloodDonor> BloodDonors { get; set; }
    }
}
