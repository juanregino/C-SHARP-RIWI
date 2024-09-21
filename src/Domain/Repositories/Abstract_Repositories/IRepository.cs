namespace C__RIWI.src.Domain.Repositories
{
  public interface IRepository<TEntity>
  {
      Task<IEnumerable<TEntity>> GetAll();
      Task<TEntity> GetById(int id);
      Task Add(TEntity entity);
      void Update(TEntity entity);
      void Delete(TEntity entity);

      Task SaveChanges();

  }
}
