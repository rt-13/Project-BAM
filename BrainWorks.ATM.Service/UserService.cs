using BrainWorks.ATM.Data;
using BrainWorks.ATM.Persistence;
using System.Collections.Generic;

namespace BrainWorks.ATM.Service
{
	public class UserService : IUserService
	{
		private readonly IUnitOfWork _unitOfWork;
		public UserService(IUnitOfWork unitOfWork)
		{
			this._unitOfWork = unitOfWork;
		}

		public IEnumerable<User> GetAllUsers()
		{
			return this._unitOfWork.UserRepository.GetAll();
		}

		public User GetById(int id)
		{
			return this._unitOfWork.UserRepository.GetById(id);
		}

		public User GetByEmail(string email)
		{
			return this._unitOfWork.UserRepository.FirstOrDefault(x => x.Email == email);
		}

		public int AddUser(User user)
		{
			this._unitOfWork.UserRepository.Add(user);
			this._unitOfWork.Save();
			return user.Id;
		}
	}
}
