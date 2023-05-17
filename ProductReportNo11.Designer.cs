namespace Project
{
	partial class ProductReportNo11
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
			this.com_storename = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ImportDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.Code,
            this.ImportDate});
			this.dataGridView1.Location = new System.Drawing.Point(418, 131);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(344, 150);
			this.dataGridView1.TabIndex = 14;
			// 
			// btn_showreport
			// 
			this.btn_showreport.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_showreport.Location = new System.Drawing.Point(178, 306);
			this.btn_showreport.Name = "btn_showreport";
			this.btn_showreport.Size = new System.Drawing.Size(75, 23);
			this.btn_showreport.TabIndex = 13;
			this.btn_showreport.Text = "Show Report";
			this.btn_showreport.UseVisualStyleBackColor = true;
			this.btn_showreport.Click += new System.EventHandler(this.btn_showreport_Click);
			// 
			// dtp_to
			// 
			this.dtp_to.Location = new System.Drawing.Point(149, 246);
			this.dtp_to.Name = "dtp_to";
			this.dtp_to.Size = new System.Drawing.Size(200, 20);
			this.dtp_to.TabIndex = 11;
			// 
			// dtp_from
			// 
			this.dtp_from.Location = new System.Drawing.Point(149, 187);
			this.dtp_from.Name = "dtp_from";
			this.dtp_from.Size = new System.Drawing.Size(200, 20);
			this.dtp_from.TabIndex = 12;
			// 
			// From
			// 
			this.From.AutoSize = true;
			this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.From.Location = new System.Drawing.Point(70, 187);
			this.From.Name = "From";
			this.From.Size = new System.Drawing.Size(42, 16);
			this.From.TabIndex = 8;
			this.From.Text = "From";
			// 
			// To
			// 
			this.To.AutoSize = true;
			this.To.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.To.Location = new System.Drawing.Point(70, 250);
			this.To.Name = "To";
			this.To.Size = new System.Drawing.Size(26, 16);
			this.To.TabIndex = 9;
			this.To.Text = "To";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(70, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Store";
			// 
			// com_storename
			// 
			this.com_storename.FormattingEnabled = true;
			this.com_storename.Location = new System.Drawing.Point(149, 128);
			this.com_storename.Name = "com_storename";
			this.com_storename.Size = new System.Drawing.Size(121, 21);
			this.com_storename.TabIndex = 7;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(230, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(251, 31);
			this.label6.TabIndex = 15;
			this.label6.Text = "Product Report No 11";
			// 
			// ProductName
			// 
			this.ProductName.HeaderText = "ProductName";
			this.ProductName.Name = "ProductName";
			// 
			// Code
			// 
			this.Code.HeaderText = "Code";
			this.Code.Name = "Code";
			// 
			// ImportDate
			// 
			this.ImportDate.HeaderText = "ImportDate";
			this.ImportDate.Name = "ImportDate";
			// 
			// ProductReportNo11
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(813, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_showreport);
			this.Controls.Add(this.dtp_to);
			this.Controls.Add(this.dtp_from);
			this.Controls.Add(this.From);
			this.Controls.Add(this.To);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.com_storename);
			this.Controls.Add(this.label6);
			this.Name = "ProductReportNo11";
			this.Text = "ProductReportNo11";
			this.Load += new System.EventHandler(this.ProductReportNo11_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.ComboBox com_storename;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Code;
		private System.Windows.Forms.DataGridViewTextBoxColumn ImportDate;
	}
}