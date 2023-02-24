using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class ReceptCSVConverter : ICSVConverter<Recept>
    {
        private readonly string _delimiter;

        public ReceptCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Recept recept)
          => string.Join(_delimiter,
              recept.ImeLeka,
              recept.IdRecepta,
              recept.Terapija,
              recept.Dijagnoza);

        public Recept ConvertCSVFormatToEntity(string receptCSVFormat)
        {
            string[] tokens = receptCSVFormat.Split(_delimiter.ToCharArray());
            return new Recept(
                tokens[0],
                long.Parse(tokens[1]),
                tokens[2],
                new Dijagnoza(long.Parse(tokens[3])));
        }
    }
}
