using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class OpremaCSVConverter : ICSVConverter<Oprema>
    {
        private readonly string _delimiter;

        public OpremaCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Oprema oprema)
          => string.Join(_delimiter,
              oprema.ImeOpreme,
              oprema.TipOpreme,
              oprema.KolicinaOpreme,
              oprema.IdOpreme);

        public Oprema ConvertCSVFormatToEntity(string opremaCSVFormat)
        {
            string[] tokens = opremaCSVFormat.Split(_delimiter.ToCharArray());
            return new Oprema(
                tokens[0], tokens[1], int.Parse(tokens[2]), long.Parse(tokens[3]));
        }

       
    }
}
