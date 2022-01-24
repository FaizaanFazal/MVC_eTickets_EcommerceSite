using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EticketsMvc.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string  Name { get; set; }
        [Display(Name = "Description")]
        public string Discription { get; set; }
        //relationships
        public List<Movie> Movies { get; set; }
    }
}
