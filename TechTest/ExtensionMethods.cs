namespace TechTest
{
    public static class ExtensionMethods
    {
        public static IList<string> GetMembersOfDepartmentLastName(this IList<Department> departments, string departmentName)
        {
            return departments.SingleOrDefault(d => d.Name == departmentName)?.GetMembersLastNames() ?? [];
        }
    }
}
