// File:    ObavestenjaController.cs
// Created: 26 May, 2020 14:37:17
// Purpose: Definition of Class ObavestenjaController

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class ObavestenjaController
   {/*
      public Boolean CitanjeObavestenja(int idObavestenja)
      {
         obavestenjeService.CitanjeObavestenja(idObavestenja);
      }
      
      public Model.Obavestenja ObavestavanjeOPomerenomTerminu(DateTime vremeNovogTermina, int idLekara, Boolean jmbgPacijenta, DateTime stariTermin, DateTime noviTermin)
      {
         obavestenjeService.ObavestavanjeOPomerenomTerminu(vremeNovogTermina, idLekara, jmbgPacijenta, stariTermin, noviTermin);
      }
      
      public Model.Obavestenja ObavestavanjeOOtkazanomTerminu(int idLekar, String jmbgPacijent, DateTime stariTermin)
      {
         obavestenjeService.ObavestavanjeOOtkazanomTerminu(idLekar, jmbgPacijent, stariTermin);
      }
      
      public Model.Obavestenja SlanjeObavestenjaZaposlenima(String naslovObavestenja, String tekstObavestenja, DateTime datum)
      {
         obavestenjeService.SlanjeObavestenjaZaposlenima(naslovObavestenja, tekstObavestenja, datum);
      }
      
      public List<Model.Obavestenja> PrikazivanjeSvihObavestenja()
      {
         obavestenjeService.PrikazivanjeSvihObavestenja();
      }
      
      public Model.Obavestenja ObavestavanjeLekaraOHitnimSlucajevima(int idLekara, String sadrzajObavestenja, String naslov)
      {
         obavestenjeService.ObavestavanjeLekaraOHitnimSlucajevima(idLekara, sadrzajObavestenja, naslov);
      }
      */
      public Service.ObavestenjeService obavestenjeService;
   
   }
}