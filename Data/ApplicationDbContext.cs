using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Printercounter2.Models;

namespace Printercounter2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Counter> PrinterCounter { get; set; }
        public DbSet<RepairReportList> RepairReportList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<PrinterCounter>()
             //   .HasOne<Printers>()
              //  .WithMany()
               // .HasForeignKey(p => p.ID_Printer);
        }
    }
}
