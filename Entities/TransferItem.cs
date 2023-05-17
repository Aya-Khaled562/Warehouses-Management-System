using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class TransferItem
	{
		public int ID { get; set; }
		public int Quantity { get; set; }

		[Column(TypeName = "Date")]
		public DateTime ProductionDate { get; set; }

		[Column(TypeName = "Date")]
		public DateTime ExpirationDate { get; set; }

		public int TransferId { get; set; }
		public Transfer Transfer { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }
	}
}
