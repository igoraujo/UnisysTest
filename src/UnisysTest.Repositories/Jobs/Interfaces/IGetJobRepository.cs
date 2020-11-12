using System.Collections.Generic;
using System.Threading.Tasks;
using UnisysTest.Borders.Jobs.Entities;

namespace UnisysTest.Repositories.Jobs.Interfaces
{
    public interface IGetJobRepository
    {
        Task<IEnumerable<Job>> Index();
        
        Task<Job> GetById(int id);
    }
}