// File:    Ocena.cs
// Created: 18 April, 2020 20:06:03
// Purpose: Definition of Class Ocena

using System;

namespace Model
{
   public class Ocena
   {
      private DateTime datum;
      private VrednostOcene vrednost;
      
      public Pacijent pacijent;
      public Lekar lekar;
      
      /// <summary>
      /// Property for Lekar
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Lekar Lekar
      {
         get
         {
            return lekar;
         }
         set
         {
            this.lekar = value;
         }
      }
   
   }
}