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

namespace Bandong.Shop
{
	public partial class Shop : Form
	{
		private ShopIndexVM[] shops=null;
		public Shop()
		{
			InitializeComponent();
			DisplayShops();
		}

		private void DisplayShops()
		{
			shops = new ShopDAO().GetAll()
						.Select(dto => dto.ToIndexVM())
						.ToArray();
			BindData(shops);
		}
		private void BindData(ShopIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}


		private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;
			ShopIndexVM row = this.shops[rowIndex];
			int id = row.Id;
			var frm = new EditShop(id);
			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayShops();
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateShop();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayShops();
			}
		}
	}
}
