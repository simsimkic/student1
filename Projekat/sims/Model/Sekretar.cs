// File:    Sekretar.cs
// Created: 18 April, 2020 18:32:01
// Purpose: Definition of Class Sekretar

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Sekretar : Zaposleni, IIdentifiable<long>
    {
        public Sekretar(long idSekretara)
        {
            IdZaposlenog = idSekretara;

        }
        public Sekretar(string email, string lozinka, string ime, string prezime, string jmbg, string adresa, long idZaposlenog, int plata)
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

        public void SetId(long idSekretara) => IdZaposlenog = idSekretara;
        public Boolean Zakazi()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Promeni()
      {
         throw new NotImplementedException();
      }
      
      public Boolean Otkazi()
      {
         throw new NotImplementedException();
      }
      
      public Boolean DeaktivacijaNalogaPacijenta()
      {
         throw new NotImplementedException();
      }
      
      public Boolean RegistracijaPacijenta()
      {
         throw new NotImplementedException();
      }
      
      public Boolean HitanSlucaj()
      {
         throw new NotImplementedException();
      }
      
      public String PisiObavestenje()
      {
         throw new NotImplementedException();
      }
      
     // public abstract Pitanje OdgovoriNaPitanje(string sadrzaj);
      
      //public abstract Boolean CitajPitanje();
      
      public System.Collections.ArrayList pitanje;
      
      /// <summary>
      /// Property for collection of Pitanje
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Pitanje
      {
         get
         {
            if (pitanje == null)
               pitanje = new System.Collections.ArrayList();
            return pitanje;
         }
         set
         {
            RemoveAllPitanje();
            if (value != null)
            {
               foreach (Pitanje oPitanje in value)
                  AddPitanje(oPitanje);
            }
         }
      }
      
      /// <summary>
      /// Add a new Pitanje in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPitanje(Pitanje newPitanje)
      {
         if (newPitanje == null)
            return;
         if (this.pitanje == null)
            this.pitanje = new System.Collections.ArrayList();
         if (!this.pitanje.Contains(newPitanje))
            this.pitanje.Add(newPitanje);
      }
      
      /// <summary>
      /// Remove an existing Pitanje from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePitanje(Pitanje oldPitanje)
      {
         if (oldPitanje == null)
            return;
         if (this.pitanje != null)
            if (this.pitanje.Contains(oldPitanje))
               this.pitanje.Remove(oldPitanje);
      }
      
      /// <summary>
      /// Remove all instances of Pitanje from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPitanje()
      {
         if (pitanje != null)
            pitanje.Clear();
      }
      public System.Collections.ArrayList pacijent;
      
      /// <summary>
      /// Property for collection of Pacijent
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Pacijent
      {
         get
         {
            if (pacijent == null)
               pacijent = new System.Collections.ArrayList();
            return pacijent;
         }
         set
         {
            RemoveAllPacijent();
            if (value != null)
            {
               foreach (Pacijent oPacijent in value)
                  AddPacijent(oPacijent);
            }
         }
      }
      
      /// <summary>
      /// Add a new Pacijent in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddPacijent(Pacijent newPacijent)
      {
         if (newPacijent == null)
            return;
         if (this.pacijent == null)
            this.pacijent = new System.Collections.ArrayList();
         if (!this.pacijent.Contains(newPacijent))
            this.pacijent.Add(newPacijent);
      }
      
      /// <summary>
      /// Remove an existing Pacijent from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemovePacijent(Pacijent oldPacijent)
      {
         if (oldPacijent == null)
            return;
         if (this.pacijent != null)
            if (this.pacijent.Contains(oldPacijent))
               this.pacijent.Remove(oldPacijent);
      }
      
      /// <summary>
      /// Remove all instances of Pacijent from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPacijent()
      {
         if (pacijent != null)
            pacijent.Clear();
      }
      public System.Collections.ArrayList termin;
      
      /// <summary>
      /// Property for collection of Termin
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Termin
      {
         get
         {
            if (termin == null)
               termin = new System.Collections.ArrayList();
            return termin;
         }
         set
         {
            RemoveAllTermin();
            if (value != null)
            {
               foreach (Termin oTermin in value)
                  AddTermin(oTermin);
            }
         }
      }
      
      /// <summary>
      /// Add a new Termin in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddTermin(Termin newTermin)
      {
         if (newTermin == null)
            return;
         if (this.termin == null)
            this.termin = new System.Collections.ArrayList();
         if (!this.termin.Contains(newTermin))
            this.termin.Add(newTermin);
      }
      
      /// <summary>
      /// Remove an existing Termin from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveTermin(Termin oldTermin)
      {
         if (oldTermin == null)
            return;
         if (this.termin != null)
            if (this.termin.Contains(oldTermin))
               this.termin.Remove(oldTermin);
      }
      
      /// <summary>
      /// Remove all instances of Termin from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllTermin()
      {
         if (termin != null)
            termin.Clear();
      }
   
   }
}