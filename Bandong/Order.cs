using Bandong.Infra.DAOs;
using Bandong.Models.DTOS;
using Bandong.Models.ViewModels;
using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandong
{
	public partial class Order : Form

	{
		private OrderIndexVM[] orders = null;
		public Order()
		{
			InitializeComponent();
			InitForm();
			DisplayOrders();
		}

		private void InitForm()
		{
			// 設定 categoryIdComboBox property
			idComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

			string sql = @"select distinct u.Name as Name
						from  [dbo].[Order] o
						Join Shop s on o.Shop_id  =  s.Id
						Join Menu m on o.Menu_id  =  m.Id
						Join [dbo].[User] u on  o.[User_id]  = u.Id
						ORDER BY Name";

			var dbHelper = new SqlDbHelper("default");


			string[] names = dbHelper.Select(sql, null)
				.AsEnumerable()
				.Select(row => row.Field<string>("Name"))
				.Prepend(string.Empty)
				.ToArray();
			//idComboBox.DisplayMember = "Name";


			this.idComboBox.DataSource = names;

		}
		private OrderVM ToOrderVM(DataRow row)
		{
			return new OrderVM
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				ShopName = row.Field<string>("ShopName"),
				Meals = row.Field<string>("Meals"),
				OrderTime = row.Field<DateTime>("OrderTime"),
				//User_id = row.Field<int>("User_id"),

			};
		}

		//private void DisplayOrders()
		//{

		//	orders = new OrderDAO().GetAll()
		//				.Select(dto => dto.ToIndexVM())
		//				.ToArray();
		//	BindData(orders);
		//}

		private void BindData(OrderIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			

			

		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayOrders();
		}
		private void DisplayOrders()
		{
			string sql = @"select o.Id , u.Name , s.ShopName , m.Meals, o.OrderTime
						from  [dbo].[Order] o
						Join Shop s on s.Id = o.Shop_id
						Join Menu m on m.Id = o.Menu_id
						Join [dbo].[User] u on u.Id = o.[User_id]";

			#region 加入 where 
			SqlParameter[] parameters = new SqlParameter[] { };

			//取得篩選值
			string Name = idComboBox.SelectedItem.ToString();

			if (idComboBox.SelectedIndex != 0)
			{
				sql += " WHERE Name=@Name";
				parameters = new sqlParameterBuilder()
					.AddNvarchar("Name",50, Name)
					.Build();
			}
			#endregion

			// 加入排序子句
			sql += "  ORDER BY OrderTime DESC";
			var dbHelper = new SqlDbHelper("default");
			// 存放在field裡, 稍後在 grid CellClick事件會需要再度用到它
			orders = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();
			BindData(orders);


		}

		private OrderIndexVM ParseToIndexVM(DataRow row)
		{
			return new OrderIndexVM
			{
				Id = row.Field<int>("Id"),
				Name = row.Field<string>("Name"),
				ShopName = row.Field<string>("ShopName"),
				Meals = row.Field<string>("Meals"),
				OrderTime = row.Field<DateTime>("OrderTime"),
			};
		}

	}
}
