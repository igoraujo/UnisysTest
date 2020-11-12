using System;
using System.Threading.Tasks;

namespace UnisysTest.Repositories.Jobs.Repositories
{
    public class DeleteJobRepository : IDeleteJobRepository
    {
        public Task<bool> HardDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SoftDelete(int id)
        {
            throw new NotImplementedException();
        }
    }
}