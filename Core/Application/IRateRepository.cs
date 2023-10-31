using Application.Common;
using Domain.Common;

namespace Application
{
    public interface IRateRepository<Rate> : IBaseRepository<Rate> where Rate : BaseEntity
    {

    }
}