using APBDTEST2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
namespace APBDTEST2.Configurations
{
    public class Confectionery_ClientOrderConfig : IEntityTypeConfiguration<Confectionery_ClientOrder>
    {
        public void Configure(EntityTypeBuilder<Confectionery_ClientOrder> builder)
        {

  

             builder.HasKey(e => new
             {
                 e.IdClientOrder,
                 e.IdConfectionery
             }).HasName("Confectionery_ClientOrder_PK");


            var confClientOrders = new List<Confectionery_ClientOrder>();



            confClientOrders.Add(new Confectionery_ClientOrder
            {
                IdClientOrder = 1,
                IdConfectionery = 1,
                Amount = 1,
                Comments = "dsasda"

            });


            confClientOrders.Add(new Confectionery_ClientOrder
            {
                IdClientOrder = 2,
                IdConfectionery = 2,
                Amount = 2,
                Comments = "dsasda222222222"

            });
    
            builder.HasData(confClientOrders);

        }
    }
}