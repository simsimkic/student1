// File:    ObavestenjeService.cs
// Created: 17 May, 2020 19:25:21
// Purpose: Definition of Class ObavestenjeService

using System;
using System.Collections.Generic;

namespace Service
{
   public class ObavestenjeService
   {
      public Boolean CitanjeObavestenja(int idObavestenja)
      {
         throw new NotImplementedException();
      }
      
      public Model.Obavestenja ObavestavanjeOPomerenomTerminu(DateTime vremeNovogTermina, int idLekara, Boolean jmbgPacijenta, DateTime stariTermin, DateTime noviTermin)
      {
         throw new NotImplementedException();
      }
      
      public Model.Obavestenja ObavestavanjeOOtkazanomTerminu(int idLekar, String jmbgPacijent, DateTime stariTermin)
      {
         throw new NotImplementedException();
      }
      
      public Model.Obavestenja SlanjeObavestenjaZaposlenima(String naslovObavestenja, String tekstObavestenja, DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Obavestenja> PrikazivanjeSvihObavestenja()
      {
         throw new NotImplementedException();
      }
      
      public Model.Obavestenja ObavestavanjeLekaraOHitnimSlucajevima(int idLekara, String sadrzajObavestenja, String naslov)
      {
         throw new NotImplementedException();
      }
      
      public Repository.ObavestenjaRepository obavestenjaRepository;
   
   }
}