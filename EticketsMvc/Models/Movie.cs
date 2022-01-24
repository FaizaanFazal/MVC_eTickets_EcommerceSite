using EticketsMvc.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EticketsMvc.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Discription { get; set; }
        public double Prie { get; set; }

        public string ImageUrl{ get; set; }
        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }

        //relations
        public List<Actor_Movie> Actor_Movies { get; set; }

        //Cinema
       
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public  Cinema Cinema { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}

