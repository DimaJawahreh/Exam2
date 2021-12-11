using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.data
{
    public class HRContext:DbContext
    {
        IConfiguration configuration;
        public HRContext(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public DbSet<Employee> employees { set; get; }
        public DbSet<Department> departments { set; get; }
        public DbSet<Country> countries { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Exam"));
            base.OnConfiguring(optionsBuilder);
        }
    }
    
}
