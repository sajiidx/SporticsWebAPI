using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SporticsWebAPI.Models
{
    public class Players
    {
        [Key]
        public string Id { get; set; }
        [Display(Name = "Team")]
        public virtual int TeamID { get; set; }
        [ForeignKey("TeamID")]
        [JsonIgnore]
        public virtual Teams Team { get; set; }
    }
}
