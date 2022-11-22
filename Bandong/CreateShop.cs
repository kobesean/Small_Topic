using Bandong.Infra;
using Bandong.Models.DTOS;
using Bandong.Models.Services;
using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandong
{
	public partial class CreateShop : Form
	{
		public CreateShop()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string shopName = shopNameTextBox.Text;
			string address = addressTextBox.Text;
			string tel = telTextBox.Text;

			// 將它們繫結到ViewModel
			ShopVM model = new ShopVM
			{
				ShopName = shopName,
				Address = address,
				Tel = tel,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"ShopName", shopNameTextBox},
				{"Address", addressTextBox},
				{"Tel", telTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			ShopDTO dto = model.ToDTO();


			try
			{
				// new UserService().Create(model);
				new ShopService().Create(dto);

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
