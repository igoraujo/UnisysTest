using System.Threading.Tasks;
using UnisysTest.Borders.Jobs.Entities;

namespace UnisysTest.Repositories.Jobs.Repositories
{
    public interface IUpdateJobRepository
    {
        Task<bool> Update(Job job);        
    }
}