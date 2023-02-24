// File:    PitanjeRepository.cs
// Created: 27 May, 2020 17:05:05
// Purpose: Definition of Class PitanjeRepository

using System;
using System.Collections.Generic;

namespace Repository
{
   public class PitanjeRepository
   {
      private String pathPitanja;
      
      public Model.Pitanje GetPitanjaById(int idPitanja)
      {
         throw new NotImplementedException();
      }
      
      public Model.Pitanje SetPitanja(Model.Pitanje pitanje)
      {
         throw new NotImplementedException();
      }
      
      public Model.Pitanje AddPitanja(Model.Pitanje pitanje)
      {
         throw new NotImplementedException();
      }
      
      public List<Pitanja> GetPitanjaByAutor(String autor)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemovePitanja(int idPitanja)
      {
         throw new NotImplementedException();
      }
      
      public List<Pitanja> GetPitanjaByDate(DateTime datum)
      {
         throw new NotImplementedException();
      }
   
   }
}