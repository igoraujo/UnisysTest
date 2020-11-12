using System.Threading.Tasks;
using UnisysTest.Borders.Jobs.Entities;

namespace UnisysTest.Repositories.Jobs.Repositories
{
    public interface IRegisterJobRepository
    {
        Task<bool> Save(Job job);
    }
}