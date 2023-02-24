using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class TerminCSVConverter : ICSVConverter<Termin>
    {
        private readonly string _delimiter;
        private readonly string _datetimeFormat;

        public TerminCSVConverter(string delimiter, string datetimeFormat)
        {
            _delimiter = delimiter;
            _datetimeFormat = datetimeFormat;
        }

        public string ConvertEntityToCSVFormat(Termin termin)
            => string.Join(_delimiter,
                termin.TipTermina,
                termin.VremeTermina.ToString(_datetimeFormat),
                termin.Hitno,
                termin.StanjeTermina,
                termin.IdTermina,
                termin._Prostorija.IdProstorije,
                termin._Lekar.IdZaposlenog,
                termin._Pacijent.IdPacijenta);

        public Termin ConvertCSVFormatToEntity(string terminCSVFormat)
        {
            string[] tokens = terminCSVFormat.Split(_delimiter.ToCharArray());
            return new Termin(
                tokens[0],
                DateTime.Parse(tokens[1]),
                Boolean.Parse(tokens[2]),
                tokens[3],
                long.Parse(tokens[4]),   
                new Prostorija(long.Parse(tokens[5])),
                new Lekar(long.Parse(tokens[6])),
                new Pacijent(long.Parse(tokens[7])));
        }

        Termin ICSVConverter<Termin>.ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }
    }
}
