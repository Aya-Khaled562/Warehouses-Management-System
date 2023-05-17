using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
	public partial class TransferItemReport : Form
	{
		Context context = new Context();
		public TransferItemReport()
		{
			InitializeComponent();
		}

		private void com_productname_SelectedIndexChanged(object sender, EventArgs e)
		{
			StoresName.Items.Clear();

			var selectedProduct = com_productname.Text;

			var products = context.Products.Where(p => p.Name == selectedProduct);
			foreach (var prd in products)
			{
				var stores = context.Store.Where(s => s.ID == prd.Store_ID);
				foreach (var item in stores)
				{
					StoresName.Items.Add(item.Name);
				}
			}

		}

		private void TransferItemReport_Load(object sender, EventArgs e)
		{
			var products = context.Products.Select(p => p.Name).Distinct().ToList();
			foreach (var item in products)
			{
				com_productname.Items.Add(item);
			}
		}

		private void btn_showreport_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();

			DateTime startDate = dtp_from.Value;
			DateTime endDate = dtp_to.Value;

			string prdName = com_productname.Text;

			List<int> storesId = new List<int>();

			foreach (var item in StoresName.CheckedItems)
			{
				string storeName = item.ToString();
				Store store = context.Store.FirstOrDefault(s => s.Name == storeName);
				if (store != null)
				{
					storesId.Add(store.ID);
				}
			}

			var productsMovement = context.TransferItems
				.Where(ti => storesId.Contains(ti.Transfer.ToStore.ID)
					&& ti.Transfer.TransferDate >= startDate
					&& ti.Transfer.TransferDate <= endDate)
				.GroupBy(ti => new { ti.Product.ID, ti.Product.Name})
				.Select(g => new
				{
					FromStore = g.Select(ti=>ti.Transfer.FromStore.Name),
					ToStore = g.Select(ti=>ti.Transfer.ToStore.Name),
					ProductName = g.Key.Name,
					TotalQuantityIn = g.Sum(ti => ti.Quantity),
					TotalQuantityOut = context.TransferItems
						.Where(ti => storesId.Contains(ti.Transfer.FromStore.ID)
							&& ti.Product.ID == g.Key.ID
							&& ti.Transfer.TransferDate >= startDate
							&& ti.Transfer.TransferDate <= endDate)
						.Sum(ti => ti.Quantity)
				})
				.ToList();

			if(productsMovement.Count > 0)
			{
				foreach (var item in productsMovement)
				{
					var rowIndex = dataGridView1.Rows.Add();
					var row = dataGridView1.Rows[rowIndex];
					row.Cells[0].Value = item.ProductName;
					row.Cells[1].Value = item.FromStore;
					row.Cells[2].Value = item.ToStore;
					row.Cells[3].Value = item.TotalQuantityIn;
					row.Cells[4].Value = item.TotalQuantityOut;
				}
			}
			else
			{
				MessageBox.Show("No Data Found... Please Check Your Data","Warning" , MessageBoxButtons.OK, MessageBoxIcon.Warning);				MessageBox.Show("No Data Found... Please Check Your Data","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}

		}

	
	}
}
