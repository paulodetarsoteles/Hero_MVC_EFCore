﻿using Hero_MVC_EFCore.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hero_MVC_EFCore.Web.ViewModels
{
    public class PowerViewModel
    {
        [Key]
        [Display(Name = "Código do poder")]
        public int PowerId { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Código do herói")]
        public int HeroId { get; set; }

        [NotMapped]
        [Display(Name = "Heróis")]
        public Hero Hero { get; set; }
    }
}
