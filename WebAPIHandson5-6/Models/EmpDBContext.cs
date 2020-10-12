using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIHandson5_6.Models
{
    public class EmpDBContext: DbContext
    {
        public DbSet<Employee> Emp { get; set; }
        public EmpDBContext(DbContextOptions<EmpDBContext> op) : base(op)
        {

        }
    }
}
