// File:    ZakazivanjeOperacije.cs
// Created: 25 June, 2020 16:45:24
// Purpose: Definition of Class ZakazivanjeOperacije

using System;

namespace Service
{
   public class ZakazivanjeOperacije : IZakazivanjeTerminBehavior
   {
      public Model.Termin ZakazivanjeTermin(int idLekara, DateTime termin, String jmbgPacijenta, int idProstorije)
      {
         throw new NotImplementedException();
      }
   
   }
}