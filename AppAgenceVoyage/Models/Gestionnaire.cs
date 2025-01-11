using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AppAgenceVoyage.Models
{
    public class Gestionnaire: Utilisateur
    {
        [Display(Name = "Ninea"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string NineaGestionnaire {  get; set; }
        [Display(Name = "RCCM"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string RCCMGestionnaire { get; set; }
        [Display(Name = "NCI"), Required(ErrorMessage = "*"), MaxLength(20)]
        public string NCIGestionnaire { get; set; }


    }
}