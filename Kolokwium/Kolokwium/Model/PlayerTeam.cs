using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class PlayerTeam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPlayerTeam { get; set; }
        [Required]
        [ForeignKey("IdPlayer")]
        public int IdPlayer { get; set; }
        [Required]
        [ForeignKey("IdTeam")]
        public int IdTeam { get; set; }
        public int NumOnShirt { get; set; }
        [MaxLength(300)]
        public string Comment { get; set; }
    }
}
