using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomApp.Models.DTOs
{
    public class CreateMasterInstrumentDto
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public decimal TickSize { get; set; }

        [Required]
        public decimal PointValue { get; set; }
        [Required]
        public string? Url { get; set; }
    }
}