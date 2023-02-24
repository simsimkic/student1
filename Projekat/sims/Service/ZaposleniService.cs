// File:    ZaposleniService.cs
// Created: 17 May, 2020 16:40:52
// Purpose: Definition of Class ZaposleniService

using System;
using System.Collections.Generic;

namespace Service
{
   public class ZaposleniService
   {
      public List<Model.Zaposleni> PrikazivanjeSvihZaposlenih()
      {
         throw new NotImplementedException();
      }
      
      public Model.Zaposleni RegistrovanjeZaposlenih(String ime, String prezime, String email, String adresa, String lozinka, String jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean DeaktiviranjeZaposlenih(String jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean MenjanjeRadnogVremenaZaposlenih(Model.Zaposleni zaposleni, DateTime pocetakRadnogVremena, DateTime krajRadnogVremena)
      {
         throw new NotImplementedException();
      }
      
      public Boolean DavanjeSlobodnihDanaZaposlenima(Model.Zaposleni zaposleni, DateTime pocetakSlobodnihDana, DateTime krajSlobodnihDana)
      {
         throw new NotImplementedException();
      }
      
      public Boolean MenjanjePlateZaposlenih(Model.Zaposleni zaposleni, int novaPlata)
      {
         throw new NotImplementedException();
      }
      
      public Repository.ZaposleniRepository zaposleniRepository;
   
   }
}