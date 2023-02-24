// File:    ZdravstveniKartonController.cs
// Created: 26 May, 2020 14:29:55
// Purpose: Definition of Class ZdravstveniKartonController

using System;
using System.Collections.Generic;

namespace Controller
{
   public class ZdravstveniKartonController
   {
     /* public List<Model.ZdravstveniKarton> PrikazivanjeKartonaSvihPacijenata()
      {
         zdravstveniKartonService.PrikazivanjeKartonaSvihPacijenata();
      }
      
      public Boolean BrisanjeKartona(String jmbgPacijenta)
      {
         zdravstveniKartonService.BrisanjeKartona(jmbgPacijenta);
      }
      
      public Model.ZdravstveniKarton CitanjeKartonaPacijenta(String jmbgPacijenta)
      {
         zdravstveniKartonService.CitanjeKartonaPacijenta(jmbgPacijenta);
      }
      
      public Model.Recept PisanjeRecepta(Model.Lek imeLeka, String opisRecepta, Model.Pacijent pacijent, Model.Lekar lekar, DateTime datum)
      {
         receptService.PisanjeRecepta(imeLeka, opisRecepta, pacijent, lekar, datum);
      }
      
      public Boolean CitanjeRecepta(int idRecepta)
      {
         receptService.citanjeRecepta(idRecepta);
      }
      
      public Model.Uput PisanjeUputa(String opis, Model.Pacijent pacijent, Model.Termin termin, Model.Lekar specijalista)
      {
        uputService.pisanjeUputa(opis, pacijent, termin, specijalista);
      }
      
      public Boolean CitanjeUputa(int idUputa)
      {
         uputService.citanjeUputa(idUputa);
      }
      
      public Model.Dijagnoza PisanjeDijagnoze(String opisDijagnoze, Model.Pacijent pacijent, Model.Lekar lekar, DateTime datum)
      {
         dijagnozaService.pisanjeDijagnoze(opisDijagnoze, pacijent, lekar, datum);
      }
      
      public Boolean CitanjeDijagnoze(int idDijagnoze)
      {
         dijagnozaService.citanjeDijagnoze(idDijagnoze);
      }
      */
      public Service.ZdravstveniKartonService zdravstveniKartonService;
      public Service.ReceptService receptService;
      public Service.UputService uputService;
      public Service.DijagnozaService dijagnozaService;
   
   }
}