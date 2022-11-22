using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.DTOS
{
	public class UserDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }		
		public string Telephone { get; set; }
		public string Email { get; set; }
	}
	public static class UsersDTOExts
	{
		public static UserVM ToVM(this UserDTO dto)
		{
			return new UserVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Account = dto.Account,
				Password = dto.Password,
				Telephone = dto.Telephone,
				Email = dto.Email,

			};
		}

		public static UserIndexVM ToIndexVM(this UserDTO dto)
		{
			return new UserIndexVM
			{
				Id = dto.Id,
				Name = dto.Name,
				Account = dto.Account,
				Password = dto.Password,
				Telephone = dto.Telephone,
				email = dto.Email,
			};
		}
	}

}

