

using AutoMapper;


namespace C__RIWI.src.Infraestructure.Mappers
{
    public abstract class CommonMapper<TRequest, TEntity, TResponse> : Profile
    {
        public CommonMapper()
        {
            // Aquí se delega la responsabilidad del mapeo a las clases que heredan
            CreateMap<TRequest, TEntity>();
            CreateMap<TEntity, TResponse>();
        }
    }
}