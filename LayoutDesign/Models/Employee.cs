using System.ComponentModel.DataAnnotations;

namespace LayoutDesign.Models
{
    public class Employee
    {

        [Key]
        public int EmpId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

    }
}
