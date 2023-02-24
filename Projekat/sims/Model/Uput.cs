// File:    Uput.cs
// Created: 18 April, 2020 19:31:29
// Purpose: Definition of Class Uput

using System;

namespace Model
{
   public class Uput
   {
      private String imeSpecijaliste;
      private String opis;
      
      public ZdravstveniKarton zdravstveniKarton;
      
      /// <summary>
      /// Property for ZdravstveniKarton
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public ZdravstveniKarton ZdravstveniKarton
      {
         get
         {
            return zdravstveniKarton;
         }
         set
         {
            if (this.zdravstveniKarton == null || !this.zdravstveniKarton.Equals(value))
            {
               if (this.zdravstveniKarton != null)
               {
                  ZdravstveniKarton oldZdravstveniKarton = this.zdravstveniKarton;
                  this.zdravstveniKarton = null;
                  oldZdravstveniKarton.RemoveUput(this);
               }
               if (value != null)
               {
                  this.zdravstveniKarton = value;
                  this.zdravstveniKarton.AddUput(this);
               }
            }
         }
      }
   
   }
}