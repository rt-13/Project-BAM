using System.Collections.Generic;

namespace BrainWorks.ATM.Data
{
	public class AccountType
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public List<Account> Accounts { get; set; }
	}
}
