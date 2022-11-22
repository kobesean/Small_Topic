using Bandong.Infra.DAOs;
using Bandong.Models.DTOS;
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
	public partial class Menu : Form
	{
		private MenuIndexVM[] Menus = null;
		public Menu()
		{
			InitializeComponent();
			DisplayMenus();
		}

		private void DisplayMenus()
		{

			Menus = new MenuDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(Menus);
		}
		private void BindData(MenuIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}



		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;

			if (rowIndex < 0) return;

			MenuIndexVM row = this.Menus[rowIndex]; // 使用者點到的那一筆記錄

			int id = row.Id; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditMenu(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayMenus();
			}

		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateMenu();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayMenus();
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
