using myfinance_web_netcore.Domain;
using myfinance_web_netcore.Infraestructure;

namespace myfinance_web_netcore.Services
{
    public class PlanoContaService : IPlanoContaService
    {   
        private readonly MyFinanceDbContext _myfinanceDbContext;
        public PlanoContaService(MyFinanceDbContext myFinanceDbContext)
        {
            _myfinanceDbContext = myFinanceDbContext;
        }
        
        public IEnumerable<PlanoConta> ListarPlanoContas()
        {
            return _myfinanceDbContext.PlanoConta.ToList();
        }
    }
}