using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CouStem.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [StringLength(255)]
        [Display(Name = "Segundo Nombre")]
        public string SecondName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public DateTime? Birthdate { get; set; }

    }
}