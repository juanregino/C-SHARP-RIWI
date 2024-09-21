

using Microsoft.EntityFrameworkCore;

namespace C__RIWI.src.Domain.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly AppDBContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();  // Obtiene el DbSet de la entidad genérica
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync(); // Obtiene todas las entidades
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id);  // Busca la entidad por ID
        }

        public async Task Add(TEntity entity)
        {
            await _dbSet.AddAsync(entity);  // Agrega una nueva entidad
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);  // Marca la entidad como modificada
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);  // Elimina la entidad
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();  // Guarda los cambios en la base de datos
        }
    }
}