using Bandong.Models.DTOS;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Infra.DAOs
{
	public class RecordDAO
	{
		public IEnumerable<RecordDTO> GetOne()
		{
			string sql = @"select o.Id , u.Name , s.ShopName , m.Meals, o.OrderTime
						from  [dbo].[Order] o
						Join Shop s on s.Id = o.Shop_id
						Join Menu m on m.Id = o.Menu_id
						Join [dbo].[User] u on u.Id = o.[User_id] 
						WHERE user_id=@user_id
						ORDER BY o.OrderTime DESC";

			var dbHelper = new SqlDbHelper("default");
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new RecordDTO
				{
					Id = row.Field<int>("Id"),
					Name = row.Field<string>("Name"),
					ShopName = row.Field<string>("ShopName"),
					Meals = row.Field<string>("Meals"),
					OrderTime = row.Field<DateTime>("OrderTime"),
				});

		}
	}
}
