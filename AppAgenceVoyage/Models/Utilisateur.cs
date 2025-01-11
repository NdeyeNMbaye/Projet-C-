using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AppAgenceVoyage.Models
{
    public class Utilisateur
    {
        [Key]
        public int IdUtilisateur { get; set; }
        [Display(Name = "Nom"), Required(ErrorMessage = "*"),MaxLength(80)]
        public string PrénomUtilisateur { get; set; }
        [Display(Name = "Prénom"), Required(ErrorMessage = "*"), MaxLength(80)]
        public string NomUtilisateur { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email"), Required(ErrorMessage = "*"), MaxLength(80)]
        public string TelUtilisateur { get; set; }
        [Display(Name = "Téléphone"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string EmailUtilisateur { get; set; }

    }
}