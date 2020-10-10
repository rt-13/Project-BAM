using BrainWorks.ATM.Data;

namespace BrainWorks.ATM.Persistence
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ATMContext _context;
		public Repository<User> UserRepository { get; }

		public UnitOfWork(ATMContext context)
		{
			this._context = context;
			this.UserRepository = new Repository<User>(this._context);
		}

		public int Save()
		{
			return this._context.SaveChanges();
		}

		public void Dispose()
		{
			this._context.Dispose();
		}
	}
}
