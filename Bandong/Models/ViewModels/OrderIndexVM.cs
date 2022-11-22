using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.ViewModels
{
	public class OrderIndexVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShopName { get; set; }
		public string Meals { get; set; }

		public DateTime OrderTime { get; set; }
		public int User_id { get; set; }
	}

	public class OrderVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShopName { get; set; }
		public string Meals { get; set; }

		public DateTime OrderTime { get; set; }
		public int User_id { get; set; }
	}
}
