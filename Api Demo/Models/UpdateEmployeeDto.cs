namespace Api_Demo.Models
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
