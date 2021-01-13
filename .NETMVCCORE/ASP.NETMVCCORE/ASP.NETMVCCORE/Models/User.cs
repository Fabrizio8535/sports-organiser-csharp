using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVCCORE.Models
{
    public class User
    {
        public int ID { get; set; }

        //Must Have Attributes
        //[MaxLength(50)]
       // [Required(ErrorMessage ="Please enter your Name")]
        public string Name { get; set; }

        //[Display(Name= "Date Of Birth")]
       // [Required(ErrorMessage = "Please enter your Date of Birth")]
        public DateTime? DOB { get; set; }

       // [Required(ErrorMessage = "Please select your Gender")]
        public Gender? Gender { get; set; }

        //[Display(Name = "Email Address")]
       // [Required(ErrorMessage = "Please enter your Email")]
       // [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Display(Name = "Mobile number")]
        ///[DataType(DataType.PhoneNumber)]
       // [Required(ErrorMessage = "Please enter your Contact Number")]
        public string MobileNo { get; set; }

       // [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }

        public string PostCode { get; set; }

        // [Display(Name = "Location of your work")]
        //  [Required(ErrorMessage = "Please enter your location of work")]
        public string LocationOfWork { get; set; }

        //Should have Attributes
        public string Biography { get; set; }

       // [Display(Name = "Range of words describing your skills")]
        public string KeyWordsForSkill { get; set; }

        //Assigning the enum sports type
       // [Required(ErrorMessage ="The Sports category must be selected!")]
        public SportsCategory? Category { get; set; }
    }
}
