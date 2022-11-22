using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.DTOS
{
	public class ShopDTO
	{
		public int Id { get; set; }
		public string ShopName { get; set; }
		public string Address { get; set; }
		public string Tel { get; set; }
	}

	public static class ShopDTOExts
	{
		public static ShopVM ToVM(this ShopDTO dto)
		{
			return new ShopVM
			{
				Id = dto.Id,
				ShopName = dto.ShopName,
				Address = dto.Address,
				Tel = dto.Tel,
			};
		}

		public static ShopIndexVM ToIndexVM(this ShopDTO dto)
		{
			return new ShopIndexVM
			{
				Id = dto.Id,
				ShopName = dto.ShopName,
				Address = dto.Address,
				Tel = dto.Tel,
			};
		}
	}
}
