using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrainWorks.ATM.Persistence
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly ATMContext _context;
		public Repository(ATMContext context)
		{
			this._context = context;
		}

		public IEnumerable<T> GetAll()
		{
			return this._context.Set<T>();
		}

		public T GetById(int id)
		{
			return this._context.Set<T>().Find(id);
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
		{
			return this._context.Set<T>().Where(predicate);
		}

		public T FirstOrDefault(Expression<Func<T, bool>> predicate)
		{
			return this._context.Set<T>().FirstOrDefault(predicate);
		}

		public void Add(T entity)
		{
			this._context.Set<T>().Add(entity);
		}

		public void Remove(T entity)
		{
			this._context.Set<T>().Remove(entity);
		}
	}
}
