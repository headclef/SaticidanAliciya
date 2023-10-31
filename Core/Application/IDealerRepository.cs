using Application.Common;
using Domain.Common;

namespace Application
{
    public interface IDealerRepository<Dealer> : IBaseRepository<Dealer> where Dealer : BaseEntity
    {
        // İleride DealerViewModel nesnesindeki IdDealer için bir Rate Value değeri ataması yapacak olan metot.
        List<Dealer> GetDealers();
    }
}