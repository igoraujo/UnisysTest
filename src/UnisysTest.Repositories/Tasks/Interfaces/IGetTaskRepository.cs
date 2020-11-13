using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnisysTest.Repositories.Tasks.Interfaces
{
    public interface IGetTaskRepository
    {
        Task<IEnumerable<UnisysTest.Borders.Tasks.Entities.Task>> Index();
        
        Task<UnisysTest.Borders.Tasks.Entities.Task> GetById(int id);
    }
}