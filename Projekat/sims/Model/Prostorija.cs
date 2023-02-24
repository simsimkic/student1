// File:    Prostorija.cs
// Created: 18 April, 2020 19:52:57
// Purpose: Definition of Class Prostorija

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Prostorija : IIdentifiable<long>
    {
          public long IdProstorije { get; set; }
          public string TipProstorije { get; set; }
          public string Stanje { get; set; }

          public System.Collections.ArrayList oprema;

        public Prostorija(long idProstorije)
        {
            IdProstorije = idProstorije;

        }

        public Prostorija(long idProstorije, string tipProstorije, string stanje)
        {
            IdProstorije = idProstorije;
            TipProstorije = tipProstorije;
            Stanje = stanje;
        }

        /// <summary>
        /// Property for collection of Oprema
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Oprema
      {
         get
         {
            if (oprema == null)
               oprema = new System.Collections.ArrayList();
            return oprema;
         }
         set
         {
            RemoveAllOprema();
            if (value != null)
            {
               foreach (Oprema oOprema in value)
                  AddOprema(oOprema);
            }
         }
      }
      
      /// <summary>
      /// Add a new Oprema in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddOprema(Oprema newOprema)
      {
         if (newOprema == null)
            return;
         if (this.oprema == null)
            this.oprema = new System.Collections.ArrayList();
         if (!this.oprema.Contains(newOprema))
            this.oprema.Add(newOprema);
      }
      
      /// <summary>
      /// Remove an existing Oprema from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveOprema(Oprema oldOprema)
      {
         if (oldOprema == null)
            return;
         if (this.oprema != null)
            if (this.oprema.Contains(oldOprema))
               this.oprema.Remove(oldOprema);
      }
      
      /// <summary>
      /// Remove all instances of Oprema from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllOprema()
      {
         if (oprema != null)
            oprema.Clear();
      }

        public long GetId()
        {
            throw new NotImplementedException();
        }

        public void SetId(long id)
        {
            throw new NotImplementedException();
        }

        public Termin[] termin;
   
   }
}