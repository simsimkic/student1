// File:    Dijagnoza.cs
// Created: 18 April, 2020 19:31:22
// Purpose: Definition of Class Dijagnoza

using System;

namespace Model
{
   public class Dijagnoza
   {
      private String opis;
      
      public System.Collections.ArrayList recept;
      
      /// <summary>
      /// Property for collection of Recept
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Recept
      {
         get
         {
            if (recept == null)
               recept = new System.Collections.ArrayList();
            return recept;
         }
         set
         {
            RemoveAllRecept();
            if (value != null)
            {
               foreach (Recept oRecept in value)
                  AddRecept(oRecept);
            }
         }
      }
      
      /// <summary>
      /// Add a new Recept in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRecept(Recept newRecept)
      {
         if (newRecept == null)
            return;
         if (this.recept == null)
            this.recept = new System.Collections.ArrayList();
         if (!this.recept.Contains(newRecept))
         {
            this.recept.Add(newRecept);
            newRecept.Dijagnoza = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Recept from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRecept(Recept oldRecept)
      {
         if (oldRecept == null)
            return;
         if (this.recept != null)
            if (this.recept.Contains(oldRecept))
            {
               this.recept.Remove(oldRecept);
               oldRecept.Dijagnoza = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Recept from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRecept()
      {
         if (recept != null)
         {
            System.Collections.ArrayList tmpRecept = new System.Collections.ArrayList();
            foreach (Recept oldRecept in recept)
               tmpRecept.Add(oldRecept);
            recept.Clear();
            foreach (Recept oldRecept in tmpRecept)
               oldRecept.Dijagnoza = null;
            tmpRecept.Clear();
         }
      }
      public Lekar lekar;
        private long v;

        public Dijagnoza(long v)
        {
            this.v = v;
        }

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
            if (this.lekar == null || !this.lekar.Equals(value))
            {
               if (this.lekar != null)
               {
                  Lekar oldLekar = this.lekar;
                  this.lekar = null;
                  oldLekar.RemoveDijagnoza(this);
               }
               if (value != null)
               {
                  this.lekar = value;
                  this.lekar.AddDijagnoza(this);
               }
            }
         }
      }
   
   }
}