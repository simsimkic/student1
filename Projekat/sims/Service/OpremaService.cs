// File:    OpremaService.cs
// Created: 17 May, 2020 16:45:08
// Purpose: Definition of Class OpremaService

using System;
using System.Collections.Generic;

namespace Service
{
   public class OpremaService
   {
      public List<Model.Oprema> PrikazivanjeDostupneOpreme()
      {
         throw new NotImplementedException();
      }
      
      public Model.Oprema DodavanjeOpreme(String tipOpreme, int kolicinaOpreme)
      {
         throw new NotImplementedException();
      }
      
      public Boolean PremestanjeOpreme(String tipOpreme, int kolicinaOpreme, Model.Prostorija prostorijaUkojuSePrebacuje, Model.Prostorija prostorijaIzKojeSePrebacuje)
      {
         throw new NotImplementedException();
      }
      
      public Boolean OdbacivanjeOpreme(int idOpreme)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Oprema> PretrazivanjeOpreme(String naziv)
      {
         throw new NotImplementedException();
      }
      
      public Boolean UnosenjePotroseneOpreme(Model.Oprema nazivOpreme, int kolicinaPotroseneOpreme)
      {
         throw new NotImplementedException();
      }
      
      public Repository.OpremaRepository opremaRepository;
   
   }
}