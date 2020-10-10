using BrainWorks.ATM.Data;

namespace BrainWorks.ATM.Persistence
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ATMContext _context;
		public Repository<User> UserRepository { get; }
		public Repository<Account> AccountRepository { get; }
		public Repository<SiteContent> SiteContentRepository { get; }
		public Repository<Card> CardRepository { get; }

		public UnitOfWork(ATMContext context)
		{
			this._context = context;
			this.AccountRepository = new Repository<Account>(this._context);
			this.UserRepository = new Repository<User>(this._context);
			this.SiteContentRepository = new Repository<SiteContent>(this._context);
			this.CardRepository = new Repository<Card>(this._context);
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
