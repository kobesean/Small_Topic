using Bandong.Infra;
using Bandong.Infra.DAOs;
using Bandong.Models.DTOS;
using Bandong.Models.Services;
using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bandong.Shop
{
	public partial class EditShop : Form
	{
		private int id;
		public EditShop(int id )
		{
			InitializeComponent();
			this.Load += EditShop_Load;
			this.id = id;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string shopName=shopNameTextBox.Text;
			string address = addressTextBox.Text;
			string tel = telTextBox.Text;

			ShopVM model = new ShopVM
			{
				Id = this.id,
				ShopName = shopName,
				Address = address,
				Tel = tel,
			};

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


			// update record
			try
			{
				new ShopService().Update(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			MessageBox.Show("更新成功");
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new ShopService().Delete(this.id);

			this.DialogResult = DialogResult.OK;

		}

		private void EditShop_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			ShopDTO dto = new ShopDAO().Get(id);

			// 把DTO轉型為ViewModel
			ShopVM model = dto.ToVM();

			// 再將 viewModel值繫結到各控制項
			shopNameTextBox.Text = model.ShopName;
			addressTextBox.Text = model.Address;
			telTextBox.Text = model.Tel;
		}
	}
}
