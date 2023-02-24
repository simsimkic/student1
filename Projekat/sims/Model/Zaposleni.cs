// File:    Zaposleni.cs
// Created: 18 April, 2020 18:48:05
// Purpose: Definition of Class Zaposleni

using System;

namespace Model
{
   public class Zaposleni : Korisnik
   {
      public long IdZaposlenog { get; set; }

      public int Plata { get; set; }
      
      public RadnoVreme RadnoVreme { get; set; }

      public Obavestenja[] obavestenja;
   
   }
}