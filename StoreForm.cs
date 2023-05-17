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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Project
{
	public partial class StoreForm : Form
	{
		Context context = new Context();
		public StoreForm()
		{
			InitializeComponent();
		}

		private void GetAll()
		{
			var stores = from store in context.Store
						 where store != null
						 select store;
			foreach (var store in stores)
			{
				listBox1.Items.Add(store.Name);
			}
		}
		private void ShowProducts_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			GetAll();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if(tb_name.Text!="" && tb_address.Text!="" && tb_manager.Text != "")
			{
				string Name = tb_name.Text;
				string Address = tb_address.Text;	
				string Manager = tb_manager.Text;
				var mang = context.Employees.FirstOrDefault(m=>m.Name == Manager);
				if(mang != null)
				{
					var newStore = new Store()
					{
						Name = Name,
						Address = Address,
						EmployeeId = mang.ID
					};
					context.Store.Add(newStore);
					context.SaveChanges();
					listBox1.Items.Clear();
					tb_name.Text = tb_address.Text = tb_manager.Text = "";
					GetAll();
					MessageBox.Show("Store Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
				else
				{
					MessageBox.Show("Manager Name is not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
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
				var itemData = context.Store.FirstOrDefault(s => s.Name == SelectedItem);
				if (itemData != null)
				{
					var empData = context.Employees.FirstOrDefault(em => em.ID == itemData.EmployeeId);

					tb_id.Text = itemData.ID.ToString();
					tb_name.Text = itemData.Name;
					tb_address.Text = itemData.Address;
					tb_manager.Text = empData.Name;
				}
			}
		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (tb_name.Text != "" && tb_address.Text != "" && tb_manager.Text != "")
			{
				int id = int.Parse(tb_id.Text);
				string Name = tb_name.Text;
				string Address = tb_address.Text;
				string Manager = tb_manager.Text;

				var store = context.Store.FirstOrDefault(s=>s.ID == id);
				if(store != null)
				{
					var mang = context.Employees.FirstOrDefault(m => m.Name == Manager);
					if (mang != null)
					{
						store.Name = Name;
						store.Address = Address;
						store.EmployeeId = mang.ID;
						
						context.SaveChanges();
						listBox1.Items.Clear();
						tb_name.Text = tb_address.Text = tb_manager.Text = "";
						GetAll();
						MessageBox.Show("Store Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else
					{
						MessageBox.Show("Manager Name is not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("This Store Does not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
