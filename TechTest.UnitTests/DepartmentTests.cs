namespace TechTest.UnitTests
{
    [TestClass]
    public sealed class DepartmentTests
    {
        private IList<Department> _mockDepartments;

        [TestInitialize]
        public void Initialise()
        {
            var person1 = new Person("Carter", "Amy", Person.PersonTitle.Miss);
            var person2 = new Person("Lewis", "Mark", Person.PersonTitle.Mr);
            var person3 = new Person("Rivera", "Emma", Person.PersonTitle.Mrs);
            var person4 = new Person("Patel", "Raj", Person.PersonTitle.Mr);
            var person5 = new Person("Wong", "Jenny", Person.PersonTitle.Miss);

            var department1 = new Department("Marketing", "3rd Floor", new List<Person>()
            {
                person1,
                person2,
                person3
            });

            var department2 = new Department("Operations", "Ground Floor", new List<Person>()
            {
                person3,
                person4,
                person5
            });

            _mockDepartments = new List<Department>()
            {
                department1,
                department2
            };
        }

        [TestMethod]
        public void Test_GetMembersOfDepartmentLastName_No_Matching_Department_Returns_Empty_List()
        {
            var departmentLastNames = _mockDepartments.GetMembersOfDepartmentLastName("");

            Assert.AreEqual(0, departmentLastNames.Count);
        }

        [TestMethod]
        public void Test_GetMembersOfDepartmentLastName_Empty_Department_Returns_Empty_List()
        {
            var mockDepartment = new Department("Innovation", "1st Floor", []);

            _mockDepartments.Add(mockDepartment);

            var departmentLastNames = _mockDepartments.GetMembersOfDepartmentLastName("Innovation");

            Assert.AreEqual(0, departmentLastNames.Count);
        }

        [TestMethod]
        public void Test_GetMembersOfDepartmentLastName_Marketing_Returns_Expected_Persons()
        {
            var departmentLastNames = _mockDepartments.GetMembersOfDepartmentLastName("Marketing");

            Assert.AreEqual(3, departmentLastNames.Count);
            Assert.IsTrue(departmentLastNames.Contains("Carter"));
            Assert.IsTrue(departmentLastNames.Contains("Lewis"));
            Assert.IsTrue(departmentLastNames.Contains("Rivera"));
        }

        [TestMethod]
        public void Test_GetMembersOfDepartmentLastName_Operations_Returns_Expected_Persons()
        {
            var departmentLastNames = _mockDepartments.GetMembersOfDepartmentLastName("Operations");

            Assert.AreEqual(3, departmentLastNames.Count);
            Assert.IsTrue(departmentLastNames.Contains("Rivera"));
            Assert.IsTrue(departmentLastNames.Contains("Patel"));
            Assert.IsTrue(departmentLastNames.Contains("Wong"));
        }
    }
}
