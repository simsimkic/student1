// File:    LekarService.cs
// Created: 14 May, 2020 19:21:46
// Purpose: Definition of Class LekarService

using System;
using System.Collections.Generic;

namespace Service
{
   public class LekarService
   {
      
      public bool test = true;  
      public List<Model.Lekar> PrikazivanjeSvihLekara()
      {
         throw new NotImplementedException();
      }
      
      public Model.Ocena OcenjivanjeLekara(Model.VrednostOcene vrednostOcene, int idLekara)
      {
         throw new NotImplementedException();
      }
      
      public Repository.LekarRepository lekarRepository;
      public Repository.OcenaRepository ocenaRepository;
   
   }
}