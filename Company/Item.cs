using Company.Models;

namespace Company
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string RegNumber { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employees { get; set; }
        
    }
}
