using Bandong.Models.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.ViewModels
{
	public class MenuIndexVM
	{
		public int Id { get; set; }
		public string Meals { get; set; }
		public int Shop_id { get; set; }
		public int Price { get; set; }
	}
	public class MenuVM: IValidatableObject
	{
		public int Id { get; set; }

		//[Required(ErrorMessage = "菜色必填")]
		public string Meals { get; set; }


		//[Range(0, 50000, ErrorMessage = "店家必填")]
		public int Shop_id { get; set; }


		//[Range(0, 50000, ErrorMessage = "價錢必填")]
		public int Price { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (Meals == String.Empty) yield return new ValidationResult("菜色必填", new string[] { "Meals" });
			if (Shop_id == -1) yield return new ValidationResult("店家必填", new string[] { "Shop_id" });
			if (Price == -1) yield return new ValidationResult("價錢必填", new string[] { "Price" });
		}
	}
	public static class MenuVMExts
	{
		public static MenuDTO ToDTO(this MenuVM vm)
		{
			return new MenuDTO
			{
				Id = vm.Id,
				Meals = vm.Meals,
				Shop_id = vm.Shop_id,
				Price = vm.Price
			};
		}
	}


}
