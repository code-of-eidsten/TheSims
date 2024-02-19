
namespace TheSims
{
    internal class FamilyMode
    {
        public List<Person> PeopleInGame { get; set; } = new List<Person>();

        public void CreatePerson()
        {
            Console.WriteLine("Please give your sim a name:");
            var name = Console.ReadLine();
            Console.WriteLine("Is this sim an adult? y/n");
            var inputIsAdult = Console.ReadLine();
            var adultOrNot = false;
            if (inputIsAdult == "y") { adultOrNot = true; }
            //push people in game as relationship

            var createdPerson = new Person(name, adultOrNot);
            PeopleInGame.Add(createdPerson); //<--- HER er det noe bugg

            SeeAllPeople();
        }

        public void SeeAllPeople() { 
        foreach (var person in PeopleInGame)
            {
                Console.WriteLine(person.Name + " er voksen? " + person.IsAdult + " dat.  Og befinner seg i følgende rom: " + person.CurrentRoom.RoomName);
            }
        }
    }
}
