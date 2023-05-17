using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Context:DbContext
	{
		public Context() : base("Data Source=.;Initial Catalog=EFProject;Integrated Security=True; MultipleActiveResultSets=True;")
		{}
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Store> Store { get; set; }
		public DbSet<ExchangePermitDetail> ExchangePermitDetail { get; set;}
		public DbSet<ExchangePermit> ExchangePermits { get; set; }
		public DbSet<ImportPermit> ImportPermits { get; set; }
		public DbSet<ImportPermitDetail> ImportPermitDetails { get; set; }
		public DbSet<Transfer> Transfers { get; set; } 
		public DbSet<TransferItem> TransferItems { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ImportPermitDetail>()
			.HasRequired(x => x.ImportPermit)
			.WithMany(x => x.ImportPermitDetails)
			.HasForeignKey(x => x.ImportPermitId)
			.WillCascadeOnDelete(false);

			modelBuilder.Entity<ExchangePermitDetail>()
		   .HasRequired(x => x.ExchangePermit)
		   .WithMany(x => x.ExchangePermitDetail)
		   .HasForeignKey(x => x.ExchangePermitId)
		   .WillCascadeOnDelete(false);

			modelBuilder.Entity<TransferItem>()
		   .HasRequired(x => x.Transfer)
		   .WithMany(x => x.TransferItem)
		   .HasForeignKey(x => x.TransferId)
		   .WillCascadeOnDelete(false);

			modelBuilder.Entity<Transfer>()
			.HasRequired(x => x.ToStore)
			.WithMany()
			.HasForeignKey(x => x.ToStoreId)
			.WillCascadeOnDelete(false);
			base.OnModelCreating(modelBuilder);

			

		}


	}
}
