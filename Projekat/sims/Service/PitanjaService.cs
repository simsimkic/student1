// File:    PitanjaService.cs
// Created: 17 May, 2020 16:33:02
// Purpose: Definition of Class PitanjaService

using System;

namespace Service
{
   public class PitanjaService
   {
      public Model.Pitanje OdgovaranjeNaPitanja(String sadrzajOdgovora, int idPitanja)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CitanjePitanja(int idPitanja)
      {
         throw new NotImplementedException();
      }
      
      public Model.Pitanje PisanjePitanja(String sadrzajPitanja, String naslovPitanja, DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public Repository.PitanjeRepository pitanjeRepository;
   
   }
}