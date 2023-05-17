using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Store
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		[ForeignKey("ResponsiblePerson")]
		public int EmployeeId { get; set; }
		public virtual Employee ResponsiblePerson { get; set; }
		public ICollection<Transfer> Transfers { get; set; }
		public virtual ICollection<Product> Products { get; set; }
		public virtual ICollection<ImportPermit> ImportPermit { get; set; }
		public virtual ICollection<ExchangePermit> ExchangePermits { get; set; }

	}
}
