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
	public partial class ImportPremitForm : Form
	{
		Context context = new Context();
		public ImportPremitForm()
		{
			InitializeComponent();
		}


		private void GetAll()
		{
			var premits = from prm in context.ImportPermits
						  where prm != null
						  select prm;


			foreach (var premit in premits)
			{
				var rowIndex = dataGridView1.Rows.Add();
				var row = dataGridView1.Rows[rowIndex];

				row.Cells[0].Value = premit.PermitNumber;

				var str = context.Store.FirstOrDefault(s => s.ID == premit.StoreId);
				row.Cells[1].Value = str?.Name;

				var sup = context.Suppliers.FirstOrDefault(s => s.ID == premit.SupplierId);
				row.Cells[2].Value = sup?.Name;

				var importDetails = context.ImportPermitDetails.FirstOrDefault(p => p.ImportPermitId == premit.ID);

				if (importDetails != null)
				{
					var product = context.Products.FirstOrDefault(pr => pr.ID == importDetails.ProductId);
					row.Cells[3].Value = product?.Name;
					row.Cells[4].Value = importDetails.Quantity;
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
			var importNumber = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
		
			var importPermit = context.ImportPermits.FirstOrDefault(p => p.PermitNumber == importNumber);
			tb_id.Text = importPermit.ID.ToString();
			tb_permitnumber.Text = importPermit.PermitNumber.ToString();
			dtp_expirydate.Value = importPermit.ExpiryDate;
			dtp_primitdate.Value = importPermit.PermitDate;
			dtp_proddate.Value = importPermit.ProductionDate;

			var importDetails = context.ImportPermitDetails.FirstOrDefault(d=>d.ImportPermitId == importPermit.ID);
			tb_quantities.Text = importDetails.Quantity.ToString();

			com_storename.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			com_storesupplier.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			com_prdname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			if(com_storename.Text != ""&& com_prdname.Text != "" && com_storesupplier.Text != "" && tb_permitnumber.Text != "" && tb_quantities.Text != "")
			{
				string storeName = com_storename.Text;
				string prdname = com_prdname.Text;
				string supplierName = com_storesupplier.Text;
				DateTime expiryDate = dtp_expirydate.Value;
				DateTime premitDate = dtp_primitdate.Value;
				DateTime prdDate = dtp_proddate.Value;
				string premitNumber = tb_permitnumber.Text;
				decimal quantity = decimal.Parse(tb_quantities.Text);

				var store = context.Store.FirstOrDefault(s => s.Name == storeName);
				var product = context.Products.FirstOrDefault(p => p.Name == prdname);
				var supplier = context.Suppliers.FirstOrDefault(sup => sup.Name == supplierName);

				var newImportPremit = new ImportPermit()
				{
					StoreId = store.ID,
					PermitNumber = premitNumber,
					PermitDate = premitDate,
					ExpiryDate = expiryDate,
					ProductionDate = prdDate,
					SupplierId = supplier.ID
				};
				context.ImportPermits.Add(newImportPremit);
				
				var prd = context.Products.FirstOrDefault(p => p.Store_ID == store.ID && p.ID==product.ID);
				if (prd != null)
				{
					prd.Quantity += quantity;
				}
				else
				{
					var newPrd = new Product()
					{
						Name = product.Name,
						Store_ID = store.ID,
						Quantity = quantity,
						Code = product.Code,
						UnitsOfMeasure = product.UnitsOfMeasure,
					};
					context.Products.Add(newPrd);
				}
				context.SaveChanges();
				var newImportDetails = new ImportPermitDetail()
				{
					ProductId = product.ID,
					Quantity = quantity,
					ImportPermitId = newImportPremit.ID,
				};
				context.ImportPermitDetails.Add(newImportDetails);
				context.SaveChanges();
				tb_id.Text = com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
				dtp_primitdate.Value = dtp_expirydate.Value = dtp_proddate.Value = DateTime.Now;
				dataGridView1.Rows.Clear();
				GetAll();
				MessageBox.Show("Import Premit Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void ImportPremitForm_Load(object sender, EventArgs e)
		{
			var storeList = context.Store.ToList();
			foreach ( var store in storeList )
			{
				com_storename.Items.Add( store.Name );
			}

			var prodList = context.Products.ToList();
			foreach( var prod in prodList)
			{
				com_prdname.Items.Add( prod.Name );
			}

			var supList = context.Suppliers.ToList();
			foreach(var sup in supList)
			{
				com_storesupplier.Items.Add( sup.Name );
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
				DateTime expiryDate = dtp_primitdate.Value;
				DateTime premitDate = dtp_primitdate.Value;
				DateTime prdDate = dtp_proddate.Value;
				string premitNumber = tb_permitnumber.Text;
				decimal quantity = decimal.Parse(tb_quantities.Text);

				var store = context.Store.FirstOrDefault(s => s.Name == storeName);
				var product = context.Products.FirstOrDefault(p => p.Name == prdname);
				var supplier = context.Suppliers.FirstOrDefault(sup => sup.Name == supplierName);

				var importPrem = context.ImportPermits.FirstOrDefault(p => p.ID == id);

				importPrem.StoreId = store.ID;
				importPrem.PermitNumber = premitNumber;
				importPrem.PermitDate = premitDate;
				importPrem.ExpiryDate = expiryDate;
				importPrem.ProductionDate = prdDate;
				importPrem.SupplierId = supplier.ID;

				var prd = context.Products.FirstOrDefault(p => p.ID == product.ID);
				if(prd != null)
				{
					prd.Quantity += quantity;
				}

				var importDetails = context.ImportPermitDetails.FirstOrDefault(d => d.ImportPermitId == id);
				importDetails.ProductId = product.ID;
				importDetails.Quantity = quantity;

				context.SaveChanges();
				tb_id.Text = com_storename.Text = com_prdname.Text = com_storesupplier.Text = tb_permitnumber.Text = tb_quantities.Text = "";
				dtp_primitdate.Value = dtp_primitdate.Value = dtp_proddate.Value = DateTime.Now;
				dataGridView1.Rows.Clear();
				GetAll();
				MessageBox.Show("Import Premit Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please Enter Valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}
