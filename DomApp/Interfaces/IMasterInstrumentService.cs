using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomApp.Interfaces
{
    public interface IMasterInstrumentService
    {

        Task<string> ReadFileAndCreate(string file);
    }
}