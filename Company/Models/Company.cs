namespace Company.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string PhoneNember { get; set; }
        public string Address { get; set; }
        public decimal Funds { get; set; }

        public Departments Departments { get; set; }

        public Employee Employees { get; set; }
    }
}
