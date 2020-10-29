using Backend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Context
{
    public class GenericContext : DbContext
    {
        public GenericContext(): base("Data Source=qa0087;Initial Catalog=Renewals;User Id=RenewalsUser;Password=RenewalsP@$$w0rd;")
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
    }
}
