// File:    RenoviranjeRepository.cs
// Created: 23 June, 2020 14:44:50
// Purpose: Definition of Class RenoviranjeRepository

using System;

namespace Repository
{
   public class RenoviranjeRepository
   {
      private String pathRenoviranje;
      
      public Model.StanjeProstorije GetStanjeProstostorije(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Boolean SetStanjeProstorije(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Model.Renoviranje AddRenoviranje(Model.Renoviranje renoviranje)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemoveRenoviranje(int idRenoviranja)
      {
         throw new NotImplementedException();
      }
      
      public Model.Renoviranje SetRenoviranje(Model.Renoviranje renoviranje)
      {
         throw new NotImplementedException();
      }
      
      public DateTime GetDatumPocetka(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Boolean SetDatumPocetka(DateTime datumPocetka, int idRenoviranja)
      {
         throw new NotImplementedException();
      }
      
      public DateTime GetDatumZavrsetka(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Boolean SetDatumZavrsetka(DateTime datumZavrsetka, int idRenoviranja)
      {
         throw new NotImplementedException();
      }
      
      public Boolean SetStanjeRenoviranja(Model.TipRenoviranja tipRenoviranja)
      {
         throw new NotImplementedException();
      }
   
   }
}