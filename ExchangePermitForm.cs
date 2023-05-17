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
	public partial class ExchangePermitForm : Form
	{
		Context context = new Context();
		public ExchangePermitForm()
		{
			InitializeComponent();
		}

		private void GetAll()
		{
			var exchange = from ex in context.ExchangePermits
						  where ex != null
						  select ex;


			foreach (var exch in exchange)
			{
				var rowIndex = dataGridView1.Rows.Add();
				var row = dataGridView1.Rows[rowIndex];

				row.Cells[0].Value = exch.PermitNumber;

				var str = context.Store.FirstOrDefault(s => s.ID == exch.StoreId);
				row.Cells[1].Value = str?.Name;

				var sup = context.Suppliers.FirstOrDefault(s => s.ID == exch.SupplierId);
				row.Cells[2].Value = sup?.Name;

				var exchangeDetails = context.ExchangePermitDetail.FirstOrDefault(p => p.ExchangePermitId == exch.ID);

				if (exchangeDetails != null)
				{
					var product = context.Products.FirstOrDefault(pr => pr.ID == exchangeDetails.ProductId);
					row.Cells[3].Value = product?.Name;
					row.Cells[4].Value = exchangeDetails.Quantity;
				}
			}

		}

		private void btn_show_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			GetAll();
		}
		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			var exportNumber = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

			var exportPremit = context.ExchangePermits.FirstOrDefault(p => p.PermitNumber == exportNumber);
			tb_id.Text = exportPremit.ID.ToString();
			tb_permitnumber.Text = exportPremit.PermitNumber.ToString();
			dtp_primitdate.Value = exportPremit.PermitDate;
			
			var exportDetails = context.ExchangePermitDetail.FirstOrDefault(d => d.ExchangePermitId == exportPremit.ID);
			tb_quantities.Text = exportDetails.Quantity.ToString();

			com_storename.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			com_storesupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			com_prdname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if (com_storename.Text != "" && com_prdname.Text != "" && com_storesupplier.Text != "" && tb_permitnumber.Text != "" && tb_quantities.Text != "")
			{
				string storeName = com_storename.Text;
				string prdname = com_prdname.Text;
				string supplierName = com_storesupplier.Text;
				DateTime premitDate = dtp_primitdate.Value;
				string premitNumber = tb_permitnumber.Text;
				decimal quantity = decimal.Parse(tb_quantities.Text);

				var store = context.Store.FirstOrDefault(s => s.Name == storeName);
				var product = context.Products.FirstOrDefault(p => p.Name == prdname);
				var supplier = context.Suppliers.FirstOrDefault(sup => sup.Name == supplierName);

				var newExchangePremit = new ExchangePermit()
				{
					StoreId = store.ID,
					PermitNumber = premitNumber,
					PermitDate = premitDate,
					SupplierId = supplier.ID
				};
				context.ExchangePermits.Add(newExchangePremit);
				

				var prd = context.Products.FirstOrDefault(p => p.Store_ID == store.ID && p.ID == product.ID);
				if (prd != null)
				{
					if(prd.Quantity>=quantity)
					{
						prd.Quantity -= quantity;
					}
					else
					{
						MessageBox.Show("Quantity for this prodect is less than your order.. Please check data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
						dtp_primitdate.Value = DateTime.Now;
						dataGridView1.Rows.Clear();
						GetAll();
						return;
					}
				}
				else
				{
					MessageBox.Show("There is no product found for this store.. Please check data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
					dtp_primitdate.Value  = DateTime.Now;
					dataGridView1.Rows.Clear();
					GetAll();
					return;

				}

				context.SaveChanges();

				var newExchangeDetails = new ExchangePermitDetail()
				{
					ProductId = product.ID,
					Quantity = quantity,
					ExchangePermitId = newExchangePremit.ID,
				};
				context.ExchangePermitDetail.Add(newExchangeDetails);
				context.SaveChanges();
				tb_id.Text = com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
				dtp_primitdate.Value = DateTime.Now;
				dataGridView1.Rows.Clear();
				GetAll();
				MessageBox.Show("Exchange Premit Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_update_Click(object sender, EventArgs e)
		{
			if (com_storename.Text != "" && com_prdname.Text != "" && com_storesupplier.Text != "" && tb_permitnumber.Text != "" && tb_quantities.Text != "")
			{
				int id = int.Parse(tb_id.Text);
				string storeName = com_storename.Text;
				string prdname = com_prdname.Text;
				string supplierName = com_storesupplier.Text;
				DateTime premitDate = dtp_primitdate.Value;
				string premitNumber = tb_permitnumber.Text;
				decimal quantity = decimal.Parse(tb_quantities.Text);

				var store = context.Store.FirstOrDefault(s => s.Name == storeName);
				var product = context.Products.FirstOrDefault(p => p.Name == prdname);
				var supplier = context.Suppliers.FirstOrDefault(sup => sup.Name == supplierName);

				var exportPremit = context.ExchangePermits.FirstOrDefault(ex => ex.ID == id);

				exportPremit.StoreId = store.ID;
				exportPremit.PermitNumber = premitNumber;
				exportPremit.PermitDate = premitDate;
				exportPremit.SupplierId = supplier.ID;

				var prd = context.Products.FirstOrDefault(p => p.Store_ID == store.ID && p.ID == product.ID);
				if (prd.Quantity >= quantity)
				{
					prd.Quantity -= quantity;
				}
				else
				{
					MessageBox.Show("Quantity for this prodect is less than your order.. Please check data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
					dtp_primitdate.Value = DateTime.Now;
					dataGridView1.Rows.Clear();
					GetAll();
					return;
				}

				var exportDetails = context.ExchangePermitDetail.FirstOrDefault(ex => ex.ExchangePermitId == id);
				exportDetails.ProductId = product.ID;
				exportDetails.Quantity = quantity;

				context.SaveChanges();
				tb_id.Text= com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
				dtp_primitdate.Value = DateTime.Now;
				dataGridView1.Rows.Clear();
				GetAll();
				MessageBox.Show("Exchange Premit Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void ExchangePermitForm_Load(object sender, EventArgs e)
		{
			var storeList = context.Store.ToList();
			foreach (var store in storeList)
			{
				com_storename.Items.Add(store.Name);
			}

			var supList = context.Suppliers.ToList();
			foreach (var sup in supList)
			{
				com_storesupplier.Items.Add(sup.Name);
			}
		}

		private void com_storename_SelectedIndexChanged(object sender, EventArgs e)
		{
			var storeName = com_storename.Text;
			var store = context.Store.FirstOrDefault(s => s.Name == storeName);

			com_prdname.Items.Clear();
			var prodList = from prd in context.Products
						   where prd.Store_ID == store.ID
						   select prd;
			foreach (var prod in prodList)
			{
				com_prdname.Items.Add(prod.Name);
			}
		}
	}
}
