// File:    ReceptService.cs
// Created: 26 May, 2020 13:42:13
// Purpose: Definition of Class ReceptService

using System;

namespace Service
{
   public class ReceptService
   {
      public Model.Recept PisanjeRecepta(Model.Lek imeLeka, String opisRecepta, Model.Pacijent pacijent, Model.Lekar lekar, DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CitanjeRecepta(int idRecepta)
      {
         throw new NotImplementedException();
      }
      
      public Repository.ReceptRepository receptRepository;
   
   }
}