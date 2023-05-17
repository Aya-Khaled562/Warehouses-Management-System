namespace Project
{
	partial class ProductReport
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_showreport = new System.Windows.Forms.Button();
			this.dtp_to = new System.Windows.Forms.DateTimePicker();
			this.dtp_from = new System.Windows.Forms.DateTimePicker();
			this.From = new System.Windows.Forms.Label();
			this.To = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.com_productname = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.StoresName = new System.Windows.Forms.CheckedListBox();
			this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitsOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StoreName,
            this.ProductName,
            this.ProductCode,
            this.Quantity,
            this.UnitsOfMeasure});
			this.dataGridView1.Location = new System.Drawing.Point(500, 129);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(544, 150);
			this.dataGridView1.TabIndex = 14;
			// 
			// btn_showreport
			// 
			this.btn_showreport.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_showreport.Location = new System.Drawing.Point(107, 165);
			this.btn_showreport.Name = "btn_showreport";
			this.btn_showreport.Size = new System.Drawing.Size(105, 37);
			this.btn_showreport.TabIndex = 13;
			this.btn_showreport.Text = "Show Report";
			this.btn_showreport.UseVisualStyleBackColor = true;
			this.btn_showreport.Click += new System.EventHandler(this.btn_showreport_Click);
			// 
			// dtp_to
			// 
			this.dtp_to.Location = new System.Drawing.Point(74, 118);
			this.dtp_to.Name = "dtp_to";
			this.dtp_to.Size = new System.Drawing.Size(200, 20);
			this.dtp_to.TabIndex = 11;
			// 
			// dtp_from
			// 
			this.dtp_from.Location = new System.Drawing.Point(74, 63);
			this.dtp_from.Name = "dtp_from";
			this.dtp_from.Size = new System.Drawing.Size(200, 20);
			this.dtp_from.TabIndex = 12;
			// 
			// From
			// 
			this.From.AutoSize = true;
			this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.From.Location = new System.Drawing.Point(14, 63);
			this.From.Name = "From";
			this.From.Size = new System.Drawing.Size(42, 16);
			this.From.TabIndex = 8;
			this.From.Text = "From";
			// 
			// To
			// 
			this.To.AutoSize = true;
			this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.To.Location = new System.Drawing.Point(14, 122);
			this.To.Name = "To";
			this.To.Size = new System.Drawing.Size(26, 16);
			this.To.TabIndex = 9;
			this.To.Text = "To";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Product";
			// 
			// com_productname
			// 
			this.com_productname.FormattingEnabled = true;
			this.com_productname.Location = new System.Drawing.Point(91, 29);
			this.com_productname.Name = "com_productname";
			this.com_productname.Size = new System.Drawing.Size(121, 21);
			this.com_productname.TabIndex = 7;
			this.com_productname.SelectedIndexChanged += new System.EventHandler(this.com_productname_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(402, 45);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(186, 31);
			this.label6.TabIndex = 15;
			this.label6.Text = "Product Report";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.StoresName);
			this.panel1.Controls.Add(this.com_productname);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dtp_to);
			this.panel1.Controls.Add(this.btn_showreport);
			this.panel1.Controls.Add(this.To);
			this.panel1.Controls.Add(this.From);
			this.panel1.Controls.Add(this.dtp_from);
			this.panel1.Location = new System.Drawing.Point(12, 77);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(468, 294);
			this.panel1.TabIndex = 17;
			// 
			// StoresName
			// 
			this.StoresName.FormattingEnabled = true;
			this.StoresName.Location = new System.Drawing.Point(319, 52);
			this.StoresName.Name = "StoresName";
			this.StoresName.Size = new System.Drawing.Size(120, 94);
			this.StoresName.TabIndex = 17;
			// 
			// StoreName
			// 
			this.StoreName.HeaderText = "StoreName";
			this.StoreName.Name = "StoreName";
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.Name = "ProductName";
			// 
			// ProductCode
			// 
			this.ProductCode.HeaderText = "ProductCode";
			this.ProductCode.Name = "ProductCode";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			// 
			// UnitsOfMeasure
			// 
			this.UnitsOfMeasure.HeaderText = "UnitsOfMeasure";
			this.UnitsOfMeasure.Name = "UnitsOfMeasure";
			// 
			// ProductReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1104, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label6);
			this.Name = "ProductReport";
			this.Text = "ProductReport";
			this.Load += new System.EventHandler(this.ProductReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_showreport;
		private System.Windows.Forms.DateTimePicker dtp_to;
		private System.Windows.Forms.DateTimePicker dtp_from;
		private System.Windows.Forms.Label From;
		private System.Windows.Forms.Label To;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox com_productname;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckedListBox StoresName;
		private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.DataGridViewTextBoxColumn UnitsOfMeasure;
	}
}