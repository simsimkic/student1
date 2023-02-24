using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    class ProstorijaCSVConverter : ICSVConverter<Prostorija>
    {
        private readonly string _delimiter;

        public ProstorijaCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Prostorija prostorija)
              => string.Join(_delimiter,
              prostorija.IdProstorije,
              prostorija.TipProstorije,
              prostorija.Stanje);

        public Prostorija ConvertCSVFormatToEntity(string prostorijaCSVFormat)
        {
            string[] tokens = prostorijaCSVFormat.Split(_delimiter.ToCharArray());
            return new Prostorija(
                long.Parse(tokens[0]), tokens[1], tokens[2]);
        }


    }
}
