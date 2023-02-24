// File:    ProstorijaController.cs
// Created: 26 May, 2020 14:11:51
// Purpose: Definition of Class ProstorijaController

using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class ProstorijaController
   {/*
      public Model.Renoviranje RenoviranjeProstorije(int idProstorija, DateTime pocetakRenoviranja, DateTime krajRenoviranja)
      {
         prostorijaService.RenoviranjeProstorije(idProstorija, pocetakRenoviranja, krajRenoviranja);
      }
      
      public List<Model.Prostorija> PrikazivanjeSvihProstorija()
      {
         prostorijaService.PrikazivanjeSvihProstorija();
      }
      
      public Model.Prostorija PrikazivanjeProstorije(int idProstorije)
      {
         prostorijaService.PrikazivanjeProstorije(idProstorije);
      }
      
      public List<Model.Prostorija> PrikazivanjeSvihSlobodnihProstorija()
      {
         prostorijaService.PrikazivanjeSvihSlobodnihProstorija();
      }
      */
      public Service.ProstorijaService prostorijaService;
   
   }
}