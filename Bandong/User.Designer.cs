namespace Bandong
{
	partial class User
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
			this.addButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIndexVMBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.userIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.userIndexVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.userIndexVMBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(593, 70);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(75, 23);
			this.addButton.TabIndex = 1;
			this.addButton.Text = "新增";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.Account,
            this.Password,
            this.Telephone,
            this.emailDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userIndexVMBindingSource3;
			this.dataGridView1.Location = new System.Drawing.Point(25, 142);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(643, 200);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// Account
			// 
			this.Account.DataPropertyName = "Account";
			this.Account.HeaderText = "Account";
			this.Account.Name = "Account";
			this.Account.ReadOnly = true;
			// 
			// Password
			// 
			this.Password.DataPropertyName = "Password";
			this.Password.HeaderText = "Password";
			this.Password.Name = "Password";
			this.Password.ReadOnly = true;
			// 
			// Telephone
			// 
			this.Telephone.DataPropertyName = "Telephone";
			this.Telephone.HeaderText = "Telephone";
			this.Telephone.Name = "Telephone";
			this.Telephone.ReadOnly = true;
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
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userIndexVMBindingSource3
			// 
			this.userIndexVMBindingSource3.DataSource = typeof(Bandong.Models.ViewModels.UserIndexVM);
			// 
			// userIndexVMBindingSource
			// 
			this.userIndexVMBindingSource.DataSource = typeof(Bandong.Models.ViewModels.UserIndexVM);
			// 
			// userIndexVMBindingSource1
			// 
			this.userIndexVMBindingSource1.DataSource = typeof(Bandong.Models.ViewModels.UserIndexVM);
			// 
			// userIndexVMBindingSource2
			// 
			this.userIndexVMBindingSource2.DataSource = typeof(Bandong.Models.ViewModels.UserIndexVM);
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 400);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addButton);
			this.Name = "User";
			this.Text = "User";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource userIndexVMBindingSource;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource1;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource3;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Account;
		private System.Windows.Forms.DataGridViewTextBoxColumn Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
	}
}