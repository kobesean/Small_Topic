using Bandong.Models.DTOS;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bandong.Models.ViewModels
{
	public class UserIndexVM
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string Account { get; set; }

		public string Password { get; set; }
		public string Telephone { get; set; }
		public string email { get; set; }
	}

	public class UserVM
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "姓名必填")]
		public string Name { get; set; }

		[Required(ErrorMessage = "帳號必填")]
		public string Account { get; set; }

		[Required(ErrorMessage = "密碼必填")]
		public string Password { get; set; }
		[Required(ErrorMessage = "電話必填")]
		public string Telephone { get; set; }
		[EmailAddress(ErrorMessage = "Email格式有誤")]
		public string Email { get; set; }
	}
	public static class UserVMExts
	{
		public static UserDTO ToDTO(this UserVM vm)
		{
			return new UserDTO
			{
				Id = vm.Id,
				Account = vm.Account,
				Password = vm.Password,
				Telephone = vm.Telephone,
				Name = vm.Name,
				Email=vm.Email,
			};
		}
	}
}
