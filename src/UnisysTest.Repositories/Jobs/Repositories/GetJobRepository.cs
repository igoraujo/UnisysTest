using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnisysTest.Repositories.Jobs.Interfaces;
using UnisysTest.Borders.Jobs.Entities;

namespace UnisysTest.Repositories.Jobs.Repositories
{
    public class GetJobRepository : IGetJobRepository
    {
        public Task<Job> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> Index()
        {
            throw new NotImplementedException();
        }
    }
}