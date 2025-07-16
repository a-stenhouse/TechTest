namespace TechTest
{
    public class Department
    {
        public Department(string name, string location, IList<Person> members)
        {
            Name = name;
            Location = location;
            Members = members;
        }

        public string Name { get; private set; }
        public string Location { get; private set; }
        public IList<Person> Members { get; private set; }

        public IList<string> GetMembersLastNames()
        {
            return [.. Members.Select(m => m.LastName)];
        }
    }
}
