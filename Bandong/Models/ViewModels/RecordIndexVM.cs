using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Models.ViewModels
{
	public class RecordIndexVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShopName { get; set; }
		public string Meals { get; set; }
		public DateTime OrderTime { get; set; }
	}

	public class RecordVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ShopName { get; set; }
		public string Meals { get; set; }
		public DateTime OrderTime { get; set; }
	}
}
