using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TrashCollector.Models
{

	public class Customer
	{
		[Key]
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PickUpMonth { get; set; }
		public string PickUpDay { get; set; }
		public string PickUpYear { get; set; }
		public string ExtraPickUpMonth { get; set; }
		public string ExtraPickUpDay { get; set; }
		public string ExtraPickUpYear { get; set; }
		public string StartOfSuspensionMonth { get; set; }
		public string StartOfSuspensionDay { get; set; }
		public string StartOfSuspensionYear { get; set; }
		public string EndOfSuspensionMonth { get; set; }
		public string EndOfSuspensionDay { get; set; }
		public string EndOfSuspensionYear { get; set; }
		public string StreetName { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
		public string AccountBallance { get; set; }
		

		[ForeignKey("IdentityUser")]
		public string IdentityUserId { get; set; }
		public IdentityUser IdentityUser { get; set; }
		
		
	}

}
