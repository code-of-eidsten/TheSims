using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Room
    {
        public string RoomName { get; set; }
        public List <Item>Items = new List <Item> ();
        public List <Person> PeopleInRoom = new List <Person> ();
        public Room(string roomName) { 
            RoomName = roomName;
        }

        public void ShowItemsToAdd()
        {

        }
        private void PopulateItemsList()
        {

        }

        private void PopulatePeopleInRoomList()
        {

        }
    }
}
