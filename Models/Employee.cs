using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EmployeeCRUD_MVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        [Display(Name ="Employee Name")]
        [Column(TypeName ="nvarchar(50)")]
        public string EmployeeName { get; set; }
        [Required]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Display(Name = "Designation")]
        [Required]
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}
