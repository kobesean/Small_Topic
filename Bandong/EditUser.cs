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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandong
{

	public partial class EditUser : Form
	{
		private int id;
		public EditUser(int id)
		{
			InitializeComponent();
			this.Load += EditUser_Load;
			this.id = id;
		}

		private void EditUser_Load(object sender, EventArgs e)
		{
			BindData(id);
		}
		private void BindData(int id)
		{
			// UserVM model = new UserService().Get(id);
			UserDTO dto = new UserDAO().Get(id);

			// 把DTO轉型為ViewModel
			UserVM model = dto.ToVM();

			// 再將 viewModel值繫結到各控制項
			accountTextBox.Text = model.Account;
			passwordTextBox.Text = model.Password;
			nameTextBox.Text = model.Name;
			telTextBox.Text=model.Telephone;
			emailTextBox.Text = model.Email;
		}

		private void updateButton_Click(object sender, EventArgs e)
		{
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string name = nameTextBox.Text;
			string tel = telTextBox.Text;
			string email = emailTextBox.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Id = this.id,
				Account = account,
				Password = password,
				Name = name,
				Email = email,
				Telephone = tel,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Name", nameTextBox},
				{"Email", emailTextBox},
				{"Telephone", telTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			UserDTO dto = model.ToDTO();


			// update record
			try
			{
				new UsersService().Update(dto);

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

			new UsersService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
