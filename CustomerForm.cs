using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class CustomerForm : Form
	{
		Context context = new Context();
		public CustomerForm()
		{
			InitializeComponent();
		}
		private void GetAll()
		{
			var customers = from cus in context.Customers
							where cus != null
							select cus;
			foreach (var customer in customers)
			{
				listBox1.Items.Add(customer.Name);
			}
		}
		private void btn_show_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			GetAll();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if (tb_name.Text != "" && tb_mobile.Text != "" && tb_telephone.Text != "" && tb_website.Text != "" && tb_fax.Text != "" && tb_email.Text != "")
			{
				string Name = tb_name.Text;
				string Mobile = tb_mobile.Text;
				string Telephone = tb_telephone.Text;
				string Fax = tb_fax.Text;
				string Website = tb_website.Text;
				string Email = tb_email.Text;
				var Customer = new Customer()
				{
					Name = Name,
					Mobile = Mobile,
					Telephone = Telephone,
					Fax = Fax,
					website = Website,
					Email = Email,

				};
				context.Customers.Add(Customer);
				context.SaveChanges();
				tb_name.Text = tb_mobile.Text = tb_telephone.Text = tb_website.Text = tb_fax.Text = tb_email.Text = "";
				listBox1.Items.Clear();
				GetAll();
				MessageBox.Show("Customer Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (tb_id.Text != "" && tb_name.Text != "" && tb_mobile.Text != "" && tb_telephone.Text != "" && tb_website.Text != "" && tb_fax.Text != "" && tb_email.Text != "")
			{
				int id = int.Parse(tb_id.Text);
				string Name = tb_name.Text;
				string Mobile = tb_mobile.Text;
				string Telephone = tb_telephone.Text;
				string Fax = tb_fax.Text;
				string Website = tb_website.Text;
				string Email = tb_email.Text;

				var cup = context.Customers.FirstOrDefault(c => c.ID == id);
				if (cup != null)
				{
					cup.Name = Name;
					cup.Mobile = Mobile;
					cup.Telephone = Telephone;
					cup.Fax = Fax;
					cup.website = Website;
					cup.Email = Email;

					context.SaveChanges();
					tb_id.Text = tb_name.Text = tb_mobile.Text = tb_telephone.Text = tb_website.Text = tb_fax.Text = tb_email.Text = "";
					listBox1.Items.Clear();
					GetAll();
					MessageBox.Show("Customer Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selectedItem = listBox1.SelectedItem?.ToString();
			if (selectedItem != null)
			{
				var cup = context.Customers.FirstOrDefault(c => c.Name == selectedItem);
				if (cup != null)
				{
					tb_id.Text = cup.ID.ToString();
					tb_name.Text = cup.Name;
					tb_mobile.Text = cup.Mobile;
					tb_telephone.Text = cup.Telephone;
					tb_website.Text = cup.website;
					tb_fax.Text = cup.Fax;
					tb_email.Text = cup.Email;
				}
			}
		}
	}
}
