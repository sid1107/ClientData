using ClientRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientData.Data
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Repository> ClientData { get; set; }

        public ClientDbContext(DbContextOptions<ClientDbContext> options)
           : base(options)
        {

        }
    }
}
