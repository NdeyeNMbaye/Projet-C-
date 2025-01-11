using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppAgenceVoyage.Models
{
    public class Admin:Utilisateur
    {
        [Display(Name = "Matricule"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string MatriculeAdmin { get; set; }
    }
}