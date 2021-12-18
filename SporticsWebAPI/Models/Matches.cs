using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SporticsWebAPI.Models
{
    public class Matches
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [Display(Name = "TeamA")]
        public virtual int TeamAID { get; set; }
        [ForeignKey("TeamAID")]
        [JsonIgnore]
        public virtual Teams TeamA { get; set; }

        [Display(Name = "TeamB")]
        public virtual int TeamBID { get; set; }
        [ForeignKey("TeamBID")]
        [JsonIgnore]
        public virtual Teams TeamB { get; set; }

        [Display(Name = "Winner")]
        public virtual int WinnerID { get; set; }
        [ForeignKey("WinnerID")]
        [JsonIgnore]
        public virtual Teams Winnner { get; set; }
        [Display(Name = "Venue")]
        public virtual int VenueID { get; set; }
        [ForeignKey("VenueID")]
        [JsonIgnore]
        public virtual Venues Venue { get; set; }
    }
}
