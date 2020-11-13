using System;
using System.Threading.Tasks;
using UnisysTest.Repositories.Tasks.Interfaces;

namespace UnisysTest.Repositories.Tasks.Repositories
{
    public class UpdateTaskRepository : IUpdateTaskRepository
    {
        public Task<bool> Update(UnisysTest.Borders.Tasks.Entities.Task task)
        {
            throw new NotImplementedException();
        }
    }
}