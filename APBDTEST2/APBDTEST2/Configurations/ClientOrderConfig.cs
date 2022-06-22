using APBDTEST2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
namespace APBDTEST2.Configurations
{
    public class ClientOrderConfig : IEntityTypeConfiguration<ClientOrder>
    {
        public void Configure(EntityTypeBuilder<ClientOrder> builder)
        {

          /*  builder.HasOne(e => e.IdClientNav)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.IdClientNav.IdClient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ClientOrder_FK");

            builder.HasOne(e => e.IdEmployeeNav)
                .WithMany(e => e.Orders)
                .HasForeignKey(e => e.IdEmployeeNav.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ClientOrder_FK");*/


            var clientOrders = new List<ClientOrder>();



            clientOrders.Add(new ClientOrder
            {
                IdClientOrder = 1,
                OrderDate = new DateTime(2000, 01, 01),
                CompletionDate = new DateTime(2000, 02, 02),
                Comments = "vlalvalal",
                IdClient = 1,
                IdEmployee = 1

            }) ;


            clientOrders.Add(new ClientOrder
            {
                IdClientOrder = 2,
                OrderDate = new DateTime(2001, 01, 01),
                CompletionDate = new DateTime(2001, 02, 02),
                Comments = "vlalvalal222222",
                IdClient = 2,
                IdEmployee = 2

            });
            builder.HasData(clientOrders);

        }
    }
}