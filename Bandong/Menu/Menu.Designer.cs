namespace Bandong
{
	partial class Menu
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
			this.addButton = new System.Windows.Forms.Button();
			this.menuIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.menuIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.menuIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.menuIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Shop_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mealsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource3)).BeginInit();
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
            this.Shop_id,
            this.mealsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.menuIndexVMBindingSource3;
			this.dataGridView1.Location = new System.Drawing.Point(14, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(445, 150);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(384, 32);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "新增";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// menuIndexVMBindingSource2
			// 
			this.menuIndexVMBindingSource2.DataSource = typeof(Bandong.Models.ViewModels.MenuIndexVM);
			// 
			// menuIndexVMBindingSource1
			// 
			this.menuIndexVMBindingSource1.DataSource = typeof(Bandong.Models.ViewModels.MenuIndexVM);
			// 
			// menuIndexVMBindingSource
			// 
			this.menuIndexVMBindingSource.DataSource = typeof(Bandong.Models.ViewModels.MenuIndexVM);
			// 
			// menuIndexVMBindingSource3
			// 
			this.menuIndexVMBindingSource3.DataSource = typeof(Bandong.Models.ViewModels.MenuIndexVM);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Shop_id
			// 
			this.Shop_id.DataPropertyName = "Shop_id";
			this.Shop_id.HeaderText = "Shop_id";
			this.Shop_id.Name = "Shop_id";
			this.Shop_id.ReadOnly = true;
			// 
			// mealsDataGridViewTextBoxColumn
			// 
			this.mealsDataGridViewTextBoxColumn.DataPropertyName = "Meals";
			this.mealsDataGridViewTextBoxColumn.HeaderText = "Meals";
			this.mealsDataGridViewTextBoxColumn.Name = "mealsDataGridViewTextBoxColumn";
			this.mealsDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 266);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Menu";
			this.Text = "檢視菜單";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.menuIndexVMBindingSource3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource menuIndexVMBindingSource;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.BindingSource menuIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource menuIndexVMBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Shop_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn mealsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource menuIndexVMBindingSource3;
	}
}