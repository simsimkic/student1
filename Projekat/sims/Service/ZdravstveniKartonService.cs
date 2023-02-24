// File:    ZdravstveniKartonService.cs
// Created: 17 May, 2020 16:45:01
// Purpose: Definition of Class ZdravstveniKartonService

using System;
using System.Collections.Generic;

namespace Service
{
   public class ZdravstveniKartonService
   {
      public List<Model.ZdravstveniKarton> PrikazivanjeKartonaSvihPacijenata()
      {
         throw new NotImplementedException();
      }
      
      public Boolean BrisanjeKartona(String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Model.ZdravstveniKarton CitanjeKartonaPacijenta(String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Repository.ZdravstveniKartonRepository zdravstveniKartonRepository;
   
   }
}