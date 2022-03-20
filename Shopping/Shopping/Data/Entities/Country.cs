﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        //DataAnnotations//
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El Campo {0} es obligatorio.")]
        public string Name { get; set; }
    }
}