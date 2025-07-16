namespace TechTest
{
    public static class DepartmentExtensionMethods
    {
        public static IList<string> GetMembersOfDepartmentLastName(this IEnumerable<Department> departments, string departmentName)
        {
            return departments.SingleOrDefault(d => d.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase))?.GetMembersLastNames() ?? [];
        }
    }
}
