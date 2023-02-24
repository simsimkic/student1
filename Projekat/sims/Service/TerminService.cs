// File:    TerminService.cs
// Created: 17 May, 2020 16:58:47
// Purpose: Definition of Class TerminService

using System;
using System.Collections.Generic;

namespace Service
{
   public class TerminService
   {
      public List<Model.Termin> PrikazivanjeZakazanihOperacijaLekara(int idLekara)
      {
         throw new NotImplementedException();
      }

        public List<Model.Termin> PrikazivanjeZakazanihTerminaPacijenata(String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin ZakazivanjeTermin(int idLekara, DateTime termin, String jmbgPacijenta, int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public Boolean OtkazivanjeTermin(int idTermina)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin MenjanjeTermin(int id)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin PrikazivanjeTermina(int id)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeTerminaPoDatumu(DateTime datum, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeTerminaPoLekaru(Model.Lekar lekarIme, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Termin> ZakazaniTerminiPoDatumu(DateTime datum, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Termin> ZakazaniTerminiPoLekaru(int lekar, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Termin> PrikazivanjeSlobodnihTerminaPoDatumuiLekaru(DateTime datum, int idLekara)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjeSlobodnihTerminaPoDatumuiLekaru(DateTime datum, int idLekara)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Termin> PrikazivanjeSlobodnihTerminaPoDatumu(DateTime datum)
      {
         throw new NotImplementedException();
      }
      
      public Repository.TerminRepository terminRepository;
      public IZakazivanjeTerminBehavior strategy;
   
   }
}