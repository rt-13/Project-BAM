using BrainWorks.ATM.Data;
using System.Collections.Generic;

namespace BrainWorks.ATM.Service
{
	public interface IUserService
	{
		IEnumerable<User> GetAllUsers();

		User GetById(int id);

		User GetByEmail(string email);

		int AddUser(User user);
	}
}
