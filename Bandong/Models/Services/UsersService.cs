using Bandong.Infra.DAOs;
using Bandong.Models.DTOS;
using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.Services
{
	public class UsersService
	{
		private UserDAO _dao;

		public UsersService()
		{
			_dao = new UserDAO();
		}
		public void Create(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model.Account);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Create(model);

		}

		public bool Authenticate(LoginVM model)
		{
			var user = _dao.Get(model.Account);
			if (user == null) return false; // 找不到符合的帳號

			return (user.Password == model.Password);
		}

		internal void Update(UserDTO model)
		{
			bool isExists = _dao.AccountExists(model);
			if (isExists) throw new Exception("帳號已存在");

			new UserDAO().Update(model);
		}

		internal void Delete(int id)
		{
			_dao.Delete(id);
		}
	}
}
