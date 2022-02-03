using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Group
    {
        public Group()
        {
        }
        // Entity needs empty constructors to make tables...

        public Group(string name)
        {
            Name = name;
        }

        [Key]
        public string Name { get; set; } //[Key] property ensure the Name <<< is the name of the Group^^^
        public ICollection<Connection> Connections { get; set; } = new List<Connection>();
    }
}