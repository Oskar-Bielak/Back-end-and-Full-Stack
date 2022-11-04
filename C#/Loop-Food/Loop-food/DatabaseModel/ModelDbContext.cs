using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loop_food.DatabaseModel
{
    public class ModelDbContext : DbContext
    {
        private string _connectionString=
            "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Loop_food;Integrated Security=True;";
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
