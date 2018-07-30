using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace LifeLine.Entity
{
	public class BloodDonor
	{
		[Required]
		public string BloodDonorID { get; set; }
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
		[Required]
		public string BloodGroup { get; set; }
		[Required]
		public string City { get; set; }

		public string Country { get; set; }
		[Required]
		public int PinCode { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public bool IsActive { get; set; }
		public bool IsPrivate { get; set; }
		public bool IsVerified { get; set; }
	}
}
