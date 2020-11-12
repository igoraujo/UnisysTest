using System.Collections.Generic;
using System.Threading.Tasks;
using Moviy.Borders.ParentJobs.Entities;

namespace Moviy.Borders.Jobs.DTO
{
    public class JobDTO
    {
        private int id;
        private string name;
        private bool active;
        private ParentJob parentJob;
        private IEnumerable<Task> tasks;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Active { get => active; set => active = value; }
        public ParentJob ParentJob { get => parentJob; set => parentJob = value; }
        public IEnumerable<Task> Tasks { get => tasks; set => tasks = value; }
    }
}