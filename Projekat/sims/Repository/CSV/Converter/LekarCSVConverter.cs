using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class LekarCSVConverter : ICSVConverter<Lekar>
    {
        private readonly string _delimiter;

        public LekarCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Lekar lekar)
          => string.Join(_delimiter,
              lekar.Email,
              lekar.Lozinka,
              lekar.Ime,
              lekar.Prezime,
              lekar.Jmbg,
              lekar.Adresa,
              lekar.Specijalizacija,
              lekar.IdZaposlenog,
              lekar.Plata);

        public Lekar ConvertCSVFormatToEntity(string lekarCSVFormat)
        {
            string[] tokens = lekarCSVFormat.Split(_delimiter.ToCharArray());
            return new Lekar(
                tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5],
                tokens[6],
                long.Parse(tokens[7]),
                int.Parse(tokens[8]));
        }

        Lekar ICSVConverter<Lekar>.ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }
    }
}
