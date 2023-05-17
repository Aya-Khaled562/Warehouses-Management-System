using Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class ExchangePermit
	{
		public int ID { get; set; }
		
		public string PermitNumber { get; set; }

		[Column(TypeName = "Date")]
		public DateTime PermitDate { get; set; }

		public int StoreId { get; set; }
		public virtual Store Store { get; set; }

		public int SupplierId { get; set; }
		public virtual Supplier Supplier { get; set; }
		public virtual ICollection<ExchangePermitDetail> ExchangePermitDetail { get; set; }


	}
}
