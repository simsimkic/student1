// File:    Lek.cs
// Created: 18 April, 2020 20:49:17
// Purpose: Definition of Class Lek

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Lek : IIdentifiable<long>
   {
      public String Naziv { get; set; }
      public long IdLeka { get; set; }
      public String Proizvodjac { get; set; }
      public Boolean Odobren { get; set; }

        public Lek(long idLeka)
        {
            IdLeka = idLeka;

        }
        public Lek(string naziv, long idLeka, string proizvodjac, Boolean odobren)
        {
            Naziv = naziv;
            IdLeka = idLeka;
            Proizvodjac = proizvodjac;
            Odobren = odobren;
        }

        public long GetId() => IdLeka;

        public void SetId(long idLeka) => IdLeka = idLeka;

        public System.Collections.ArrayList alternativa;
      
      /// <summary>
      /// Property for collection of Lek
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Alternativa
      {
         get
         {
            if (alternativa == null)
               alternativa = new System.Collections.ArrayList();
            return alternativa;
         }
         set
         {
            RemoveAllAlternativa();
            if (value != null)
            {
               foreach (Lek oLek in value)
                  AddAlternativa(oLek);
            }
         }
      }
      
      /// <summary>
      /// Add a new Lek in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAlternativa(Lek newLek)
      {
         if (newLek == null)
            return;
         if (this.alternativa == null)
            this.alternativa = new System.Collections.ArrayList();
         if (!this.alternativa.Contains(newLek))
            this.alternativa.Add(newLek);
      }
      
      /// <summary>
      /// Remove an existing Lek from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAlternativa(Lek oldLek)
      {
         if (oldLek == null)
            return;
         if (this.alternativa != null)
            if (this.alternativa.Contains(oldLek))
               this.alternativa.Remove(oldLek);
      }
      
      /// <summary>
      /// Remove all instances of Lek from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAlternativa()
      {
         if (alternativa != null)
            alternativa.Clear();
      }

 

        public Lekar[] lekar;
   
   }
}