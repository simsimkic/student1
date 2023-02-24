// File:    Renoviranje.cs
// Created: 18 April, 2020 20:04:36
// Purpose: Definition of Class Renoviranje

using System;

namespace Model
{
   public class Renoviranje
   {
      private TipRenoviranja tipRenoviranja;
      private DateTime vremePocetka;
      private DateTime vremeZavrsetka;
      private int id;
      
      public System.Collections.ArrayList prostorija;
      
      /// <summary>
      /// Property for collection of Prostorija
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Prostorija
      {
         get
         {
            if (prostorija == null)
               prostorija = new System.Collections.ArrayList();
            return prostorija;
         }
         set
         {
            RemoveAllProstorija();
            if (value != null)
            {
               foreach (Prostorija oProstorija in value)
                  AddProstorija(oProstorija);
            }
         }
      }
      
      /// <summary>
      /// Add a new Prostorija in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddProstorija(Prostorija newProstorija)
      {
         if (newProstorija == null)
            return;
         if (this.prostorija == null)
            this.prostorija = new System.Collections.ArrayList();
         if (!this.prostorija.Contains(newProstorija))
            this.prostorija.Add(newProstorija);
      }
      
      /// <summary>
      /// Remove an existing Prostorija from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveProstorija(Prostorija oldProstorija)
      {
         if (oldProstorija == null)
            return;
         if (this.prostorija != null)
            if (this.prostorija.Contains(oldProstorija))
               this.prostorija.Remove(oldProstorija);
      }
      
      /// <summary>
      /// Remove all instances of Prostorija from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllProstorija()
      {
         if (prostorija != null)
            prostorija.Clear();
      }
   
   }
}