using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.DTOS
{
	public class MenuDTO
	{
		public int Id { get; set; }
		public string Meals { get; set; }
		public int Shop_id { get; set; }
		public int Price { get; set; }
	}
	public static class MenuDTOExts
	{
		public static MenuVM ToVM(this MenuDTO dto)
		{
			return new MenuVM
			{
				Id = dto.Id,
				Meals = dto.Meals,
				Shop_id = dto.Shop_id,
				Price = dto.Price,
			};
		}
		public static MenuIndexVM ToIndexVM(this MenuDTO dto)
		{
			return new MenuIndexVM
			{
				Id = dto.Id,
				Meals = dto.Meals,
				Shop_id = dto.Shop_id,
				Price = dto.Price,
			};
		}
	}
	
}
