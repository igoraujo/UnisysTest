using System;

namespace UnisysTest.Borders.Tasks.Entities
{
    public class Task
    {
        private int id;
        private string name;
        private int weight;
        private bool completed;
        private DateTime createdAt;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public bool Completed { get => completed; set => completed = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
    }
}