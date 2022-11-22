using Bandong.Models.DTOS;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandong.Infra.DAOs
{
	public class UserDAO
	{
		public IEnumerable<UserDTO> GetAll()
		{
			string sql = @"SELECT * FROM [dbo].[User] ORDER BY ID";

			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			return dbHelper.Select(sql, null).AsEnumerable()
				.Select(row => new UserDTO
				{
					Id = row.Field<int>("Id"),
					Name = row.Field<string>("Name"),
					Account = row.Field<string>("Account"),
					Password = row.Field<string>("Password"),
					Telephone = row.Field<string>("Telephone"),
					Email = row.Field<string>("email"),
					
				});

		}
		public bool AccountExists(string account)
		{
			string sql = @"SELECT Count(*) as count FROM [dbo].[User] WHERE Account=@Account";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}

		public bool AccountExists(UserDTO model)
		{
			string sql = @"SELECT Count(*) as count FROM [dbo].[User] WHERE Account=@Account AND Id!=@Id";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Account", 50, model.Account)
				.AddInt("Id", model.Id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);
			return data.Rows[0].Field<int>("count") > 0;
		}
		public void Create(UserDTO model)
		{
			string sql = @"INSERT INTO [dbo].[User]
(Name, Account, Password, Telephone, Email) VALUES(@Name,@Account,@Password,@Telephone,@Email)";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Name", 50, model.Name)
				.AddNvarchar("Account", 50, model.Account)
				.AddNvarchar("Password", 50, model.Password)
				.AddNvarchar("Telephone", 50, model.Telephone)
				.AddNvarchar("Email", 50, model.Email)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);
		}

		public UserDTO Get(string account)
		{
			string sql = "SELECT * FROM [dbo].[User] WHERE Account=@Account";
			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserDTO(data.Rows[0]);
		}
		public UserDTO Get(int id)
		{
			string sql = "select * from [dbo].[User] WHERE Id=@Id";
			var parameters = new sqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				throw new Exception("找不到要編輯的記錄");

			}

			// 將找到的一筆記錄由DataTable 轉換到 ProductVM
			return ToUserDTO(data.Rows[0]);
		}

		private UserDTO ToUserDTO(DataRow row)
		{
			return new UserDTO
			{
				Id = row.Field<int>("Id"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
				Name = row.Field<string>("Name"),
				Telephone = row.Field<string>("Telephone"),
				Email = row.Field<string>("email"),
			};
		}

		public void Update(UserDTO model)
		{
			string sql = @"UPDATE [dbo].[User]
			SET Account=@Account , Password=@Password , Name=@Name
			,  Telephone=@Telephone , Email=@Email WHERE Id=@Id ";

			var parameters = new sqlParameterBuilder()
				.AddNvarchar("Account", 50, model.Account)
				.AddNvarchar("Password", 50, model.Password)
				.AddNvarchar("Name", 50, model.Name)
				.AddNvarchar("Email", 50, model.Email)
				.AddNvarchar("Telephone", 50, model.Telephone)
				.AddInt("Id", model.Id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		public void Delete(int id)
		{
			string sql = @"DELETE FROM [dbo].[User] WHERE Id=@Id";

			var parameters = new sqlParameterBuilder()
				.AddInt("Id", id)
				.Build();

			new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

		}

		//private UserDTO Getid(int id)
		//{
		//	string sql = @"SELECT Id FROM User WHERE Id=@Id";
		//	var parameters = new sqlParameterBuilder()
		//		.AddInt("Id", id)
		//		.Build();

		//	DataTable data = new SqlDbHelper("default").Select(sql, parameters);

		//	if (data.Rows.Count == 0)
		//	{
		//		return null;
		//	}

		//	// 將找到的一筆記錄由DataTable 轉換到 UserVM
		//	//return ToUserDTO(data.Rows[0]);
		//	var frm = new OrderRecord(id);
		//	return;


		//}
	}
}
