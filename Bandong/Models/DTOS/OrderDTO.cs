using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.DTOS
{
	public class OrderDTO
	{
		public int Id { get; set; }
		public int Shop_id { get; set; }
		public int Menu_id { get; set; }
		public int User_id { get; set; }

		public DateTime OrderTime { get; set; }

		public string Name { get; set; }
		public string ShopName { get; set; }
		public string Meals { get; set; }
	}

	public static class OrderDTOExts
	{
		public static OrderVM ToVM(this OrderDTO dto)
		{
			return new OrderVM
			{
				Id = dto.Id,
				ShopName = dto.ShopName,
				Meals = dto.Meals,
				Name = dto.Name,
				OrderTime = dto.OrderTime,
			};
		}

		public static OrderIndexVM ToIndexVM(this OrderDTO dto)
		{
			return new OrderIndexVM
			{
				Id = dto.Id,
				ShopName = dto.ShopName,
				Meals = dto.Meals,
				Name = dto.Name,
				OrderTime = dto.OrderTime,
			};
		}
	}
}
