
using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore.Domain;

namespace myfinance_web_netcore.Infraestructure
{   
    public class MyFinanceDbContext : DbContext
    {
        public DbSet<PlanoConta> PlanoConta {get;set;}
        public DbSet<Transacao> Transacao {get;set;}

         //aplica as configurações para o metodo saber o que ele vai fazer na aplicação
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\sqlexpress;Database=myfinanceweb;Trusted_Connection=True;TrustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}