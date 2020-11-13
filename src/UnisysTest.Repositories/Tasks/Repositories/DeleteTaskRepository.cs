using System;
using System.Threading.Tasks;
using UnisysTest.Repositories.Tasks.Interfaces;

namespace UnisysTest.Repositories.Tasks.Repositories
{
    public class DeleteTaskRepository : IDeleteTaskRepository
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