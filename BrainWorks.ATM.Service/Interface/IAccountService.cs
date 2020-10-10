namespace BrainWorks.ATM.Service
{
	public interface IAccountService
	{
		bool IsPinValid(string cardNumber, int pin);
	}
}
