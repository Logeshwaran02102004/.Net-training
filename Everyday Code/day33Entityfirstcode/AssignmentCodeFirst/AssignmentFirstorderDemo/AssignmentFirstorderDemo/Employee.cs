using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFirstorderDemo
{
    [Table("EmployeeDeatails")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="The EmpId Should must start with E and following 3 digit..")]
        [Column(TypeName="varchar")]
        [MaxLength(20)]
        public string EmpId { get; set; }

        [Required(ErrorMessage = "Please Enter the EmployeeName..")]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]


        public string EmpName { get; set; }
        [Required(ErrorMessage = "Please Enter the DepartmentName...")]
        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        public string Department {  get; set; }
        [Required(ErrorMessage = "Please Enter the Salary between 5000-50000..")]
        [Column(TypeName = "int")]
        public int Salary { get; set; }
        [Required(ErrorMessage = "Please Enter the Year..")]
        [Column(TypeName = "int")]
        public int YearOfJoining { get; set; }

    }
}
