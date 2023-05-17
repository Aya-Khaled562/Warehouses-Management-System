using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class ImportPermit
	{
		public int ID { get; set; }
		public string PermitNumber { get; set; }

		[Column(TypeName = "Date")]
		public DateTime PermitDate { get; set; }

		[Column(TypeName = "Date")]
		public DateTime ProductionDate { get; set; }

		[Column(TypeName = "Date")]
		public DateTime ExpiryDate { get; set; }
		public int StoreId { get; set; }
		public virtual Store Store { get; set; }

		public int SupplierId { get; set; }
		public virtual Supplier Supplier { get; set; }

		public virtual ICollection<ImportPermitDetail> ImportPermitDetails { get; set; }

	}
}
