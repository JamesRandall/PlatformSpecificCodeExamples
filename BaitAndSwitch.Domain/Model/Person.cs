using SQLite;

namespace BaitAndSwitch.Domain.Model
{
    public class Person
    {
        [PrimaryKey]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
