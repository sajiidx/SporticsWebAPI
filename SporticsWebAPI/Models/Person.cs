using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SporticsWebAPI.Models
{
    public class Person
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string Dept { get; set; }
        [Required]
        public int Batch { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
