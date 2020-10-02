using System.Collections.Generic;

namespace BrainWorks.ATM.Data
{
	public class TransactionType
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string ShortCode { get; set; }

		public List<Transaction> Transactions { get; set; }
	}
}
