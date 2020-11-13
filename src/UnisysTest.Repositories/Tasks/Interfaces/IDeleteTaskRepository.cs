using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnisysTest.Repositories.Tasks.Interfaces
{
    public interface IDeleteTaskRepository
    {
        Task<bool> SoftDelete(int id);

        Task<bool> HardDelete(int id);  
    }
}