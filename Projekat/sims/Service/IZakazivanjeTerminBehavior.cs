// File:    IZakazivanjeTerminBehavior.cs
// Created: 25 June, 2020 16:45:20
// Purpose: Definition of Interface IZakazivanjeTerminBehavior

using System;

namespace Service
{
   public interface IZakazivanjeTerminBehavior
   {
      Model.Termin ZakazivanjeTermin(int idLekara, DateTime termin, String jmbgPacijenta, int idProstorije);
   
   }
}