// File:    ProstorijaService.cs
// Created: 17 May, 2020 16:44:59
// Purpose: Definition of Class ProstorijaService

using System;
using System.Collections.Generic;

namespace Service
{
   public class ProstorijaService
   {
      public Model.Renoviranje RenoviranjeProstorije(int idProstorija, DateTime pocetakRenoviranja, DateTime krajRenoviranja)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Prostorija> PrikazivanjeSvihProstorija()
      {
         throw new NotImplementedException();
      }
      
      public Model.Prostorija PrikazivanjeProstorije(int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeRenoviranja(int idProstorije, DateTime pocetakRenoviranja, DateTime krajRenoviranja)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveraDostupnostiProstorijaPoDatumu(DateTime datum)
      {
         throw new NotImplementedException();
      }

        public List<Model.Prostorija> PrikazivanjeSvihSlobodnihProstorija()
      {
         throw new NotImplementedException();
      }
      
      public Repository.ProstorijaRepository prostorijaRepository;
      public Repository.RenoviranjeRepository renoviranjeRepository;
   
   }
}