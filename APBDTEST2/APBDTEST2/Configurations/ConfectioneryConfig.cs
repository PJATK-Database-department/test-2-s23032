using APBDTEST2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
namespace APBDTEST2.Configurations
{
    public class ConfectioneryConfig : IEntityTypeConfiguration<Confectionery>
    {
        public void Configure(EntityTypeBuilder<Confectionery> builder)
        {
            var confs = new List<Confectionery>();

            confs.Add(new Confectionery
            {
                IdConfectionery = 1,
                Name = "Whatever1" ,
                PricePerOne = 5,
            });

            confs.Add(new Confectionery
            {
                IdConfectionery = 2,
                Name = "Whatever2",
                PricePerOne = 10,
            });
            builder.HasData(confs);

        }
    }
}