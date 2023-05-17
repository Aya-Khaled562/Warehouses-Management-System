using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public decimal Quantity { get; set; }
		public string UnitsOfMeasure { get; set; }
		[ForeignKey("Store")]
		public int Store_ID { get; set; }
		public virtual Store Store { get; set; }
		public virtual ICollection<ImportPermitDetail> ImportPermitDetail { get; set; }
		public virtual ICollection<ExchangePermitDetail> ExchangePermitDetail { get; set;}
		public virtual ICollection<TransferItem> TransferItem { get; set; }

	}
}
