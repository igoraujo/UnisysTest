using System;
using System.Threading.Tasks;
using UnisysTest.Repositories.Tasks.Interfaces;

namespace UnisysTest.Repositories.Tasks.Repositories
{
    public class RegisterTaskRepository : IRegisterTaskRepository
    {
        public Task<bool> Save(UnisysTest.Borders.Tasks.Entities.Task task)
        {
            throw new NotImplementedException();
        }
    }
}