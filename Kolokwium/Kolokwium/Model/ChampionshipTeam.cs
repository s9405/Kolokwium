using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class ChampionshipTeam
    {
        [ForeignKey("IdTeam")]
        public Team Team { get; set; }
        [ForeignKey("IdChampionship")]
        public Championship Championship { get; set; }
    }
}
