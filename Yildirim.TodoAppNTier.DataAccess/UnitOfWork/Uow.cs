using System.Threading.Tasks;
using Yildirim.TodoAppNTier.DataAccess.Contexts;
using Yildirim.TodoAppNTier.DataAccess.İnterfaces;
using Yildirim.TodoAppNTier.DataAccess.Repositories;
using Yildirim.TodoAppNTier.Entities.Domains;

namespace Yildirim.TodoAppNTier.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly TodoContext _context;

        public Uow(TodoContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}
