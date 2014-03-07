using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebStack1_3.Enums;

namespace WebStack1_3.Models
{
    public class Pizza
    {
        [DisplayName("Besteller")]
        [Required]
        public string Besteller { get; set; }
        [Required]
        [DisplayName("Naam van de Pizza")]
        public string  NaamPizza { get; set; }
        [DisplayName("Extra Kaas")]
        public bool ExtraKaas { get; set; }
        [DisplayName("BetalingsWijze")]
        public BetaalWijze Betaal { get; set; }

    }
}