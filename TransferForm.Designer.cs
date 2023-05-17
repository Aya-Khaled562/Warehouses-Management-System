namespace Project
{
	partial class TransferForm
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
			this.btn_show = new System.Windows.Forms.Button();
			this.dtp_expirydate = new System.Windows.Forms.DateTimePicker();
			this.dtp_proddate = new System.Windows.Forms.DateTimePicker();
			this.dtp_transferdate = new System.Windows.Forms.DateTimePicker();
			this.com_prdname = new System.Windows.Forms.ComboBox();
			this.com_tostore = new System.Windows.Forms.ComboBox();
			this.com_fromstore = new System.Windows.Forms.ComboBox();
			this.btn_transfer = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_quantities = new System.Windows.Forms.TextBox();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TransferNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FromStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ToStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_permitnumber = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_show
			// 
			this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_show.Location = new System.Drawing.Point(729, 308);
			this.btn_show.Name = "btn_show";
			this.btn_show.Size = new System.Drawing.Size(165, 37);
			this.btn_show.TabIndex = 21;
			this.btn_show.Text = "Show Transfers\r\n";
			this.btn_show.UseVisualStyleBackColor = true;
			this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
			// 
			// dtp_expirydate
			// 
			this.dtp_expirydate.Location = new System.Drawing.Point(134, 195);
			this.dtp_expirydate.Name = "dtp_expirydate";
			this.dtp_expirydate.Size = new System.Drawing.Size(200, 20);
			this.dtp_expirydate.TabIndex = 3;
			// 
			// dtp_proddate
			// 
			this.dtp_proddate.Location = new System.Drawing.Point(134, 242);
			this.dtp_proddate.Name = "dtp_proddate";
			this.dtp_proddate.Size = new System.Drawing.Size(200, 20);
			this.dtp_proddate.TabIndex = 3;
			// 
			// dtp_transferdate
			// 
			this.dtp_transferdate.Location = new System.Drawing.Point(134, 154);
			this.dtp_transferdate.Name = "dtp_transferdate";
			this.dtp_transferdate.Size = new System.Drawing.Size(200, 20);
			this.dtp_transferdate.TabIndex = 3;
			// 
			// com_prdname
			// 
			this.com_prdname.FormattingEnabled = true;
			this.com_prdname.Location = new System.Drawing.Point(367, 19);
			this.com_prdname.Name = "com_prdname";
			this.com_prdname.Size = new System.Drawing.Size(116, 21);
			this.com_prdname.TabIndex = 2;
			// 
			// com_tostore
			// 
			this.com_tostore.FormattingEnabled = true;
			this.com_tostore.Location = new System.Drawing.Point(116, 96);
			this.com_tostore.Name = "com_tostore";
			this.com_tostore.Size = new System.Drawing.Size(116, 21);
			this.com_tostore.TabIndex = 2;
			// 
			// com_fromstore
			// 
			this.com_fromstore.FormattingEnabled = true;
			this.com_fromstore.Location = new System.Drawing.Point(116, 56);
			this.com_fromstore.Name = "com_fromstore";
			this.com_fromstore.Size = new System.Drawing.Size(116, 21);
			this.com_fromstore.TabIndex = 2;
			this.com_fromstore.SelectedIndexChanged += new System.EventHandler(this.com_fromstore_SelectedIndexChanged);
			// 
			// btn_transfer
			// 
			this.btn_transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_transfer.Location = new System.Drawing.Point(156, 296);
			this.btn_transfer.Name = "btn_transfer";
			this.btn_transfer.Size = new System.Drawing.Size(153, 37);
			this.btn_transfer.TabIndex = 1;
			this.btn_transfer.Text = "Transfer";
			this.btn_transfer.UseVisualStyleBackColor = true;
			this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransferNo,
            this.FromStore,
            this.ToStore,
            this.Product,
            this.Quantity});
			this.dataGridView1.Location = new System.Drawing.Point(558, 95);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(539, 171);
			this.dataGridView1.TabIndex = 24;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(34, 199);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 15);
			this.label9.TabIndex = 1;
			this.label9.Text = "Expiry Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(285, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Product";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(18, 242);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 15);
			this.label8.TabIndex = 1;
			this.label8.Text = "Production Date";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(435, 23);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 31);
			this.label6.TabIndex = 23;
			this.label6.Text = "Transfer Premit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(275, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Quentity";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(28, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "Transfer Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "To Store";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "From Store ";
			// 
			// tb_quantities
			// 
			this.tb_quantities.Location = new System.Drawing.Point(367, 57);
			this.tb_quantities.Name = "tb_quantities";
			this.tb_quantities.Size = new System.Drawing.Size(116, 20);
			this.tb_quantities.TabIndex = 0;
			// 
			// tb_id
			// 
			this.tb_id.Enabled = false;
			this.tb_id.HideSelection = false;
			this.tb_id.Location = new System.Drawing.Point(116, 18);
			this.tb_id.Name = "tb_id";
			this.tb_id.ReadOnly = true;
			this.tb_id.Size = new System.Drawing.Size(116, 20);
			this.tb_id.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.tb_permitnumber);
			this.panel1.Controls.Add(this.dtp_expirydate);
			this.panel1.Controls.Add(this.dtp_proddate);
			this.panel1.Controls.Add(this.dtp_transferdate);
			this.panel1.Controls.Add(this.com_prdname);
			this.panel1.Controls.Add(this.com_tostore);
			this.panel1.Controls.Add(this.com_fromstore);
			this.panel1.Controls.Add(this.btn_transfer);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tb_quantities);
			this.panel1.Controls.Add(this.tb_id);
			this.panel1.Location = new System.Drawing.Point(26, 76);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(511, 352);
			this.panel1.TabIndex = 22;
			// 
			// TransferNo
			// 
			this.TransferNo.HeaderText = "TransferNo";
			this.TransferNo.Name = "TransferNo";
			// 
			// FromStore
			// 
			this.FromStore.HeaderText = "FromStore";
			this.FromStore.Name = "FromStore";
			// 
			// ToStore
			// 
			this.ToStore.HeaderText = "ToStore";
			this.ToStore.Name = "ToStore";
			// 
			// Product
			// 
			this.Product.HeaderText = "Product";
			this.Product.Name = "Product";
			// 
			// Quantity
			// 
			this.Quantity.HeaderText = "Quantity";
			this.Quantity.Name = "Quantity";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(257, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 15);
			this.label10.TabIndex = 5;
			this.label10.Text = "Permit Number";
			// 
			// tb_permitnumber
			// 
			this.tb_permitnumber.Location = new System.Drawing.Point(367, 96);
			this.tb_permitnumber.Name = "tb_permitnumber";
			this.tb_permitnumber.Size = new System.Drawing.Size(116, 20);
			this.tb_permitnumber.TabIndex = 4;
			// 
			// TransferForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1109, 450);
			this.Controls.Add(this.btn_show);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Name = "TransferForm";
			this.Text = "TransferForm";
			this.Load += new System.EventHandler(this.TransferForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_show;
		private System.Windows.Forms.DateTimePicker dtp_expirydate;
		private System.Windows.Forms.DateTimePicker dtp_proddate;
		private System.Windows.Forms.DateTimePicker dtp_transferdate;
		private System.Windows.Forms.ComboBox com_prdname;
		private System.Windows.Forms.ComboBox com_tostore;
		private System.Windows.Forms.ComboBox com_fromstore;
		private System.Windows.Forms.Button btn_transfer;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_quantities;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TransferNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FromStore;
		private System.Windows.Forms.DataGridViewTextBoxColumn ToStore;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tb_permitnumber;
	}
}