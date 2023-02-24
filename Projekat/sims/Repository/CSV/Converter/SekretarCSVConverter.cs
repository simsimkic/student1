using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class SekretarCSVConverter : ICSVConverter<Sekretar>
    {
        private readonly string _delimiter;

        public SekretarCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Sekretar sekretar)
          => string.Join(_delimiter,
              sekretar.Email,
              sekretar.Lozinka,
              sekretar.Ime,
              sekretar.Prezime,
              sekretar.Jmbg,
              sekretar.Adresa,
              sekretar.IdZaposlenog,
              sekretar.Plata);

        public Sekretar ConvertCSVFormatToEntity(string sekretarCSVFormat)
        {
            string[] tokens = sekretarCSVFormat.Split(_delimiter.ToCharArray());
            return new Sekretar(
                tokens[0], tokens[1], tokens[2], tokens[3], tokens[4], tokens[5],
                long.Parse(tokens[6]),
                int.Parse(tokens[7]));
        }


    }

}
