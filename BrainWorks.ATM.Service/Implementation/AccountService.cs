using BrainWorks.ATM.Persistence;
using System;

namespace BrainWorks.ATM.Service
{
	public class AccountService : IAccountService
	{
		private readonly IUnitOfWork _unitOfWork;

		public AccountService(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		public bool IsPinValid(string cardNumber, int pin)
		{
			var card = this._unitOfWork.CardRepository.FirstOrDefault(x => string.Compare(x.CardNumber, cardNumber, StringComparison.OrdinalIgnoreCase) == 0 && x.PIN == pin);
			if (card != null)
			{
				return true;
			}

			return false;
		}
	}
}
