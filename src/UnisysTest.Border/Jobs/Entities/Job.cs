namespace UnisysTest.Borders.Jobs.Entities
{
    public class Job
    {
        private int id;
        private string name;
        private bool active;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public bool Active { get => active; set => active = value; }
    }
}