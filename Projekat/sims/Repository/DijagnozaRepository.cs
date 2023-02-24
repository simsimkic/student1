// File:    DijagnozaRepository.cs
// Created: 27 May, 2020 17:05:06
// Purpose: Definition of Class DijagnozaRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class DijagnozaRepository
   {
      private String pathDijagnoza;
      
      public List<Dijagnoza> GetDijagnozaByPacijent(String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Model.Dijagnoza SetDijagnoza(Model.Dijagnoza dijagnoza)
      {
         throw new NotImplementedException();
      }
      
      public List<Dijagnoza> GetDijagnozaByLekar(int idLekara)
      {
         throw new NotImplementedException();
      }
      
      public Model.Dijagnoza AddDijagnoza(Model.Dijagnoza dijagnoza)
      {
         throw new NotImplementedException();
      }
      
      public List<Dijagnoza> GetDijagnozaPacijentOdLekara(Model.Lekar lekar, Model.Pacijent pacijent)
      {
         throw new NotImplementedException();
      }
   
   }
}