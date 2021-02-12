using System.ComponentModel.DataAnnotations;

namespace AttributeLabs
{
    [Custom("EmployeeHr")]
    [Custom("EmployeeSales")]
    public class Employee
    {
        [Required]
        public int Name { get; set; }

        [Custom("Display")]
        private void Display()
        {

        }
    }
}
