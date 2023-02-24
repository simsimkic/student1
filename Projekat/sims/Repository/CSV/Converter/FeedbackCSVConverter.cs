using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Converter
{
    public class FeedbackCSVConverter : ICSVConverter<Feedback>
    {
        private readonly string _delimiter;

        public FeedbackCSVConverter(string delimiter)
        {
            _delimiter = delimiter;
        }

        public string ConvertEntityToCSVFormat(Feedback feedback)
          => string.Join(_delimiter,
              feedback.Naslov,
              feedback.Sadrzaj,
              feedback.DatumSlanja,
              feedback.IdFeedbacka);

        public Feedback ConvertCSVFormatToEntity(string feedbackCSVformat)
        {
            string[] tokens = feedbackCSVformat.Split(_delimiter.ToCharArray());
            return new Feedback(
                tokens[0], tokens[1],
                DateTime.Parse(tokens[2]),
                long.Parse(tokens[3]));
        }



        Feedback ICSVConverter<Feedback>.ConvertCSVFormatToEntity(string entityCSVFormat)
        {
            throw new NotImplementedException();
        }
    }
}
