namespace BrainWorks.ATM.Service
{
	public interface IAccountService
	{
		bool IsPinValid(string accountNumber, int pin);
	}
}
