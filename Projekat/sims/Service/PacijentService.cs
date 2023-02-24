// File:    PacijentService.cs
// Created: 14 May, 2020 18:35:03
// Purpose: Definition of Class PacijentService

using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class PacijentService
   {
      private PacijentRepository _pacijentRepository;

      public Model.Pacijent SlanjeNaBolnickoLecenjeSoba(int idProstorije, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Pacijent> PrikazivanjeSvihPacijenataPoLekaru(int idLekara)
      {
         throw new NotImplementedException();
      }
      
      public Model.Pacijent RegistrovanjePacijenta(String ime, String prezime, String email, String lozinka, String jmbg, String adresa, DateTime datumRodjenja)
      {
         throw new NotImplementedException();
      }
      
      public Boolean DeaktiviranjeNalogaPacijenta(String jmbg)
        {
            throw new NotImplementedException();
        }
      
      
      public Model.Pacijent SlanjeNaBolnickoLecenje(DateTime datumSlanjaNaBolnickoLecenje, String jmbgPacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjePacijenta(String jmbg)
      {
         throw new NotImplementedException();
      }

        public List<Model.Pacijent> PretrazivanjePacijenataPoImenu(String imePacijenta)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ProveravanjePacijentaPoImenu(String imePacijenta)
      {
         throw new NotImplementedException();
      }

        public List<Model.Pacijent> PrikazivanjePacijentaPoImenu(String imePacijenta)
      {
         throw new NotImplementedException();
      }
      
      public List<Model.Pacijent> PrikazivanjeSvihPacijenata()
      {
         throw new NotImplementedException();
      }
      
      public Repository.ProstorijaRepositor prostorijaRepository;
      public Repository.PacijentRepository pacijentRepository;
   
   }
}