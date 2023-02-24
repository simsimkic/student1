// File:    Korisnik.cs
// Created: 20 April, 2020 15:16:10
// Purpose: Definition of Class Korisnik

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Korisnik : IIdentifiable<long>
    {
      public string Email { get; set; }
      public string Lozinka { get; set; }

      public string Ime { get; set; }
      public string Prezime { get; set; }
      public string Jmbg { get; set; }
      public string Adresa { get; set; }

        public String PisiFeedback()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Prijava()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Odjava()
      {
         throw new NotImplementedException();
      }

        public long GetId()
        {
            throw new NotImplementedException();
        }

        public void SetId(long id)
        {
            throw new NotImplementedException();
        }
    }
}