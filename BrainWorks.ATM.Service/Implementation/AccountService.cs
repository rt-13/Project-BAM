using BrainWorks.ATM.Persistence;
using System;
using System.Linq;

namespace BrainWorks.ATM.Service
{
	public class AccountService : IAccountService
	{
		private readonly IUnitOfWork _unitOfWork;

		public AccountService(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		public bool IsPinValid(string accountNumber, int pin)
		{
			var account = this._unitOfWork.AccountRepository.FirstOrDefault(x => string.Compare(x.AccountNumber, accountNumber, StringComparison.OrdinalIgnoreCase) == 0);

			if (account != null && account.Cards.Any())
			{
				var card = account.Cards[0];
				if (card.PIN == pin)
				{
					return true;
				}
			}

			return false;
		}
	}
}
