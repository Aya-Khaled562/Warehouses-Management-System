using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class ProductForm : Form
	{
		Context context = new Context();
		public ProductForm()
		{
			InitializeComponent();
		}
		private void GetAllProducts()
		{
			var products = from prd in context.Products
						   where prd != null
						   select prd;
			foreach (var product in products)
			{
				listBox1.Items.Add(product.Name);
			}
		} 

		private void ShowProducts_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			GetAllProducts();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if(tb_name.Text != "" && tb_code.Text != "" && tb_unities.Text != "" && StoreNameList.Text != ""&& tb_quantity.Text!="")
			{
				string Name = tb_name.Text;
				string Code = tb_code.Text;
				string Units = tb_unities.Text;
				decimal Quantity = decimal.Parse(tb_quantity.Text);
				string StoreName = StoreNameList.Text;
				int id = int.Parse(tb_id.Text);

				var store = context.Store.FirstOrDefault(s => s.Name == StoreName);
				var newProduct = new Product()
				{
					Name = Name,
					Code = Code,
					UnitsOfMeasure = Units,
					Quantity=Quantity,
					Store_ID = store.ID
				};
				context.Products.Add(newProduct);
				context.SaveChanges();
				tb_id.Text = tb_code.Text = tb_name.Text = tb_unities.Text = StoreNameList.Text = "";
				listBox1.Items.Clear();
				GetAllProducts();
				MessageBox.Show("Product Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void ProductForm_Load(object sender, EventArgs e)
		{
			var stores = context.Store.ToList();
			foreach (var store in stores)
			{
				StoreNameList.Items.Add(store.Name);
			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if(tb_id.Text!="" &&tb_name.Text!="" && tb_code.Text!="" && tb_unities.Text!="" && StoreNameList.Text != "" && tb_quantity.Text != "")
			{
				int id = int.Parse(tb_id.Text);
				string Name = tb_name.Text;
				string Code = tb_code.Text;
				string Units = tb_unities.Text;
				decimal Quantity = decimal.Parse(tb_quantity.Text);
				string StoreName = StoreNameList.Text;
				var prd = context.Products.FirstOrDefault(p=>p.ID == id);
				var stor = context.Store.FirstOrDefault(s=>s.Name == StoreName);
				prd.Name = Name;
				prd.Code = Code;
				prd.UnitsOfMeasure = Units;
				prd.Quantity = Quantity;
				prd.Store_ID = stor.ID;
				context.SaveChanges();
				tb_id.Text = tb_code.Text = tb_name.Text = tb_unities.Text = StoreNameList.Text = "";
				listBox1.Items.Clear();
				GetAllProducts();
				MessageBox.Show("Product Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var SelectedItem = listBox1.SelectedItem?.ToString();
			if (SelectedItem != null)
			{
				var itemData = context.Products.FirstOrDefault(p => p.Name == SelectedItem);
				if (itemData != null)
				{
					var storeData = context.Store.FirstOrDefault(s=>s.ID == itemData.Store_ID);
					
					tb_id.Text = itemData.ID.ToString();
					tb_code.Text = itemData.Code;
					tb_name.Text = itemData.Name;
					tb_unities.Text = itemData.UnitsOfMeasure;
					tb_quantity.Text = itemData.Quantity.ToString();
					StoreNameList.Text = storeData.Name;
				}
			}

		}
	}
}
