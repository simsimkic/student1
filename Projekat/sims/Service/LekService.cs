// File:    LekService.cs
// Created: 14 May, 2020 18:45:59
// Purpose: Definition of Class LekService

using System;

namespace Service
{
   public class LekService
   {
      public Model.Lek DodavanjeLeka(String nazivLeka, String proizvodjacLeka, String opisLeka)
      {
         throw new NotImplementedException();
      }
      
      public Model.Lek OdobravanjeLeka(int idLeka, Boolean odobren)
      {
         throw new NotImplementedException();
      }
      
      public Model.Lek PorucivanjeLeka(Model.Lek lek, int kolicinaLeka)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeIdLeka(int idLeka)
      {
         throw new NotImplementedException();
      }
      
      public Repository.LekRepository lekRepository;
   
   }
}