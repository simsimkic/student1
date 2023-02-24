using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class UpravnikCSVConverter : ICSVConverter<Upravnik>
    {
        private readonly string _delimiter;

        public UpravnikCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Upravnik upravnik)
          => string.Join(_delimiter,
              upravnik.Email,
              upravnik.Lozinka,
              upravnik.Ime,
              upravnik.Prezime,
              upravnik.Jmbg,
              upravnik.Adresa,
              upravnik.IdZaposlenog,
              upravnik.Plata);

        public Upravnik ConvertCSVFormatToEntity(string upravnikCSVFormat)
        {
            string[] tokens = upravnikCSVFormat.Split(_delimiter.ToCharArray());
            return new Upravnik(
                tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5],
                long.Parse(tokens[6]),
                int.Parse(tokens[7]));
        }

        Upravnik ICSVConverter<Upravnik>.ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }
    }
}
