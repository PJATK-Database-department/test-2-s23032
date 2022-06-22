using APBDTEST2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace APBDTEST2.Configurations
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure (EntityTypeBuilder<Client> builder)
        {
            var clients = new List<Client>();

            clients.Add(new Client
            {
                IdClient = 1,
                FirstName = "John",
                LastName = "Maw"
            });

            clients.Add(new Client
            {
                IdClient = 2,
                FirstName = "Sara",
                LastName = "Curry"
            }); 
            builder.HasData(clients);

        }
    }
}
