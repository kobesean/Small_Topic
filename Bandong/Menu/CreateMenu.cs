using Bandong.Infra;
using Bandong.Infra.Extensions;
using Bandong.Models.DTOS;
using Bandong.Models.Services;
using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bandong
{
	public partial class CreateMenu : Form
	{
		public CreateMenu()
		{
			InitializeComponent();
		}
		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int shop = shopTextBox.Text.ToInt(-1);
			string meals = menuTextBox.Text;
			int price = priceTextBox.Text.ToInt(-1);

			// 將它們繫結到ViewModel
			MenuVM model = new MenuVM
			{
				Shop_id = shop,
				Meals = meals,
				Price = price,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"shop_id", shopTextBox},
				{"Meals", menuTextBox},
				{"Price", priceTextBox},
			};


			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			MenuDTO dto = model.ToDTO();


			try
			{
				new UserService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
			MessageBox.Show("新增成功");
		}
	}
}
