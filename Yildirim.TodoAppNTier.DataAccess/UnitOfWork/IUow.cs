using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yildirim.TodoAppNTier.DataAccess.İnterfaces;
using Yildirim.TodoAppNTier.Entities.Domains;

namespace Yildirim.TodoAppNTier.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChanges();
    }
}
