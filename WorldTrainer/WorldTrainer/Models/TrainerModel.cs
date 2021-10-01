using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class TrainerModel
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Please enter Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string password { get; set; }
        [Required(ErrorMessage = "Please Enter name")]
        public string name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Please enter Email ")]
        public string email { get; set; }

        public int age { get; set; }

        [Required(ErrorMessage = "Please Enter Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Please enter Contact number")]
        [Phone]
        public string contact { get; set; }

        [Required(ErrorMessage = "Please enter Experience")]
        public int experience { get; set; }

        [Required(ErrorMessage = "Please enter Qualification")]
        public string qualification { get; set; }

        public List<SkillModel> skill { get; set; }
    }
}
