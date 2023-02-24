using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class PacijentCSVConverter : ICSVConverter<Pacijent>
    {
        private readonly string _delimiter;

        public PacijentCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Pacijent pacijent)
          => string.Join(_delimiter,
              pacijent.Email,
              pacijent.Lozinka,
              pacijent.Ime,
              pacijent.Prezime,
              pacijent.Jmbg,
              pacijent.Adresa,
              pacijent.IdPacijenta,
              pacijent.BolnickoLecenje);

        public Pacijent ConvertCSVFormatToEntity(string pacijentCSVFormat)
        {
            string[] tokens = pacijentCSVFormat.Split(_delimiter.ToCharArray());
            return new Pacijent(
                tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5],
                Boolean.Parse(tokens[7]),
                long.Parse(tokens[8]));
        }

        Pacijent ICSVConverter<Pacijent>.ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }
    }
}