using ASP.NETMVCCORE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVCCORE.ViewModels
{
    public class AddEditUserViewModel
    {
        public int ID { get; set; }

        //Must Have Attributes
        [MaxLength(40, ErrorMessage = "Names cannot exceed 40 characters")]
        [Required(ErrorMessage = "Please enter your Name")]
        public string Name { get; set; }

        [Display(Name = "Date Of Birth (Optional)")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Please select your Gender")]
        public Gender? Gender { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter your Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Mobile number")]
        [MaxLength(11, ErrorMessage ="Please enter a valid UK Number")]
        [Required(ErrorMessage = "Please enter your Contact Number")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Please enter your Address")]
        [MaxLength(60, ErrorMessage ="Address cannot exceed 60 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your PostCode")]
        [MaxLength(8, ErrorMessage = "Please enter a valid UK PostCode")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        [Display(Name = "Location of your work")]
        [Required(ErrorMessage = "Please enter your location of work")]
        [MaxLength(40, ErrorMessage = "Name of location cannot exceed 40 characters")]
        public string LocationOfWork { get; set; }

        //Should have Attributes
        [MaxLength(255, ErrorMessage ="Biography cannot exceed 255 characters")]
        public string Biography { get; set; }

        [Display(Name = "Describe your key skills")]
        [MaxLength(30, ErrorMessage = "Skill Names cannot exceed 30 characters")]
        public string KeyWordsForSkill { get; set; }

        //Assigning the enum sports type
        [Required(ErrorMessage = "Please select a Sport Category")]
        public SportsCategory? Category { get; set; }
    }
}
