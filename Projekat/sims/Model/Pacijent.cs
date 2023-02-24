// File:    Pacijent.cs
// Created: 18 April, 2020 18:32:00
// Purpose: Definition of Class Pacijent

using System;

namespace Model
{
   public class Pacijent : Korisnik
   {
      public Boolean BolnickoLecenje { get; set; }
      
      public long IdPacijenta { get; set; }


      public Pacijent(long idPacijenta)
      {
           IdPacijenta = idPacijenta;

      }
      
      public Pacijent(string email, string lozinka, string ime, string prezime, string jmbg, string adresa, Boolean bolnickoLecenje, long idPacijenta)
      {
           Email = email;
           Lozinka = lozinka;
           Ime = ime;
           Prezime = prezime;
           Jmbg = jmbg;
           Adresa = adresa;
           BolnickoLecenje = bolnickoLecenje;
           IdPacijenta = idPacijenta;

      }

      public long GetId() => IdPacijenta;

      public void SetId(long idPacijenta) => IdPacijenta = idPacijenta;

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
      
      public Pitanje PisiPitanje()
      {
         throw new NotImplementedException();
      }
      
      public Ocena[] ocena;
      public ZdravstveniKarton zdravstveniKarton;
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
         {
            this.termin.Add(newTermin);
            newTermin.Pacijent = this;
         }
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
            {
               this.termin.Remove(oldTermin);
               oldTermin.Pacijent = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Termin from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllTermin()
      {
         if (termin != null)
         {
            System.Collections.ArrayList tmpTermin = new System.Collections.ArrayList();
            foreach (Termin oldTermin in termin)
               tmpTermin.Add(oldTermin);
            termin.Clear();
            foreach (Termin oldTermin in tmpTermin)
               oldTermin.Pacijent = null;
            tmpTermin.Clear();
         }
      }
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
         {
            this.pitanje.Add(newPitanje);
            newPitanje.Pacijent = this;
         }
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
            {
               this.pitanje.Remove(oldPitanje);
               oldPitanje.Pacijent = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Pitanje from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllPitanje()
      {
         if (pitanje != null)
         {
            System.Collections.ArrayList tmpPitanje = new System.Collections.ArrayList();
            foreach (Pitanje oldPitanje in pitanje)
               tmpPitanje.Add(oldPitanje);
            pitanje.Clear();
            foreach (Pitanje oldPitanje in tmpPitanje)
               oldPitanje.Pacijent = null;
            tmpPitanje.Clear();
         }
      }
      public Lekar[] lekar;
   
   }
}