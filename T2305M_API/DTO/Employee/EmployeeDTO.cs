using System.ComponentModel.DataAnnotations;
using T2305M_API.Models;

namespace T2305M_API.DTO
{
    public class GetBasicEmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public string EmployeeDepartment { get; set; }
    }

    public class GetDetailEmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public string EmployeeDepartment { get; set; }
        public List<GetBasicProjectDTO> BasicProjectDTOs { get; set; }
    }

    public class EmployeeQueryParameters
    {
        public string? EmployeeName { get; set; }
        public DateTime? EmployeeDOBFromDate { get; set; }
        public DateTime? EmployeeDOBToDate { get; set; }
    }
}
