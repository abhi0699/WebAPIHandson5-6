using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIHandson5_6.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(30)")]
        public string EmployeeName { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        public decimal Salary { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        public bool IsPermanent { get; set; }
    }
}
