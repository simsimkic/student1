// File:    PacijentController.cs
// Created: 26 May, 2020 13:45:43
// Purpose: Definition of Class PacijentController

using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class PacijentController
   {

        private PacijentService _pacijentService;
            
       /*
     
      public Model.Pacijent SlanjeNaBolnickoLecenjeSoba(int idProstorije, String jmbgPacijenta)
      {
         pacijentService.SlanjeNaBolnickoLecenjeSoba(idProstorije, jmbgPacijenta);
      }
      
      public List<Model.Pacijent> PrikazivanjeSvihPacijenataPoLekaru(int idLekara)
      {
         pacijentService.PrikazivanjeSvihPacijenataPoLekaru(idLekara);
      }
      
      public Model.Pacijent RegistrovanjePacijenta(String ime, String prezime, String email, String lozinka, String jmbg, String adresa, DateTime datumRodjenja)
      {
         pacijentService.RegistrovanjePacijenta(ime, prezime, email, lozinka, jmbg, adresa, datumRodjenja);
      }
      */
      public Boolean DeaktiviranjeNalogaPacijenta(String jmbgPacijenta)
      {
            return _pacijentService.DeaktiviranjeNalogaPacijenta(jmbgPacijenta);
      }
      /*
      public Model.Pacijent SlanjeNaBolnickoLecenje(DateTime datumSlanjaNaBolnickoLecenje, String jmbgPacijenta)
      {
         pacijentService.SlanjeNaBolnickoLecenje( datumSlanjaNaBolnickoLecenje, jmbgPacijenta);
      }
      
      public List<Model.Pacijent> PretrazivanjePacijenataPoImenu(String imePacijenta)
      {
         pacijentService.PretrazivanjePacijenataPoImenu(imePacijenta);
      }
      
      public List<Model.Pacijent> PrikazivanjePacijentaPoImenu(String imePacijenta)
      {
         pacijentService.PrikazivanjePacijentaPoImenu(imePacijenta);
      }
      
      public List<Model.Pacijent> PrikazivanjeSvihPacijenata()
      {
         pacijentService.PrikazivanjeSvihPacijenata();
      }
      */
      public Service.PacijentService pacijentService;
      public Service.ProstorijaService prostorijaService;
   
   }
}