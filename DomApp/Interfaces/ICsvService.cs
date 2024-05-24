using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomApp.Models;
using DomApp.Models.DomainModels;
using DomApp.Models.DTOs;

namespace DomApp.Interfaces
{
    public interface ICsvService
    {
        IEnumerable<CreateMasterInstrumentDto> ReadInstrumentsFromCsv(string filePath);
    }
}