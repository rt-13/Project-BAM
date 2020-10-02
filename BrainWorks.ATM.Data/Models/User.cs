using System.Collections.Generic;

namespace BrainWorks.ATM.Data
{
	public class User
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Address1 { get; set; }

		public string Address2 { get; set; }

		public string Landmark { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Pin { get; set; }

		public string Mobile { get; set; }

		public string Email { get; set; }

		public int StatusId { get; set; }

		public Status Status { get; set; }

		public List<Account> Accounts { get; set; }
	}
}
