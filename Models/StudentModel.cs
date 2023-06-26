using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApp.Models
{
    public class StudentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDNo { get; set; }
        public string FName { get; set; } = null!;
        public string SName { get; set; } = null!;
        public string TName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string SchoolName { get; set; } = null!;

    }
}
