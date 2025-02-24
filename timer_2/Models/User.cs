using System.ComponentModel.DataAnnotations;

namespace timer_2.Models
{
    public class User
    {
        [Key]
        public int fldslno { get; set; }

        public string fldname { get; set; }

        public string fldmail { get; set; }

        public string fldpassword { get; set; }
    }
}
