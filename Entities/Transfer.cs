using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Transfer
	{
		public int ID { get; set; }

		public string TransferNumber { get; set; }

		[Column(TypeName = "Date")]
		public DateTime TransferDate { get; set; }

		public int FromStoreId { get; set; }
		public Store FromStore { get; set; }

		public int ToStoreId { get; set; }
		public Store ToStore { get; set; }

		public ICollection<TransferItem> TransferItem { get; set; }
	}
}
