using Bandong.Models.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.ViewModels
{
	public class ShopIndexVM
	{
		public int Id { get; set; }
		public string ShopName { get; set; }
		public string Address { get; set; }
		public string Tel { get; set; }
	}

	public class ShopVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "店名必填")]
		public string ShopName { get; set; }
		[Required(ErrorMessage = "地址必填")]
		public string Address { get; set; }
		[Required(ErrorMessage = "電話必填")]
		public string Tel { get; set; }
	}

	public static class ShopVMExts
	{
		public static ShopDTO ToDTO(this ShopVM vm)
		{
			return new ShopDTO
			{
				Id = vm.Id,
				ShopName = vm.ShopName,
				Address = vm.Address,
				Tel = vm.Tel
			};
		}
	}
}
