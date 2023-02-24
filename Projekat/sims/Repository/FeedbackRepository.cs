// File:    FeedbackRepository.cs
// Created: 27 May, 2020 17:08:36
// Purpose: Definition of Class FeedbackRepository

using Model;
using sims.Repository.Abstract;
using sims.Repository.CSV;
using System;
using System.Collections.Generic;
using sims.Exceptions;
using sims.Repository.CSV.Stream;
using System.Linq;
using sims.Repository.Sequencer;

namespace Repository
{
   public class FeedbackRepository : CSVRepository<Feedback, long>, IFeedbackRepository
    {

        private String pathFeedback;

        private const string ENTITY_NAME = "Feedback";
        private readonly IEagerCSVRepository<Feedback, long> _feedbackRepository;

        public FeedbackRepository(ICSVStream<Feedback> cSVStream,
            ISequencer<long> sequencer,
            IEagerCSVRepository<Feedback, long> feedbackRepository)
            :base(ENTITY_NAME, cSVStream, sequencer)
        {
            _feedbackRepository = feedbackRepository;
        }



        public List<Feedback> GetFeedbackByDate(DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public Model.Feedback GetFeedbackById(int idFeedbacka)
      {
         throw new NotImplementedException();
      }
      
      public Model.Feedback SetFeedback(Model.Feedback feedback)
      {
         throw new NotImplementedException();
      }
      
      public Model.Feedback AddFeedback(Model.Feedback feedback)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemoveFeedback(int idFeedbacka)
      {
         throw new NotImplementedException();
      }
   
   }
}