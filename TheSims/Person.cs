using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Person
    {
        public string Name { get; set; }
        public bool IsAdult { get; set; }
        public List<Person> RelationshipsStatuses { get; set;} //denne må kanskje ha en sånn "kobleklasse" med to lister, en over alle mennesker og en med relationship mellom de forskjellige menneskene?
        public Room CurrentRoom { get; set; }

        public Person(string name, bool isAdult)
        {   
            Name = name;
            IsAdult = isAdult;  
            //RelationshipsStatuses = peopleInGame; 
            CurrentRoom = new Room("Kitchen");
        }
    }
}
