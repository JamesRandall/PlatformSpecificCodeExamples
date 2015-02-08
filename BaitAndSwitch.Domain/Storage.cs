using System.IO;
using BaitAndSwitch.Domain.Model;
using SQLite;

namespace BaitAndSwitch.Domain
{
    public class Storage
    {
        public void Initialize(string path)
        {
            string databaseFilename = Path.Combine(path, "mydatabase.sql");
            using (SQLiteConnection connection = new SQLiteConnection(databaseFilename))
            {
                connection.CreateTable<Person>();
            }
        }
    }
}
