using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SporticsWebAPI.Models
{
    public class Houses
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Tagline { get; set; }
        [Display(Name = "President")]
        public virtual string PresidentID { get; set; }
        [ForeignKey("PresidentID")]
        [JsonIgnore]
        public virtual Person President { get; set; }
    }
}
