using System;
using System.Threading.Tasks;
using UnisysTest.Borders.Jobs.Entities;

namespace UnisysTest.Repositories.Jobs.Repositories
{
    public class RegisterJobRepository : IRegisterJobRepository
    {
        public Task<bool> Save(Job job)
        {
            throw new NotImplementedException();
        }
    }
}