// File:    OpremaRepository.cs
// Created: 27 May, 2020 17:04:11
// Purpose: Definition of Class OpremaRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class OpremaRepository
   {
      private String pathOprema;
      
      public Model.Oprema SetOprema(Model.Oprema oprema)
      {
         throw new NotImplementedException();
      }
      
      public Model.Oprema GetOpremaById(int idOprema)
      {
         throw new NotImplementedException();
      }
      
      public List<Oprema> GetOpremaByTip(Model.TipOpreme tipOpreme)
      {
         throw new NotImplementedException();
      }
      
      public List<Oprema> GetOpremaByProstorija(Model.Prostorija prostorija)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemoveOprema(int id)
      {
         throw new NotImplementedException();
      }
   
   }
}