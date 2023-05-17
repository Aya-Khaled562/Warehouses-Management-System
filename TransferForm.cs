using Project.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Project
{
	public partial class TransferForm : Form
	{
		Context context = new Context();
		public TransferForm()
		{
			InitializeComponent();
		}

		private void GetAll()
		{
			var transfers = from tran in context.Transfers
						  where tran != null
						  select tran;

			foreach (var transfer in transfers)
			{
				var rowIndex = dataGridView1.Rows.Add();
				var row = dataGridView1.Rows[rowIndex];

				row.Cells[0].Value = transfer.TransferNumber;
				var fromStore = context.Store.FirstOrDefault(fs=>fs.ID == transfer.FromStoreId);	
				row.Cells[1].Value = fromStore?.Name;

				var toStore = context.Store.FirstOrDefault(s => s.ID == transfer.ToStoreId);
				row.Cells[2].Value = toStore?.Name;


				var transferDetails = context.TransferItems.FirstOrDefault(t => t.TransferId == transfer.ID);

				if (transferDetails != null)
				{
					var product = context.Products.FirstOrDefault(pr => pr.ID == transferDetails.ProductId);
					row.Cells[3].Value = product?.Name;
					row.Cells[4].Value = transferDetails.Quantity;
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
			var transferNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value;

			var transferPrm = context.Transfers.FirstOrDefault(t=>t.TransferNumber == transferNo);
			if (transferPrm != null)
			{
				tb_id.Text = transferPrm.ID.ToString();
				tb_permitnumber.Text = transferPrm.TransferNumber.ToString();
				dtp_transferdate.Value = transferPrm.TransferDate;

				var transferDetails = context.TransferItems.FirstOrDefault(td=>td.TransferId == transferPrm.ID);
				if (transferDetails != null)
				{
					dtp_expirydate.Value = transferDetails.ExpirationDate;
					dtp_proddate.Value = transferDetails.ProductionDate;

					com_fromstore.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
					com_tostore.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
					com_prdname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
					tb_quantities.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
				}
			}

		}

		private void btn_transfer_Click(object sender, EventArgs e)
		{
			if (com_tostore.Text != "" && com_fromstore.Text != "" && com_prdname.Text != ""  && tb_permitnumber.Text != "" && tb_quantities.Text != "")
			{
				string toStoreName = com_tostore.Text;
				string fromStoreName = com_fromstore.Text;
				string prdname = com_prdname.Text;
				DateTime expiryDate = dtp_expirydate.Value;
				DateTime transferDate = dtp_transferdate.Value;
				DateTime prdDate = dtp_proddate.Value;
				string premitNumber = tb_permitnumber.Text;
				int quantity = int.Parse(tb_quantities.Text);

				var toStore = context.Store.FirstOrDefault(s => s.Name == toStoreName);
				var fromStore = context.Store.FirstOrDefault(s => s.Name == fromStoreName);
				var product = context.Products.FirstOrDefault(p => p.Name == prdname);

				var newTransfer = new Transfer()
				{
					ToStoreId = toStore.ID,
					FromStoreId = fromStore.ID,
					TransferNumber = premitNumber,
					TransferDate = transferDate,
				};
				context.Transfers.Add(newTransfer);

				var prd = context.Products.FirstOrDefault(p => p.Store_ID == fromStore.ID && p.ID == product.ID);

				if (prd.Quantity >= quantity)
				{
					prd.Quantity -= quantity;

					var newPrd = new Product()
					{
						Name = product.Name,
						Store_ID = toStore.ID,
						Quantity = quantity,
						Code = product.Code,
						UnitsOfMeasure = product.UnitsOfMeasure,
					};
					context.Products.Add(newPrd);
				}
				else
				{
					MessageBox.Show("Quantity for this prodect is less than your order.. Please check data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					tb_id.Text = com_tostore.Text = com_fromstore.Text = com_prdname.Text = tb_permitnumber.Text = tb_quantities.Text = "";
					dtp_transferdate.Value = dtp_expirydate.Value = dtp_proddate.Value = DateTime.Now;
					dataGridView1.Rows.Clear();
					GetAll();
					return;
				}

				context.SaveChanges();
				var newTransferItem = new TransferItem()
				{
					ProductId = product.ID,
					Quantity = quantity,
					ExpirationDate = expiryDate,
					ProductionDate = prdDate,
					TransferId = newTransfer.ID,
				};
				context.TransferItems.Add(newTransferItem);
				context.SaveChanges();
				tb_id.Text = com_tostore.Text = com_fromstore.Text = com_prdname.Text = tb_permitnumber.Text = tb_quantities.Text = "";
				dtp_transferdate.Value = dtp_expirydate.Value = dtp_proddate.Value = DateTime.Now;
				dataGridView1.Rows.Clear();
				GetAll();
				MessageBox.Show("Transfer Done", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void TransferForm_Load(object sender, EventArgs e)
		{
			var storeList = context.Store.ToList();
			foreach (var store in storeList)
			{
				com_fromstore.Items.Add(store.Name);
				com_tostore.Items.Add(store.Name);
			}

		}

		private void com_fromstore_SelectedIndexChanged(object sender, EventArgs e)
		{
			var fromStoreName = com_fromstore.Text;
			var fromStore = context.Store.FirstOrDefault(s=>s.Name == fromStoreName);

			com_prdname.Items.Clear();
			var prodList = from prd in context.Products
						   where prd.Store_ID == fromStore.ID
						   select prd;
			foreach(var prod in prodList)
			{
				com_prdname.Items.Add(prod.Name);
			}
		}
	}
}
