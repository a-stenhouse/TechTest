using System.ComponentModel.DataAnnotations;

namespace TechTest
{
    public class Person
    {
        public Person(string lastName, string firstName, PersonTitle personTitle)
        {
            LastName = lastName;
            FirstName = firstName;
            Title = personTitle;
        }

        public enum PersonTitle
        {
            [Display(Name = "Mr")]
            Mr,
            [Display(Name = "Mrs")]
            Mrs,
            [Display(Name = "Miss")]
            Miss
        }

        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public PersonTitle Title { get; private set; }
    }
}
