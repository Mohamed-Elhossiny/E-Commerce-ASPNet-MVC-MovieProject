﻿using MovieProject.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace MovieProject.Models
{
    public class Cinema :IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Cinema Description")]
        public string Description { get; set; }
        public virtual List<Movie>? Movies { get; set; }
    }
}
