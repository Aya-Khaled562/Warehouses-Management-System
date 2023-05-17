using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class StoreReport : Form
	{
		Context context = new Context();
		public StoreReport()
		{
			InitializeComponent();
		}

		private void StoreReport_Load(object sender, EventArgs e)
		{
			var stores = context.Store.ToList();

			foreach (var store in stores)
			{
				com_storename.Items.Add(store.Name);
			}

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void btn_showreport_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			string storeName = com_storename.Text;
			DateTime startDate = dtp_from.Value;
			DateTime endDate = dtp_to.Value;

			var query = (from store in context.Store
						 from product in context.Products
						 from import in context.ImportPermits
						 from importDetails in context.ImportPermitDetails
						 where store.Name == storeName && product.Store_ID == store.ID
							   && import.PermitDate >= startDate && import.PermitDate <= endDate
							   && importDetails.ImportPermitId == import.ID && importDetails.ProductId == product.ID
						 select new
						 {
							 StoreName = storeName,
							 Address = store.Address,
							 Manager = store.ResponsiblePerson,
							 ProductName = product.Name,
							 Quantity = product.Quantity,
							 ImportDate = import.PermitDate
						 }).ToList();

			if (query.Count != 0)
			{
				foreach (var item in query)
				{
					var rowIndex = dataGridView1.Rows.Add();
					var row = dataGridView1.Rows[rowIndex];
					row.Cells[0].Value = item.StoreName;
					row.Cells[1].Value = item.Address;
					row.Cells[2].Value = item.Manager.Name;
					row.Cells[3].Value = item.ProductName;
					row.Cells[4].Value = item.Quantity;
					row.Cells[5].Value = item.ImportDate;
				}

			}
			else
			{
				MessageBox.Show("Data Not Found");

			}
		}
	}
}
