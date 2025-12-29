using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstcodeDemo
{
    [Table("StudentsTable")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]// NO identity which means the id will not automatically oncremented
        [Required(ErrorMessage ="Please Enter Student Id :")] //data must be inserted or else it will show error
        [Column("Sid",TypeName ="int")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Please Enter Student Name :")]
        [RegularExpression("^[a-zA-Z]+$",ErrorMessage ="Only Alphabets Allowed")]
        [Column("SName",TypeName="varchar")]
        [MaxLength(20)]//the character lenghth
        public string StudentName { get; set; }
        public DateTime DOB { get; set; }
        [Required(ErrorMessage ="Please Ennter The Class")]
        [Range(1,12,ErrorMessage ="Please Enter inside the range")]

        public int Class {  get; set; }
        [Column("SEmail",TypeName ="varchar")]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage ="Please Enter the Email Id")]

        public string Email {  get; set; }

    }
}
