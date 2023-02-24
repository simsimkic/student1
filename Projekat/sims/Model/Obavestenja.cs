// File:    Obavestenja.cs
// Created: 20 April, 2020 17:42:40
// Purpose: Definition of Class Obavestenja

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Obavestenja : IIdentifiable<long>
    {
      public string Sadrzaj { get; set; }
      public string Naslov { get; set; }
      public string Posiljalac { get; set; }
      public long IdObavestenja { get; set; }

        public Obavestenja(long idObavestenja)
        {
            IdObavestenja = idObavestenja;

        }
        public Obavestenja(string sadrzaj, string naslov, string posiljalac, long idObavestenja)
        {
            Sadrzaj = sadrzaj;
            Naslov = naslov;
            Posiljalac = posiljalac;
            IdObavestenja = idObavestenja;
        }

        public long GetId() => IdObavestenja;

        public void SetId(long idObavestenja) => IdObavestenja = idObavestenja;


        public Boolean CitajObavestenje()
        {
         throw new NotImplementedException();
        }
      
      public System.Collections.ArrayList zaposleni;
      
      /// <summary>
      /// Property for collection of Zaposleni
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Zaposleni
      {
         get
         {
            if (zaposleni == null)
               zaposleni = new System.Collections.ArrayList();
            return zaposleni;
         }
         set
         {
            RemoveAllZaposleni();
            if (value != null)
            {
               foreach (Zaposleni oZaposleni in value)
                  AddZaposleni(oZaposleni);
            }
         }
      }
      
      /// <summary>
      /// Add a new Zaposleni in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddZaposleni(Zaposleni newZaposleni)
      {
         if (newZaposleni == null)
            return;
         if (this.zaposleni == null)
            this.zaposleni = new System.Collections.ArrayList();
         if (!this.zaposleni.Contains(newZaposleni))
            this.zaposleni.Add(newZaposleni);
      }
      
      /// <summary>
      /// Remove an existing Zaposleni from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveZaposleni(Zaposleni oldZaposleni)
      {
         if (oldZaposleni == null)
            return;
         if (this.zaposleni != null)
            if (this.zaposleni.Contains(oldZaposleni))
               this.zaposleni.Remove(oldZaposleni);
      }
      
      /// <summary>
      /// Remove all instances of Zaposleni from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllZaposleni()
      {
         if (zaposleni != null)
            zaposleni.Clear();
      }


    }
}