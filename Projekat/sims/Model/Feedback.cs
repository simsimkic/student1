// File:    Feedback.cs
// Created: 2 June, 2020 12:59:30
// Purpose: Definition of Class Feedback

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Feedback : IIdentifiable<long>
   {
        public String Naslov { get; set; }
        public String Sadrzaj { get; set; }
        public DateTime DatumSlanja { get; set; }
        public long IdFeedbacka { get; set; }




        public Feedback(long idFeedbacka)
          {
              IdFeedbacka = idFeedbacka;

          }

        public Feedback(string naslov, string sadrzaj, DateTime datumSlanja, long IdFeedbecka)
        {
            Naslov = naslov;
            Sadrzaj = sadrzaj;
            DatumSlanja = datumSlanja;
        }

        public long GetId() => IdFeedbacka;

        public void SetId(long idFeedbacka) => IdFeedbacka = idFeedbacka;
    }
}