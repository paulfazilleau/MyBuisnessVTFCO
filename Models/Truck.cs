using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBuisnessVTCO.Models
{
    public class Truck
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "OM")]
        public string OM { get; set; }
        public string NumChassis { get; set; }
        [Required]
        [Display(Name = "Opération")]
        public string V_Operation { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string V_Description { get; set; }
        public string V_Gamme { get; set; }
        public string V_Modele { get; set; }
        [Required]
        [Display(Name = "Type")]
        public string V_Type { get; set; }
        [Required]
        [Display(Name = "Moteur")]
        public string V_Moteur { get; set; }
        public string C_Type { get; set; }
        public string C_Marque { get; set; }
        public string C_Description { get; set; }
        public string D_Chassis { get; set; }
        public string D_Carrosserie { get; set; }
        public string A_Kilometrage { get; set; }
        [Required]
        [Display(Name = "Immatriculation")]
        public string A_Immatriculation { get; set; }
        public string A_Localisation { get; set; }
        public string F_PrixMiniClient { get; set; }
        public string F_ComForfait { get; set; }
        public string F_VNC { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date de réservation")]
        public DateTime? ReservationDate { get; set; }
        //public string Secret { get; set; }
    }
}
