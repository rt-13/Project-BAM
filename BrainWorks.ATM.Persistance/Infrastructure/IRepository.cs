using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrainWorks.ATM.Persistence
{
	public interface IRepository<T> where T : class
	{
		IEnumerable<T> GetAll();

		T GetById(int id);

		IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

		T FirstOrDefault(Expression<Func<T, bool>> predicate);

		void Add(T entity);

		void Remove(T entity);
	}
}
