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
	public partial class SupplierForm : Form
	{
		Context context = new Context();
		public SupplierForm()
		{
			InitializeComponent();
		}

		private void SupplierForm_Load(object sender, EventArgs e)
		{
			
		}
		private void GetAll()
		{
			var suppliers = from sup in context.Suppliers
							where sup != null
							select sup;
			foreach (var supplier in suppliers)
			{
				listBox1.Items.Add(supplier.Name);
			}
		}

		private void btn_show_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			GetAll();

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if(tb_name.Text!="" &&tb_mobile.Text!=""&&tb_telephone.Text!=""&& tb_website.Text != ""&& tb_fax.Text!="" && tb_email.Text!="")
			{
				string Name = tb_name.Text;
				string Mobile = tb_mobile.Text;
				string Telephone = tb_telephone.Text;
				string Fax = tb_fax.Text;
				string Website = tb_website.Text;
				string Email = tb_email.Text;
				var Supplier = new Supplier()
				{
					Name = Name,
					Mobile = Mobile,
					Telephone = Telephone,
					Fax = Fax,
					website = Website,
					Email = Email,

				};
				context.Suppliers.Add( Supplier );
				context.SaveChanges();
				tb_name.Text = tb_mobile.Text = tb_telephone.Text = tb_website.Text = tb_fax.Text = tb_email.Text= "";
				listBox1.Items.Clear();
				GetAll();
				MessageBox.Show("Supplier Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (tb_id.Text!="" && tb_name.Text != "" && tb_mobile.Text != "" && tb_telephone.Text != "" && tb_website.Text != "" && tb_fax.Text != ""&&tb_email.Text!="")
			{
				int id = int.Parse(tb_id.Text);
				string Name = tb_name.Text;
				string Mobile = tb_mobile.Text;
				string Telephone = tb_telephone.Text;
				string Fax = tb_fax.Text;
				string Website = tb_website.Text;
				string Email = tb_email.Text;

				var sup = context.Suppliers.FirstOrDefault(s=>s.ID == id);
				if (sup != null)
				{
					sup.Name = Name;
					sup.Mobile = Mobile;
					sup.Telephone = Telephone;
					sup.Fax = Fax;
					sup.website = Website;
					sup.Email = Email;

					context.SaveChanges();
					tb_id.Text= tb_name.Text = tb_mobile.Text = tb_telephone.Text = tb_website.Text = tb_fax.Text = tb_email.Text = "";
					listBox1.Items.Clear();
					GetAll();
					MessageBox.Show("Supplier Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				var sup = context.Suppliers.FirstOrDefault(s=>s.Name == selectedItem);
				if (sup != null)
				{
					tb_id.Text = sup.ID.ToString();
					tb_name.Text = sup.Name;
					tb_mobile.Text = sup.Mobile;
					tb_telephone.Text = sup.Telephone;
					tb_website.Text = sup.website;
					tb_fax.Text = sup.Fax;
					tb_email.Text = sup.Email;
				}
			}
		}
	}
}
