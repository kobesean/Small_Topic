namespace Bandong
{
	partial class Order
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mealsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchButton = new System.Windows.Forms.Button();
			this.idComboBox = new System.Windows.Forms.ComboBox();
			this.orderVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shopNameDataGridViewTextBoxColumn,
            this.mealsDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(25, 166);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(544, 251);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// shopNameDataGridViewTextBoxColumn
			// 
			this.shopNameDataGridViewTextBoxColumn.DataPropertyName = "ShopName";
			this.shopNameDataGridViewTextBoxColumn.HeaderText = "ShopName";
			this.shopNameDataGridViewTextBoxColumn.Name = "shopNameDataGridViewTextBoxColumn";
			this.shopNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// mealsDataGridViewTextBoxColumn
			// 
			this.mealsDataGridViewTextBoxColumn.DataPropertyName = "Meals";
			this.mealsDataGridViewTextBoxColumn.HeaderText = "Meals";
			this.mealsDataGridViewTextBoxColumn.Name = "mealsDataGridViewTextBoxColumn";
			this.mealsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderTimeDataGridViewTextBoxColumn
			// 
			this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
			this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
			this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
			this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderIndexVMBindingSource
			// 
			this.orderIndexVMBindingSource.DataSource = typeof(Bandong.Models.ViewModels.OrderIndexVM);
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(369, 47);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(75, 23);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "SEARCH";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// idComboBox
			// 
			this.idComboBox.DataSource = this.orderVMBindingSource;
			this.idComboBox.DisplayMember = "User_id";
			this.idComboBox.FormattingEnabled = true;
			this.idComboBox.Location = new System.Drawing.Point(43, 47);
			this.idComboBox.Name = "idComboBox";
			this.idComboBox.Size = new System.Drawing.Size(302, 20);
			this.idComboBox.TabIndex = 2;
			this.idComboBox.ValueMember = "Name";
			// 
			// orderVMBindingSource
			// 
			this.orderVMBindingSource.DataSource = typeof(Bandong.Models.ViewModels.OrderVM);
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(597, 452);
			this.Controls.Add(this.idComboBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Order";
			this.Text = "Order";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.ComboBox idComboBox;
		private System.Windows.Forms.BindingSource orderVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shopNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mealsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource orderIndexVMBindingSource;
	}
}