using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EticketsMvc.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Profile Picture URL")]
        [Required(ErrorMessage ="Profile picture url is required")]
        public string  ProfilePictureUrl { get; set; }

        [Required(ErrorMessage = "Full Name is required")]
        [Display(Name = "Full Name")]
        [StringLength(50,MinimumLength=3,ErrorMessage ="Name must be between 3 to 5 characters")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //relationships
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
