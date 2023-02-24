// File:    PitanjaController.cs
// Created: 26 May, 2020 14:18:58
// Purpose: Definition of Class PitanjaController

using Service;
using System;

namespace Controller
{
   public class PitanjaController
   {/*
      public Model.Pitanje OdgovaranjeNaPitanja(String sadrzajOdgovora, int idPitanja)
      {
         pitanjaService.OdgovaranjeNaPitanja(sadrzajOdgovora, idPitanja);
      }
      
      public Boolean CitanjePitanja(int idPitanja)
      {
         pitanjaService.CitanjePitanja(idPitanja);
      }
      
      public Model.Pitanje PisanjePitanja(String sadrzajPitanja, String naslovPitanja, DateTime datum)
      {
         pitanjaService.PisanjePitanja(sadrzajPitanja, naslovPitanja, datum);
      }
      
      public Model.Feedback PisanjeFeedbacka(String naslovFeedbacka, String sadrzajFeedbacka)
      {
         feedbackService.PisanjeFeedbacka(naslovFeedbacka, sadrzajFeedbacka);
      }
      
      public Boolean CitanjeFeedbacka(int idFeedbacka)
      {
         feedbackService.CitanjeFeedbacka(idFeedbacka);justtesting lol
      }
      */
      public Service.PitanjaService pitanjaService;
      public Service.FeedbackService feedbackService;

    }
}