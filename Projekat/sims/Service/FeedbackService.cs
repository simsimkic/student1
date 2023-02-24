// File:    FeedbackService.cs
// Created: 26 May, 2020 14:06:09
// Purpose: Definition of Class FeedbackService

using Repository;
using System;

namespace Service
{
   public class FeedbackService
   {
      public Model.Feedback PisanjeFeedbacka(String naslovFeedbacka, String sadrzajFeedbacka)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CitanjeFeedbacka(int idFeedbacka)
      {
         throw new NotImplementedException();
      }
      
      public Repository.FeedbackRepository feedbackRepository;

        public FeedbackService(FeedbackRepository feedbackRepository)
        {
            this.feedbackRepository = feedbackRepository;
        }
    }
}