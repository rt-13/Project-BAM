using BrainWorks.ATM.Data;
using System;

namespace BrainWorks.ATM.Persistence
{
	public interface IUnitOfWork : IDisposable
	{
		Repository<User> UserRepository { get; }
		Repository<Account> AccountRepository { get; }
		Repository<SiteContent> SiteContentRepository { get; }

		int Save();
	}
}
