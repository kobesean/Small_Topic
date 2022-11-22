using Bandong.Models.DTOS;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Infra.DAOs
{
	public class ShopDAO
	{
		public IEnumerable<ShopDTO> GetAll()
		{
			string sql = @"SELECT * FROM Shop ORDER BY ID ";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new ShopDTO
				{
					Id = row.Field<int>("Id"),
					ShopName = row.Field<string>("ShopName"),
					Address = row.Field<string>("Address"),
					Tel = row.Field<string>("Tel")
				});

		}
		public bool ShopnameExists(string shopname)
		{
			string sql = @"SELECT Count(*) as count FROM Shop WHERE ShopName=@ShopName";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("ShopName", 50, shopname)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool ShopnameExists(ShopDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM Shop WHERE ShopName=@ShopName AND Id!=@Id";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("ShopName", 50, model.ShopName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public void Create(ShopDTO model)
		{
			string sql = @"INSERT INTO Shop
(ShopName,Address, Tel)
VALUES
(@ShopName,@Address, @Tel)";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("ShopName", 50, model.ShopName)
				.AddNvarchar("Address", 50, model.Address)
				.AddNvarchar("Tel", 50, model.Tel)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public void Update(ShopDTO model)
		{
			string sql = @"UPDATE Shop
			SET ShopName=@ShopName, Address=@Address, Tel=@Tel
			WHERE Id=@Id";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("ShopName", 50, model.ShopName)
				.AddNvarchar("Address", 50, model.Address)
				.AddNvarchar("Tel", 50, model.Tel)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Shop WHERE Id=@Id";

			var parameters = new sqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public ShopDTO Get(string shopName)
		{
			string sql = "SELECT * FROM Shop WHERE ShopName=@ShopName";
			var parameters = new sqlParameterBuilder()
				.AddNvarchar("ShopName", 50, shopName)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToShopDTO(data.Rows[0]);
		}
		public ShopDTO Get(int id)
		{
			string sql = "SELECT * FROM Shop WHERE Id=@Id";
			var parameters = new sqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToShopDTO(data.Rows[0]);
		}
		private ShopDTO ToShopDTO(DataRow row)
		{
			return new ShopDTO
			{
				Id = row.Field<int>("Id"),
				ShopName = row.Field<string>("ShopName"),
				Address = row.Field<string>("Address"),
				Tel = row.Field<string>("Tel")
			};
		}
		public bool ShopExists(string shopname)
		{
			string sql = @"SELECT Count(*) as count FROM Shop WHERE ShopName=@ShopName";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("ShopName", 50, shopname)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(ShopDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM Users WHERE ShopName=@ShopName AND Id!=@Id";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Account", 50, model.ShopName)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
	}
}
