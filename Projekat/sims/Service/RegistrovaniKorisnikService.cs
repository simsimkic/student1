// File:    RegistrovaniKorisnikService.cs
// Created: 17 May, 2020 16:21:48
// Purpose: Definition of Class RegistrovaniKorisnikService

using Model;
using System;

namespace Service
{
   public class RegistrovaniKorisnikService
   {
      public Korisnik PrijavaKorisnika(String jmbg, String lozinka)
      {
         throw new NotImplementedException();
      }
      
      public Korisnik OdjavaKorisnika(String jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeJMBG(String jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeLozinka(String lozinka, String jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Model.Pacijent RegistrovanjePacijenta(String ime, String prezime, String email, String lozinka, String jmbg, String adresa, DateTime datumRodjenja)
      {
         throw new NotImplementedException();
      }
      
      public Repository.RegistrovaniKorisnikRepository registrovaniKorisnikRepository;
   
   }
}