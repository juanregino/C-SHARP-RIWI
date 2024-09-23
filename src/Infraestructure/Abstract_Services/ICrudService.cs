

namespace C__RIWI.src.Infraestructure.Abstract_Services
{
    public interface ICrudService <TResponse ,TRequest>
    {
        Task<IEnumerable<TResponse>> GetAll();
        Task<TResponse> GetById(int id);
        Task<TResponse> Create(TRequest request);
        Task<TResponse> Update(int id, TRequest request);
        Task Delete(int id);
    }
}