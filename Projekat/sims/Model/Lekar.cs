// File:    Lekar.cs
// Created: 18 April, 2020 18:32:01
// Purpose: Definition of Class Lekar

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Lekar : Zaposleni, IIdentifiable<long>
   {
      public String Specijalizacija { get; set; }



        public Lekar(long idLekara)
        {
            idLekara = IdZaposlenog;

        }
        public Lekar(string email, string lozinka, string ime, string prezime, string jmbg, string adresa, string specijalizacija, long idZaposlenog, int plata)
        {
            Email = email;
            Lozinka = lozinka;
            Ime = ime;
            Prezime = prezime;
            Jmbg = jmbg;
            Adresa = adresa;
            Specijalizacija = specijalizacija;
            IdZaposlenog = idZaposlenog;
            Plata = plata;
        }

        public long GetId() => IdZaposlenog;

        public void SetId(long idLekara) => IdZaposlenog = idLekara;


        public Boolean ZakaziSledeciTermin()
      {
         throw new NotImplementedException();
      }
      
      public Boolean OdobriLek()
      {
         throw new NotImplementedException();
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
      public Termin[] termin;
      public System.Collections.ArrayList lek;
      
      /// <summary>
      /// Property for collection of Lek
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Lek
      {
         get
         {
            if (lek == null)
               lek = new System.Collections.ArrayList();
            return lek;
         }
         set
         {
            RemoveAllLek();
            if (value != null)
            {
               foreach (Lek oLek in value)
                  AddLek(oLek);
            }
         }
      }
      
      /// <summary>
      /// Add a new Lek in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddLek(Lek newLek)
      {
         if (newLek == null)
            return;
         if (this.lek == null)
            this.lek = new System.Collections.ArrayList();
         if (!this.lek.Contains(newLek))
            this.lek.Add(newLek);
      }
      
      /// <summary>
      /// Remove an existing Lek from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveLek(Lek oldLek)
      {
         if (oldLek == null)
            return;
         if (this.lek != null)
            if (this.lek.Contains(oldLek))
               this.lek.Remove(oldLek);
      }
      
      /// <summary>
      /// Remove all instances of Lek from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllLek()
      {
         if (lek != null)
            lek.Clear();
      }
      public System.Collections.ArrayList dijagnoza;
      
      /// <summary>
      /// Property for collection of Dijagnoza
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Dijagnoza
      {
         get
         {
            if (dijagnoza == null)
               dijagnoza = new System.Collections.ArrayList();
            return dijagnoza;
         }
         set
         {
            RemoveAllDijagnoza();
            if (value != null)
            {
               foreach (Dijagnoza oDijagnoza in value)
                  AddDijagnoza(oDijagnoza);
            }
         }
      }
      
      /// <summary>
      /// Add a new Dijagnoza in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddDijagnoza(Dijagnoza newDijagnoza)
      {
         if (newDijagnoza == null)
            return;
         if (this.dijagnoza == null)
            this.dijagnoza = new System.Collections.ArrayList();
         if (!this.dijagnoza.Contains(newDijagnoza))
         {
            this.dijagnoza.Add(newDijagnoza);
            newDijagnoza.Lekar = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Dijagnoza from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveDijagnoza(Dijagnoza oldDijagnoza)
      {
         if (oldDijagnoza == null)
            return;
         if (this.dijagnoza != null)
            if (this.dijagnoza.Contains(oldDijagnoza))
            {
               this.dijagnoza.Remove(oldDijagnoza);
               oldDijagnoza.Lekar = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Dijagnoza from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllDijagnoza()
      {
         if (dijagnoza != null)
         {
            System.Collections.ArrayList tmpDijagnoza = new System.Collections.ArrayList();
            foreach (Dijagnoza oldDijagnoza in dijagnoza)
               tmpDijagnoza.Add(oldDijagnoza);
            dijagnoza.Clear();
            foreach (Dijagnoza oldDijagnoza in tmpDijagnoza)
               oldDijagnoza.Lekar = null;
            tmpDijagnoza.Clear();
         }
      }
   
   }
}