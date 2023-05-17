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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ProductForm prd = new ProductForm();
			prd.Show();
		}

		private void btn_store_Click(object sender, EventArgs e)
		{
			StoreForm store = new StoreForm();
			store.Show();
		}

		private void btn_supplier_Click(object sender, EventArgs e)
		{
			SupplierForm supplier = new SupplierForm();
			supplier.Show();
		}

		private void btn_customer_Click(object sender, EventArgs e)
		{
			CustomerForm customer = new CustomerForm();
			customer.Show();
		}

		private void btn_importpremit_Click(object sender, EventArgs e)
		{
			ImportPremitForm importPremitForm = new ImportPremitForm();
			importPremitForm.Show(); 
		}

		private void btn_exchangepremit_Click(object sender, EventArgs e)
		{
			ExchangePermitForm exchange = new ExchangePermitForm();
			exchange.Show();
		}

		private void btn_transfer_Click(object sender, EventArgs e)
		{
			TransferForm transfer = new TransferForm();
			transfer.Show();
		}

		private void btn_storereport_Click(object sender, EventArgs e)
		{
			StoreReport storeReport = new StoreReport();
			storeReport.Show();
		}

		private void btn_productreport_Click(object sender, EventArgs e)
		{
			ProductReport productReport = new ProductReport();
			productReport.Show();
		}

		private void btn_prdreportNo11_Click(object sender, EventArgs e)
		{
			ProductReportNo11 productReportNo11 = new ProductReportNo11();
			productReportNo11.Show();
		}

		private void btn_trasferreport_Click(object sender, EventArgs e)
		{
			TransferItemReport transferItemReport = new TransferItemReport();
			transferItemReport.Show();
		}
	}
}
