using System.Collections.Generic;
using UnisysTest.Borders.ParentJobs.DTO;
using UnisysTest.Borders.Tasks.DTO;

namespace UnisysTest.Borders.Jobs.DTO
{
    public class JobDTO
    {
        private int id;
        private string name;
        private bool active;
        private ParentJobDTO parentJob;
        private IEnumerable<TaskDTO> tasks;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Active { get => active; set => active = value; }
        public ParentJobDTO ParentJob { get => parentJob; set => parentJob = value; }
        public IEnumerable<TaskDTO> Tasks { get => tasks; set => tasks = value; }
    }
}