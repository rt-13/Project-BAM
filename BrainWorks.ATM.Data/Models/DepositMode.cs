using System.Collections.Generic;

namespace BrainWorks.ATM.Data
{
	public class DepositMode
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public List<Transaction> Transactions { get; set; }
	}
}
