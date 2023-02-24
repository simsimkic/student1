using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class LekCSVConverter : ICSVConverter<Lek>
    {
        private readonly string _delimiter;

        public LekCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Lek lek)
          => string.Join(_delimiter,
              lek.Naziv,
              lek.IdLeka,
              lek.Proizvodjac,
              lek.Odobren);

        public Lek ConvertCSVFormatToEntity(string lekCSVFormat)
        {
            string[] tokens = lekCSVFormat.Split(_delimiter.ToCharArray());
            return new Lek(
                tokens[0],
                long.Parse(tokens[1]), tokens[2],
                bool.Parse(tokens[3]));
        }

    }
}
