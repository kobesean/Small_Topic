using Bandong.Infra.DAOs;
using Bandong.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.Services
{
	public class ShopService
	{
		private ShopDAO _dao;

		public ShopService()
		{
			_dao = new ShopDAO();
		}
		public void Create(ShopDTO model)
		{
			bool isExists = _dao.ShopExists(model.ShopName);
			if (isExists) throw new Exception("帳號已存在");

			new ShopDAO().Create(model);

		}

		internal void Update(ShopDTO model)
		{
			bool isExists = _dao.ShopnameExists(model);
			if (isExists) throw new Exception("帳號已存在");

			new ShopDAO().Update(model);
		}

		internal void Delete(int id)
		{
			_dao.Delete(id);
		}
	}


}
