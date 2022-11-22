namespace Bandong
{
	partial class CreateMenu
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
			this.shopTextBox = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.menuTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.priceTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// shopTextBox
			// 
			this.shopTextBox.Location = new System.Drawing.Point(114, 23);
			this.shopTextBox.Name = "shopTextBox";
			this.shopTextBox.Size = new System.Drawing.Size(178, 22);
			this.shopTextBox.TabIndex = 0;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(37, 33);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(29, 12);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "店家";
			// 
			// menuTextBox
			// 
			this.menuTextBox.Location = new System.Drawing.Point(114, 73);
			this.menuTextBox.Name = "menuTextBox";
			this.menuTextBox.Size = new System.Drawing.Size(178, 22);
			this.menuTextBox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 1;
			this.label3.Text = "菜名";
			// 
			// priceTextBox
			// 
			this.priceTextBox.Location = new System.Drawing.Point(114, 123);
			this.priceTextBox.Name = "priceTextBox";
			this.priceTextBox.Size = new System.Drawing.Size(178, 22);
			this.priceTextBox.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "價錢";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(217, 173);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(75, 23);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 222);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.priceTextBox);
			this.Controls.Add(this.menuTextBox);
			this.Controls.Add(this.shopTextBox);
			this.Name = "CreateMenu";
			this.Text = "CreateMenu";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox shopTextBox;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.TextBox menuTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox priceTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}