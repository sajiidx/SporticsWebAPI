using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SporticsWebAPI.Models
{
    public class Teams
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int MatchesPlayed { get; set; }
        [Required]
        public int Win { get; set; }
        [Required]
        public int Loss { get; set; }
        [Required]
        public int Draw { get; set; }
        [Required]
        public double Points { get; set; }
        // Foreign key   
        [Display(Name = "Game")]
        public virtual int GameID { get; set; }
        [ForeignKey("GameID")]
        [JsonIgnore]
        public virtual Games Game { get; set; }
        // Foreign key
        [Display(Name = "House")]
        public virtual int HouseID { get; set; }
        [ForeignKey("HouseID")]
        [JsonIgnore]
        public virtual Houses House { get; set; }
    }
}
