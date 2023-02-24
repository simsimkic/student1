// File:    UputService.cs
// Created: 26 May, 2020 13:42:08
// Purpose: Definition of Class UputService

using System;

namespace Service
{
   public class UputService
   {
      public Model.Uput PisanjeUputa(String opis, Model.Pacijent pacijent, Model.Termin termin, Model.Lekar specijalista)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CitanjeUputa(int idUputa)
      {
         throw new NotImplementedException();
      }
      
      public Repository.UputRepository uputRepository;
   
   }
}