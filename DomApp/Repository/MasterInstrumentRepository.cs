using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using DomApp.Data;
using DomApp.Interfaces;
using DomApp.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DomApp.Repository
{
    public class MasterInstrumentRepository : IMasterInstrumentRepository
    {

        private readonly DomAppContext _domContext;

        public MasterInstrumentRepository(DomAppContext domContext)
        {
            _domContext = domContext;
        }

        public async Task<MasterInstrument> CreateAsync(MasterInstrument instrument)
        {
            await _domContext.AddAsync(instrument);

            await _domContext.SaveChangesAsync();

            return instrument;
        }

        public async Task<decimal> GetPointValueByInstrumentAsync(string name)
        {

            string ticker = "";
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == ' ')
                    break;
                ticker += name[i];
            }

            var inst = await _domContext.MasterInstruments.FirstOrDefaultAsync(i => i.Name == ticker);

            if (inst == null)
                return 0;

            return inst.PointValue;
        }

        public async Task<bool> InstrumentExists(string name)
        {
            return await _domContext.MasterInstruments.AnyAsync(inst => inst.Name == name);
        }
    }
}