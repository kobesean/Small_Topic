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
	public partial class OrderRecord : Form
	{
		private RecordIndexVM[] records = null;
		public OrderRecord(int id )
		{
			InitializeComponent();
			DisplayRecords();
		}

		private void DisplayRecords()
		{

			records = new RecordDAO().GetOne()
						.Select(dto => dto.ToIndexVM()).ToArray();
			BindData(records);
		}

		private void BindData(RecordIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}
	}

}
