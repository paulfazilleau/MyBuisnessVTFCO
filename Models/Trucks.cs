using System;
using System.Collections.Generic;

namespace MyBuisnessVTCO.Models
{
    public class Truck
    {
        public int ID { get; set; }
        public string OM { get; set; }
        public string NumChassis { get; set; }
        public string V_Operation { get; set; }
        public string V_Description { get; set; }
        public string V_Gamme { get; set; }
        public string V_Modele { get; set; }
        public string V_Type { get; set; }
        public string V_Moteur { get; set; }
        public string C_Type { get; set; }
        public string C_Marque { get; set; }
        public string C_Description { get; set; }
        public string D_Chassis { get; set; }
        public string D_Carrosserie { get; set; }
        public string A_Kilometrage { get; set; }
        public string A_Immatriculation { get; set; }
        public string A_Localisation { get; set; }
        public string F_PrixMiniClient { get; set; }
        public string F_ComForfait { get; set; }
        public string F_VNC { get; set; }
        public DateTime ReservationDate { get; set; }

    }
}
