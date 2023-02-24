// File:    ZaposleniRepository.cs
// Created: 27 May, 2020 17:05:05
// Purpose: Definition of Class ZaposleniRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class ZaposleniRepository
   {
      private String pathZaposleni;
      
      public Model.Zaposleni SetZaposleni(Model.Zaposleni zaposleni)
      {
         throw new NotImplementedException();
      }
      
      public Model.Zaposleni GetZaposleniById(int idZaposlenog)
      {
         throw new NotImplementedException();
      }
      
      public List<Zaposleni> GetZaposleniByPlata(int plata)
      {
         throw new NotImplementedException();
      }
      
      public Boolean RemoveZaposleni(int idZaposlenog)
      {
         throw new NotImplementedException();
      }
      
      public Model.Zaposleni AddZaposleni(Model.Zaposleni zaposleni)
      {
         throw new NotImplementedException();
      }
   
   }
}