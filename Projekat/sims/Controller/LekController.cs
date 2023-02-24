// File:    LekController.cs
// Created: 26 May, 2020 14:02:16
// Purpose: Definition of Class LekController

using System;

namespace Controller
{
   public class LekController
   {
     /* public Model.Lek DodavanjeLeka(String nazivLeka, String proizvodjacLeka, String opisLeka)
      {
         lekService.DodavanjeLeka(nazivLeka, proizvodjacLeka, opisLeka);
      }
      
      public Model.Lek OdobravanjeLeka(int idLeka, Boolean odobren)
      {
         lekService.OdobravanjeLeka(idLeka, odobren);
      }
      
      public Model.Lek PorucivanjeLeka(Model.Lek lek, int kolicinaLeka)
      {
         lekService.PorucivanjeLeka(lek, kolicinaLeka);
      }
      */
      public Service.LekService lekService;
   
   }
}