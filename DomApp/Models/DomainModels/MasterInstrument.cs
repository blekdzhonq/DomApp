using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DomApp.Models.DomainModels
{
    public class MasterInstrument
    {

        public string? Id { get; set; }

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