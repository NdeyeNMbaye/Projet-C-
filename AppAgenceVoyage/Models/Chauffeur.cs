using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppAgenceVoyage.Models
{
    public class Chauffeur
    {
        [Key]
        public int Id { get; set; }
        [Required , MaxLength(80)]
        public string Nom { get; set; }
        [Required, MaxLength(80)]
        public string Prenom { get; set; }
    }
}