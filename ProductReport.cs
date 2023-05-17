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
	public partial class ProductReport : Form
	{
		Context context = new Context();
		public ProductReport()
		{
			InitializeComponent();
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

			var products = context.Products
						  .Where(p => storesId.Contains(p.Store_ID) && p.Name == prdName
							  && (p.ImportPermitDetail.Any(ip => ip.ImportPermit.PermitDate >= startDate && ip.ImportPermit.PermitDate <= endDate)
								  || p.ExchangePermitDetail.Any(ep => ep.ExchangePermit.PermitDate >= startDate && ep.ExchangePermit.PermitDate <= endDate)))
						  .ToList();


			var productsByStores = products.GroupBy(p => p.Store);
			dataGridView1.Rows.Clear();

			foreach (var productsInStore in productsByStores)
			{
				Store store = productsInStore.Key;

				foreach (Product product in productsInStore)
				{
					decimal totalQuantity = 0;
					foreach (ImportPermitDetail importDetail in product.ImportPermitDetail)
					{
						if (importDetail.ImportPermit.PermitDate >= startDate && importDetail.ImportPermit.PermitDate <= endDate)
						{
							totalQuantity += importDetail.Quantity;
						}
					}
					foreach (ExchangePermitDetail exchangeDetail in product.ExchangePermitDetail)
					{
						if (exchangeDetail.ExchangePermit.PermitDate >= startDate && exchangeDetail.ExchangePermit.PermitDate <= endDate)
						{
							totalQuantity -= exchangeDetail.Quantity;
						}
					}


					var rowIndex = dataGridView1.Rows.Add();
					var row = dataGridView1.Rows[rowIndex];
					row.Cells[0].Value = store.Name;
					row.Cells[1].Value = product.Name;
					row.Cells[2].Value = product.Code;
					row.Cells[3].Value = totalQuantity;
					row.Cells[4].Value = product.UnitsOfMeasure;
					
				}
			}
		

		}

		private void ProductReport_Load(object sender, EventArgs e)
		{
			var products = context.Products.Select(p=>p.Name).Distinct().ToList();
			foreach( var item in products)
			{
				com_productname.Items.Add(item);
			}
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
	}
}
