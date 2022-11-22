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
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void 維護店家ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Shop.Shop();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護菜單ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Menu();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 維護使用者ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new User();
			frm.MdiParent = this;
			frm.Show();
		}

		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.Owner.Show();
		}

		private void 訂單維護ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new Order();
			frm.MdiParent = this;
			frm.Show();

		}
	}
}
