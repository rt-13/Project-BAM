using BrainWorks.ATM.Data;
using System;

namespace BrainWorks.ATM.Persistence
{
	public interface IUnitOfWork : IDisposable
	{
		Repository<User> UserRepository { get; }

		int Save();
	}
}
