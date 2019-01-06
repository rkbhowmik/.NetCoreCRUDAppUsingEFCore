using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreCRUPApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        [Required(ErrorMessage = "This field is required")]
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [Display(Name = "Employee Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Office Location")]
        public string OfficeLocation { get; set; }

    }
}
