using System.Globalization;
using CsvHelper;
using DomApp.Interfaces;
using DomApp.Models.DTOs;

namespace DomApp.Services
{
    public class CsvMasterInstrumentService : ICsvService
    {
        public IEnumerable<CreateMasterInstrumentDto> ReadInstrumentsFromCsv(string filePath)
        {
            using (var streamReader = new StreamReader(filePath))
            using (var csv = new CsvReader(streamReader, CultureInfo.InvariantCulture))
            {
                csv.Context.TypeConverterOptionsCache.GetOptions<decimal>().NumberStyles = NumberStyles.Number | NumberStyles.AllowExponent;

                return csv.GetRecords<CreateMasterInstrumentDto>().ToList();
            }
        }
    }
}