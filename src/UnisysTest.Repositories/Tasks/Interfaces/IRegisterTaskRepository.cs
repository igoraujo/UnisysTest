using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnisysTest.Repositories.Tasks.Interfaces
{
    public interface IRegisterTaskRepository
    {
        Task<bool> Save(UnisysTest.Borders.Tasks.Entities.Task task);
    }
}