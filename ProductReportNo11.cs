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
	public partial class ProductReportNo11 : Form
	{
		Context context = new Context();
		public ProductReportNo11()
		{
			InitializeComponent();
		}

		private void ProductReportNo11_Load(object sender, EventArgs e)
		{
			var stores = context.Store.ToList();
			foreach(var store in stores)
			{
				com_storename.Items.Add(store.Name);
			}
		}

		private void btn_showreport_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			string storeName = com_storename.Text;
			DateTime startDate = dtp_from.Value;
			DateTime endDate = dtp_to.Value;

			var products = (from prd in context.Products
						   from store in context.Store
						   from importDetails in prd.ImportPermitDetail
						   where store.Name == storeName &&
								prd.Store_ID == store.ID &&
								prd.ImportPermitDetail.Any(ipd => ipd.ImportPermit.PermitDate >= startDate && ipd.ImportPermit.PermitDate <= endDate) ||
								prd.ExchangePermitDetail.Any(ipd => ipd.ExchangePermit.PermitDate >= startDate && ipd.ExchangePermit.PermitDate < endDate)

						   select new
						   {
							   ProductName = prd.Name,
							   Code = prd.Code,
							   PermitDate = importDetails.ImportPermit.PermitDate
						   }).Distinct();
			
			
			foreach (var item in products)
			{
				var rowIndex = dataGridView1.Rows.Add();
				var row = dataGridView1.Rows[rowIndex];
				row.Cells[0].Value = item.ProductName;
				row.Cells[1].Value = item.Code;
				row.Cells[2].Value = item.PermitDate;
			}

		


		}
	}
}
