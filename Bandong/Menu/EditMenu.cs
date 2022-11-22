using Bandong.Infra;
using Bandong.Infra.DAOs;
using Bandong.Infra.Extensions;
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
	public partial class EditMenu : Form
	{
		private int id;
		public EditMenu(int id)
		{
			InitializeComponent();
			this.Load += EditMenu_Load;
			this.id = id;
		}

		private void EditMenu_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			MenuDTO dto = new MenuDAO().Get(id);

			// 把DTO轉型為ViewModel
			MenuVM model = dto.ToVM();

			// 再將 viewModel值繫結到各控制項
			shopTextBox.Text = model.Shop_id.ToString();
			mealsTextBox.Text = model.Meals;
			priceTextBox.Text = model.Price.ToString();
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			int shop = shopTextBox.Text.ToInt(-1);
			string meals = mealsTextBox.Text;
			int price = priceTextBox.Text.ToInt(-1);

			// 將它們繫結到ViewModel
			MenuVM model = new MenuVM
			{
				Id = this.id,
				Meals = meals,
				Shop_id = shop,
				Price = price,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Shop_id", shopTextBox},
				{"Meals", mealsTextBox},
				{"Price", priceTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			MenuDTO dto = model.ToDTO();


			// update record
			try
			{
				new UserService().Update(dto);

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

			new UserService().Delete(this.id);

			this.DialogResult = DialogResult.OK;

		}
	}

}
