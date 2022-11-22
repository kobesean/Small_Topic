using Bandong.Models.DTOS;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bandong.Infra.DAOs
{
	public class MenuDAO
	{
		public IEnumerable<MenuDTO> GetAll()
		{
			string sql = @"SELECT * FROM Menu ORDER BY ID DESC";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => new MenuDTO
				{
					Id = row.Field<int>("Id"),
					Meals = row.Field<string>("Meals"),
					Shop_id = row.Field<int>("Shop_id"),
					Price = row.Field<int>("Price")
				});

		}
		public bool MenuExists(string Meals)
		{
			string sql = @"SELECT Count(*) as count FROM Menu WHERE Meals=@Meals";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Meals", 50, Meals)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool MenuExists(MenuDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM Menu WHERE Meals=@Meals AND Id!=@Id";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Meals", 50, model.Meals)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public void Create(MenuDTO model)
		{
			string sql = @"INSERT INTO Menu(Meals,Shop_id, Price)
									VALUES(@Meals,@Shop_id, @Price)";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Meals", 50, model.Meals)
				.AddInt("Shop_id", model.Shop_id)
				.AddInt("Price",  model.Price)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}
		public MenuDTO Get(string Menu)
		{
			string sql = "SELECT * FROM Menu WHERE Meals=@Meals";
			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Meals", 50, Menu)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToMenuDTO(data.Rows[0]);
		}
		public MenuDTO Get(int id)
		{
			string sql = "SELECT * FROM Menu WHERE Id=@Id";
			var parameters = new sqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToMenuDTO(data.Rows[0]);
		}
		private MenuDTO ToMenuDTO(DataRow row)
		{
			return new MenuDTO
			{
				Id = row.Field<int>("Id"),
				Meals = row.Field<string>("Meals"),
				Shop_id = row.Field<int>("Shop_id"),
				Price = row.Field<int>("Price"),
			};
		}
		public void Update(MenuDTO model)
		{
			string sql = @"UPDATE Menu
			SET Meals=@Meals, Shop_id=@Shop_id, Price=@Price
			WHERE Id=@Id";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Meals", 50, model.Meals)
				.AddInt("Shop_id", model.Shop_id)
				.AddInt("Price", model.Price)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM Menu WHERE Id=@Id";

			var parameters = new sqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}
	}
}
