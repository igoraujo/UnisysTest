using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnisysTest.Repositories.Tasks.Interfaces;

namespace UnisysTest.Repositories.Tasks.Repositories
{
    public class GetTaskRepository : IGetTaskRepository
    {
        public Task<UnisysTest.Borders.Tasks.Entities.Task> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UnisysTest.Borders.Tasks.Entities.Task>> Index()
        {
            throw new NotImplementedException();
        }
    }
}