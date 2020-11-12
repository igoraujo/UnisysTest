using System.Threading.Tasks;

namespace UnisysTest.Repositories.Jobs.Repositories
{
    public interface IDeleteJobRepository
    {
        Task<bool> SoftDelete(int id);

        Task<bool> HardDelete(int id);        
    }
}