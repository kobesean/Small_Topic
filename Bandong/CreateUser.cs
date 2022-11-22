using Bandong.Infra;
using Bandong.Models.DTOS;
using Bandong.Models.Services;
using Bandong.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bandong
{
	public partial class CreateUser : Form
	{
		public CreateUser()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string name = nameTextBox.Text;
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;
			string telephone = telTextBox.Text;
			string email = emailTextBox.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Name = name,
				Account = account,
				Password = password,
				Telephone = telephone,
				Email = email,
				
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Name", nameTextBox},
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
				{"Telephone", telTextBox},
				{"Email", emailTextBox},

			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;


			// 如果通過驗證,就新增記錄
			// 將ViewModel轉成DTO
			UserDTO dto = model.ToDTO();


			try
			{
				// new UserService().Create(model);
				new UsersService().Create(dto);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
			MessageBox.Show("新增成功");

		}

		private void CreateUser_Load(object sender, EventArgs e)
		{

		}
	}

}
