using System.ComponentModel.DataAnnotations;

namespace T2305M_API.Models
{
    public class ProjectEmployee
    {
        [Required]
        public int EmployeeId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Tasks are required.")]
        public string Tasks { get; set; }

        public virtual Employee? Employees{ get; set; }
        public virtual Project? Projects { get; set; }
    }
}
