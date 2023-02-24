// File:    Pitanje.cs
// Created: 2 June, 2020 13:01:39
// Purpose: Definition of Class Pitanje

using System;

namespace Model
{
   public class Pitanje
   {
      private String autor;
      private DateTime datumSlanja;
      private String naslovPitanja;
      private String sadrzajPitanja;
      private int idPitanja;
      
      public Pacijent pacijent;
      
      /// <summary>
      /// Property for Pacijent
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Pacijent Pacijent
      {
         get
         {
            return pacijent;
         }
         set
         {
            if (this.pacijent == null || !this.pacijent.Equals(value))
            {
               if (this.pacijent != null)
               {
                  Pacijent oldPacijent = this.pacijent;
                  this.pacijent = null;
                  oldPacijent.RemovePitanje(this);
               }
               if (value != null)
               {
                  this.pacijent = value;
                  this.pacijent.AddPitanje(this);
               }
            }
         }
      }
   
   }
}