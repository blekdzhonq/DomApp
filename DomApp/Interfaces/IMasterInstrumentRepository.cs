using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using DomApp.Models.DomainModels;

namespace DomApp.Interfaces
{
    public interface IMasterInstrumentRepository
    {
        Task<MasterInstrument> CreateAsync(MasterInstrument instrument);


        Task<decimal> GetPointValueByInstrumentAsync(string name);

        Task<bool> InstrumentExists(string name);
    }
}