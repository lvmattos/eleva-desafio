using ElevaEducacao.PortalEscola.Domain.Entities.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElevaEducacao.PortalEscola.Domain.Repositories.Base
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T entity, string query);
        Task<IEnumerable<T>> FindAllAsync(string query);
        Task<IEnumerable<Z>> QueryAllAsync<Z>(string query);
    }
}
