// File:    ReceptRepository.cs
// Created: 27 May, 2020 17:08:36
// Purpose: Definition of Class ReceptRepository

using System;
using System.Collections.Generic;

namespace Repository
{
   public class ReceptRepository
   {
      private String pathRecept;
      
      public Model.Recept GetRecept(int idRecepta)
      {
         throw new NotImplementedException();
      }
      
      public Model.Recept SetRecept(Model.Recept recept)
      {
         throw new NotImplementedException();
      }
      
      public Model.Recept AddRecept(Model.Recept recept)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Recept> GetReceptByPacijentOdLekara(Model.Lekar lekar, Model.Pacijent pacijent)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemoveRecept(int idRecepta)
      {
         throw new NotImplementedException();
      }
   
   }
}