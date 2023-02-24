// File:    DijagnozaService.cs
// Created: 26 May, 2020 13:42:12
// Purpose: Definition of Class DijagnozaService

using System;

namespace Service
{
   public class DijagnozaService
   {
      public Model.Dijagnoza PisanjeDijagnoze(String opisDijagnoze, Model.Pacijent pacijent, Model.Lekar lekar, DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CitanjeDijagnoze(int idDijagnoze)
      {
         throw new NotImplementedException();
      }
      
      public Repository.DijagnozaRepository dijagnozaRepository;
   
   }
}