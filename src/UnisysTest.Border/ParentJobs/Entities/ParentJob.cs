namespace UnisysTest.Borders.ParentJobs.Entities
{
    public class ParentJob
    {
        private int id;
        private string name;
        private bool active;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Active { get => active; set => active = value; }
    }
}