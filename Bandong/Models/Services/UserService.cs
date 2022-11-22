using Bandong.Infra.DAOs;
using Bandong.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.Services
{
	public class UserService
	{
		private MenuDAO _dao;

		public UserService()
		{
			_dao = new MenuDAO();
		}
		public void Create(MenuDTO model)
		{
			bool isExists = _dao.MenuExists(model.Meals);
			if (isExists) throw new Exception("菜名已存在");

			new MenuDAO().Create(model);

		}
		internal void Update(MenuDTO model)
		{
			bool isExists = _dao.MenuExists(model);
			if (isExists) throw new Exception("帳號已存在");

			new MenuDAO().Update(model);
		}
		internal void Delete(int id)
		{
			_dao.Delete(id);
		}
	}

}
