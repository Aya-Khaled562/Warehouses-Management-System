namespace Project
{
	partial class ProductForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.ShowProducts = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.StoreNameList = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_unities = new System.Windows.Forms.TextBox();
			this.tb_code = new System.Windows.Forms.TextBox();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tb_quantity = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(444, 112);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(174, 186);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// ShowProducts
			// 
			this.ShowProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShowProducts.Location = new System.Drawing.Point(471, 323);
			this.ShowProducts.Name = "ShowProducts";
			this.ShowProducts.Size = new System.Drawing.Size(125, 37);
			this.ShowProducts.TabIndex = 1;
			this.ShowProducts.Text = "Show Products";
			this.ShowProducts.UseVisualStyleBackColor = true;
			this.ShowProducts.Click += new System.EventHandler(this.ShowProducts_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.StoreNameList);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btn_update);
			this.panel1.Controls.Add(this.btn_add);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tb_quantity);
			this.panel1.Controls.Add(this.tb_unities);
			this.panel1.Controls.Add(this.tb_code);
			this.panel1.Controls.Add(this.tb_id);
			this.panel1.Controls.Add(this.tb_name);
			this.panel1.Location = new System.Drawing.Point(55, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(342, 336);
			this.panel1.TabIndex = 2;
			// 
			// StoreNameList
			// 
			this.StoreNameList.FormattingEnabled = true;
			this.StoreNameList.Location = new System.Drawing.Point(116, 218);
			this.StoreNameList.Name = "StoreNameList";
			this.StoreNameList.Size = new System.Drawing.Size(174, 21);
			this.StoreNameList.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(27, 218);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 15);
			this.label4.TabIndex = 1;
			this.label4.Text = "Store Name";
			// 
			// btn_update
			// 
			this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_update.Location = new System.Drawing.Point(182, 272);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(125, 37);
			this.btn_update.TabIndex = 1;
			this.btn_update.Text = "Update Product";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_add
			// 
			this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Location = new System.Drawing.Point(30, 272);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(125, 37);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "Add Product";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(34, 138);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Unitis";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(34, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Code";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(34, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 15);
			this.label5.TabIndex = 1;
			this.label5.Text = "Prd_id";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// tb_unities
			// 
			this.tb_unities.Location = new System.Drawing.Point(116, 138);
			this.tb_unities.Name = "tb_unities";
			this.tb_unities.Size = new System.Drawing.Size(174, 20);
			this.tb_unities.TabIndex = 0;
			// 
			// tb_code
			// 
			this.tb_code.Location = new System.Drawing.Point(116, 98);
			this.tb_code.Name = "tb_code";
			this.tb_code.Size = new System.Drawing.Size(174, 20);
			this.tb_code.TabIndex = 0;
			// 
			// tb_id
			// 
			this.tb_id.Enabled = false;
			this.tb_id.HideSelection = false;
			this.tb_id.Location = new System.Drawing.Point(116, 19);
			this.tb_id.Name = "tb_id";
			this.tb_id.ReadOnly = true;
			this.tb_id.Size = new System.Drawing.Size(174, 20);
			this.tb_id.TabIndex = 0;
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(116, 56);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(174, 20);
			this.tb_name.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(330, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(112, 31);
			this.label6.TabIndex = 3;
			this.label6.Text = "Products";
			// 
			// tb_quantity
			// 
			this.tb_quantity.Location = new System.Drawing.Point(116, 177);
			this.tb_quantity.Name = "tb_quantity";
			this.tb_quantity.Size = new System.Drawing.Size(174, 20);
			this.tb_quantity.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(34, 177);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 15);
			this.label7.TabIndex = 1;
			this.label7.Text = "Quantity";
			// 
			// ProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 450);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ShowProducts);
			this.Controls.Add(this.listBox1);
			this.Name = "ProductForm";
			this.Text = "Product";
			this.Load += new System.EventHandler(this.ProductForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button ShowProducts;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_unities;
		private System.Windows.Forms.TextBox tb_code;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.ComboBox StoreNameList;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_quantity;
	}
}