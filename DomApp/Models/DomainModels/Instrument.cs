using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomApp.Models.DomainModels
{
    public class Instrument
    {
        public string? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Expiration { get; set; }

        public User? user { get; set; }
        public string? UserId { get; set; }
    }
}