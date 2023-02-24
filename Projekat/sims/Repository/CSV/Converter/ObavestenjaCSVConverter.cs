using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class ObavestenjaCSVConverter : ICSVConverter<Obavestenja>
    {
        private readonly string _delimiter;

        public ObavestenjaCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Obavestenja obavestenja)
          => string.Join(_delimiter,
              obavestenja.Sadrzaj,
              obavestenja.Naslov,
              obavestenja.Posiljalac,
              obavestenja.IdObavestenja);

        public Obavestenja ConvertCSVFormatToEntity(string obavestenjaCSVFormat)
        {
            string[] tokens = obavestenjaCSVFormat.Split(_delimiter.ToCharArray());
            return new Obavestenja(
                tokens[0],
                tokens[1],
                tokens[2],
                long.Parse(tokens[3]));
        }

    }
}
