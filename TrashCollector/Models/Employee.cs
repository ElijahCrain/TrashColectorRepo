using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrashCollector.Models
{
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }
		[ForeignKey ("First Name")]
		public string FirstName { get; set; }
		[ForeignKey("Last Name")]
		public string LastName { get; set; }
		[ForeignKey("Zip Code")]
		public string ZipCode { get; set; }
		[ForeignKey("Pickup Date")]
		public string PickupDate { get; set; }
		[ForeignKey("IdentityUser")]
		public string IdentityUserId { get; set; }
		public IdentityUser IdentityUser { get; set; }
	}
}
      