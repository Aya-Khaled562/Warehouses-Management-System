namespace Project
{
	partial class StoreReport
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
			this.com_storename = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_from = new System.Windows.Forms.DateTimePicker();
			this.dtp_to = new System.Windows.Forms.DateTimePicker();
			this.To = new System.Windows.Forms.Label();
			this.From = new System.Windows.Forms.Label();
			this.btn_showreport = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// com_storename
			// 
			this.com_storename.FormattingEnabled = true;
			this.com_storename.Location = new System.Drawing.Point(171, 110);
			this.com_storename.Name = "com_storename";
			this.com_storename.Size = new System.Drawing.Size(121, 21);
			this.com_storename.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(92, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Store";
			// 
			// dtp_from
			// 
			this.dtp_from.Location = new System.Drawing.Point(171, 169);
			this.dtp_from.Name = "dtp_from";
			this.dtp_from.Size = new System.Drawing.Size(200, 20);
			this.dtp_from.TabIndex = 2;
			// 
			// dtp_to
			// 
			this.dtp_to.Location = new System.Drawing.Point(171, 228);
			this.dtp_to.Name = "dtp_to";
			this.dtp_to.Size = new System.Drawing.Size(200, 20);
			this.dtp_to.TabIndex = 2;
			// 
			// To
			// 
			this.To.AutoSize = true;
			this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.To.Location = new System.Drawing.Point(92, 232);
			this.To.Name = "To";
			this.To.Size = new System.Drawing.Size(26, 16);
			this.To.TabIndex = 1;
			this.To.Text = "To";
			// 
			// From
			// 
			this.From.AutoSize = true;
			this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.From.Location = new System.Drawing.Point(92, 169);
			this.From.Name = "From";
			this.From.Size = new System.Drawing.Size(42, 16);
			this.From.TabIndex = 1;
			this.From.Text = "From";
			// 
			// btn_showreport
			// 
			this.btn_showreport.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_showreport.Location = new System.Drawing.Point(200, 288);
			this.btn_showreport.Name = "btn_showreport";
			this.btn_showreport.Size = new System.Drawing.Size(75, 23);
			this.btn_showreport.TabIndex = 4;
			this.btn_showreport.Text = "Show Report";
			this.btn_showreport.UseVisualStyleBackColor = true;
			this.btn_showreport.Click += new System.EventHandler(this.btn_showreport_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreName,
            this.Address,
            this.Manager,
            this.ProductName,
            this.Quantity,
            this.ImportDate});
			this.dataGridView1.Location = new System.Drawing.Point(434, 110);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(643, 150);
			this.dataGridView1.TabIndex = 5;
			// 
			// StoreName
			// 
			this.StoreName.HeaderText = "StoreName";
			this.StoreName.Name = "StoreName";
			// 
			// Address
			// 
			this.Address.HeaderText = "Address";
			this.Address.Name = "Address";
			// 
			// Manager
			// 
			this.Manager.HeaderText = "Manager";
			this.Manager.Name = "Manager";
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.Name = "ProductName";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			// 
			// ImportDate
			// 
			this.ImportDate.HeaderText = "ImportDate";
			this.ImportDate.Name = "ImportDate";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(428, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(155, 31);
			this.label6.TabIndex = 6;
			this.label6.Text = "Store Report";
			// 
			// StoreReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1231, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_showreport);
			this.Controls.Add(this.dtp_to);
			this.Controls.Add(this.dtp_from);
			this.Controls.Add(this.From);
			this.Controls.Add(this.To);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.com_storename);
			this.Name = "StoreReport";
			this.Text = "StoreReport";
			this.Load += new System.EventHandler(this.StoreReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox com_storename;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_from;
		private System.Windows.Forms.DateTimePicker dtp_to;
		private System.Windows.Forms.Label To;
		private System.Windows.Forms.Label From;
		private System.Windows.Forms.Button btn_showreport;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn Manager;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
		private System.Windows.Forms.Label label6;
	}
}