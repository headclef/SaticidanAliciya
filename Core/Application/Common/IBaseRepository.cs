using Domain.Common;

namespace Application.Common
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Add();
        void Update();
        void Delete();
        List<T> GetAll();
        T GetById();
    }
}