// File:    ProstorijaRepository.cs
// Created: 27 May, 2020 17:04:11
// Purpose: Definition of Class ProstorijaRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class ProstorijaRepository
   {
      private String pathProstorija;
      
      public Model.Prostorija GetProstorijaById(int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public Model.Prostorija SetProstorija(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Model.Prostorija GetProstorijaByStanje(Model.StanjeProstorije stanje)
      {
         throw new NotImplementedException();
      }
      
      public Model.Prostorija AddProstorija(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemoveProstorija(int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public Boolean SetStanje(int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public List<Prostorija> GetSveProstorije()
      {
         throw new NotImplementedException();
      }
      
      public Model.StanjeProstorije GetStanjeProstorijeById(int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public List<Prostorija> GetSlobodneBolnickeProstorijeByDatum(DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public Model.StanjeProstorije SetStanjeProstorijeById(int idProstorije)
      {
         throw new NotImplementedException();
      }
   
   }
}