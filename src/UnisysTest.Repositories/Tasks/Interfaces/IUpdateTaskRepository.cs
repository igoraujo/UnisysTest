using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnisysTest.Repositories.Tasks.Interfaces
{
    public interface IUpdateTaskRepository
    {
        Task<bool> Update(UnisysTest.Borders.Tasks.Entities.Task task);
    }
}