using Application.Common;
using Domain.Common;

namespace Application
{
    public interface IProductRepository<Product> : IBaseRepository<Product> where Product : BaseEntity
    {
        // İleride ProductViewModel nesnesindeki IdDealer için bir Dealer Description değeri ataması yapacak olan metot.
        List<Product> GetProducts();
    }
}