// File:    TerminRepository.cs
// Created: 27 May, 2020 17:04:11
// Purpose: Definition of Class TerminRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class TerminRepository
   {
      private String pathTermin;
      
      public Model.Termin SetTermin(Model.Termin termin)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin AddTermin(Model.Termin termin)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin RemoveTermin(int idTermina)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin GetTerminByID(int idTermina)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetTerminByPacijentJMBG(String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetTerminByLekarPacijent(int idLekara, int idPacijent)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetTerminByVreme(DateTime vreme)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetTerminByProstorijaID(int idProstorije)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetSviTermini(String idPacijent)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin GetTerminByDatumPacijenta(DateTime datum, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetSlobodniTerminiByDatumiLekar(DateTime datum, int idLekara)
      {
         throw new NotImplementedException();
      }
      
      public Model.Termin SetStanjeTerminaByID(int idTermina, Boolean stanje)
      {
         throw new NotImplementedException();
      }
      
      public List<Termin> GetSlobodanTerminByDatum(DateTime datum)
      {
         throw new NotImplementedException();
      }
   
   }
}