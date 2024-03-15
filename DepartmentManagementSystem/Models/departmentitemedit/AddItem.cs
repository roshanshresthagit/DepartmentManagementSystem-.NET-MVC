using System.Diagnostics.CodeAnalysis;

namespace DepartmentManagementSystem.Models.departmentitemedit
{
    public class AddItem
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float price { get; set; }
    }
}
