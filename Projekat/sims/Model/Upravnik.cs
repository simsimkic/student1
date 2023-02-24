// File:    Upravnik.cs
// Created: 18 April, 2020 18:32:02
// Purpose: Definition of Class Upravnik
using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Upravnik : Zaposleni, IIdentifiable<long>

   {
        public Upravnik(long idUpravnika)
        {
            IdZaposlenog = idUpravnika;

        }
        public Upravnik(string email, string lozinka, string ime, string prezime, string jmbg, string adresa, long idZaposlenog, int plata)
        {
            Email = email;
            Lozinka = lozinka;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Adresa = adresa;
            IdZaposlenog = idZaposlenog;
            Plata = plata;
        }

        public long GetId() => IdZaposlenog;

        public void SetId(long idUpravnika) => IdZaposlenog = idUpravnika;

      public Boolean RegistracijaZaposlenih()
      {
         throw new NotImplementedException();
      }
      
      public Boolean DeaktivacijaZaposlenih()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Renoviraj()
      {
         throw new NotImplementedException();
      }
      
      public String PisiObavestenje()
      {
         throw new NotImplementedException();
      }
      
      public Boolean PromeniRadnoVreme()
      {
         throw new NotImplementedException();
      }
      
      public Boolean PromeniPlatu()
      {
         throw new NotImplementedException();
      }
      
      public Ocena[] vidi;
      public System.Collections.ArrayList renoviranje;
      
      /// <summary>
      /// Property for collection of Renoviranje
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Renoviranje
      {
         get
         {
            if (renoviranje == null)
               renoviranje = new System.Collections.ArrayList();
            return renoviranje;
         }
         set
         {
            RemoveAllRenoviranje();
            if (value != null)
            {
               foreach (Renoviranje oRenoviranje in value)
                  AddRenoviranje(oRenoviranje);
            }
         }
      }
      
      /// <summary>
      /// Add a new Renoviranje in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRenoviranje(Renoviranje newRenoviranje)
      {
         if (newRenoviranje == null)
            return;
         if (this.renoviranje == null)
            this.renoviranje = new System.Collections.ArrayList();
         if (!this.renoviranje.Contains(newRenoviranje))
            this.renoviranje.Add(newRenoviranje);
      }
      
      /// <summary>
      /// Remove an existing Renoviranje from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRenoviranje(Renoviranje oldRenoviranje)
      {
         if (oldRenoviranje == null)
            return;
         if (this.renoviranje != null)
            if (this.renoviranje.Contains(oldRenoviranje))
               this.renoviranje.Remove(oldRenoviranje);
      }
      
      /// <summary>
      /// Remove all instances of Renoviranje from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRenoviranje()
      {
         if (renoviranje != null)
            renoviranje.Clear();
      }
      public System.Collections.ArrayList nabavka;
      
      /// <summary>
      /// Property for collection of Nabavka
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Nabavka
      {
         get
         {
            if (nabavka == null)
               nabavka = new System.Collections.ArrayList();
            return nabavka;
         }
         set
         {
            RemoveAllNabavka();
            if (value != null)
            {
               foreach (Nabavka oNabavka in value)
                  AddNabavka(oNabavka);
            }
         }
      }
      
      /// <summary>
      /// Add a new Nabavka in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddNabavka(Nabavka newNabavka)
      {
         if (newNabavka == null)
            return;
         if (this.nabavka == null)
            this.nabavka = new System.Collections.ArrayList();
         if (!this.nabavka.Contains(newNabavka))
            this.nabavka.Add(newNabavka);
      }
      
      /// <summary>
      /// Remove an existing Nabavka from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveNabavka(Nabavka oldNabavka)
      {
         if (oldNabavka == null)
            return;
         if (this.nabavka != null)
            if (this.nabavka.Contains(oldNabavka))
               this.nabavka.Remove(oldNabavka);
      }
      
      /// <summary>
      /// Remove all instances of Nabavka from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllNabavka()
      {
         if (nabavka != null)
            nabavka.Clear();
      }
      public Bolnica bolnica;
      public Obavestenja[] obavestenja;
   
   }
}