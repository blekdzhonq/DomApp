using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DomApp.Models.DomainModels
{
    public class User : IdentityUser
    {
        public string? UserId { get; set; }

        [Required]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; } = string.Empty;

        public ICollection<Instrument> FavoriteInstruments { get; set; } = new List<Instrument>();


    }
}