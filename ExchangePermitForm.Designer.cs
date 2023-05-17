namespace Project
{
	partial class ExchangePermitForm
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
			this.dtp_primitdate = new System.Windows.Forms.DateTimePicker();
			this.com_prdname = new System.Windows.Forms.ComboBox();
			this.com_storesupplier = new System.Windows.Forms.ComboBox();
			this.com_storename = new System.Windows.Forms.ComboBox();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.PremitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_permitnumber = new System.Windows.Forms.TextBox();
			this.tb_quantities = new System.Windows.Forms.TextBox();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_show
			// 
			this.btn_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_show.Location = new System.Drawing.Point(677, 308);
			this.btn_show.Name = "btn_show";
			this.btn_show.Size = new System.Drawing.Size(193, 37);
			this.btn_show.TabIndex = 21;
			this.btn_show.Text = "Show Exchange Premit";
			this.btn_show.UseVisualStyleBackColor = true;
			this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
			// 
			// dtp_primitdate
			// 
			this.dtp_primitdate.Location = new System.Drawing.Point(134, 154);
			this.dtp_primitdate.Name = "dtp_primitdate";
			this.dtp_primitdate.Size = new System.Drawing.Size(200, 20);
			this.dtp_primitdate.TabIndex = 3;
			// 
			// com_prdname
			// 
			this.com_prdname.FormattingEnabled = true;
			this.com_prdname.Location = new System.Drawing.Point(367, 19);
			this.com_prdname.Name = "com_prdname";
			this.com_prdname.Size = new System.Drawing.Size(116, 21);
			this.com_prdname.TabIndex = 2;
			// 
			// com_storesupplier
			// 
			this.com_storesupplier.FormattingEnabled = true;
			this.com_storesupplier.Location = new System.Drawing.Point(116, 96);
			this.com_storesupplier.Name = "com_storesupplier";
			this.com_storesupplier.Size = new System.Drawing.Size(116, 21);
			this.com_storesupplier.TabIndex = 2;
			// 
			// com_storename
			// 
			this.com_storename.FormattingEnabled = true;
			this.com_storename.Location = new System.Drawing.Point(116, 56);
			this.com_storename.Name = "com_storename";
			this.com_storename.Size = new System.Drawing.Size(116, 21);
			this.com_storename.TabIndex = 2;
			this.com_storename.SelectedIndexChanged += new System.EventHandler(this.com_storename_SelectedIndexChanged);
			// 
			// btn_update
			// 
			this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_update.Location = new System.Drawing.Point(241, 234);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(197, 37);
			this.btn_update.TabIndex = 1;
			this.btn_update.Text = "Update Exchange Premit";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_add
			// 
			this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Location = new System.Drawing.Point(24, 234);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(172, 37);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "Add Exchange Premit";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PremitNo,
            this.Store,
            this.Supplier,
            this.Product,
            this.Quantity});
			this.dataGridView1.Location = new System.Drawing.Point(547, 94);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(539, 171);
			this.dataGridView1.TabIndex = 24;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// PremitNo
			// 
			this.PremitNo.HeaderText = "PremitNo";
			this.PremitNo.Name = "PremitNo";
			// 
			// Store
			// 
			this.Store.HeaderText = "Store";
			this.Store.Name = "Store";
			// 
			// Supplier
			// 
			this.Supplier.HeaderText = "Supplier";
			this.Supplier.Name = "Supplier";
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
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(257, 98);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 15);
			this.label10.TabIndex = 1;
			this.label10.Text = "Permit Number";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(426, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(203, 31);
			this.label6.TabIndex = 23;
			this.label6.Text = "Exchange Premit";
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
			this.label7.Location = new System.Drawing.Point(34, 154);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "Permit Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sipplier";
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
			this.label1.Location = new System.Drawing.Point(34, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Store ";
			// 
			// tb_permitnumber
			// 
			this.tb_permitnumber.Location = new System.Drawing.Point(367, 97);
			this.tb_permitnumber.Name = "tb_permitnumber";
			this.tb_permitnumber.Size = new System.Drawing.Size(116, 20);
			this.tb_permitnumber.TabIndex = 0;
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
			this.panel1.Controls.Add(this.dtp_primitdate);
			this.panel1.Controls.Add(this.com_prdname);
			this.panel1.Controls.Add(this.com_storesupplier);
			this.panel1.Controls.Add(this.com_storename);
			this.panel1.Controls.Add(this.btn_update);
			this.panel1.Controls.Add(this.btn_add);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tb_permitnumber);
			this.panel1.Controls.Add(this.tb_quantities);
			this.panel1.Controls.Add(this.tb_id);
			this.panel1.Location = new System.Drawing.Point(12, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(511, 298);
			this.panel1.TabIndex = 22;
			// 
			// ExchangePermitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 450);
			this.Controls.Add(this.btn_show);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Name = "ExchangePermitForm";
			this.Text = "ExchangePermitForm";
			this.Load += new System.EventHandler(this.ExchangePermitForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_show;
		private System.Windows.Forms.DateTimePicker dtp_primitdate;
		private System.Windows.Forms.ComboBox com_prdname;
		private System.Windows.Forms.ComboBox com_storesupplier;
		private System.Windows.Forms.ComboBox com_storename;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn PremitNo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Store;
		private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
		private System.Windows.Forms.DataGridViewTextBoxColumn Product;
		private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_permitnumber;
		private System.Windows.Forms.TextBox tb_quantities;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Panel panel1;
	}
}