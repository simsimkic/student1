// File:    Bolnica.cs
// Created: 18 April, 2020 19:47:13
// Purpose: Definition of Class Bolnica
// test bolnica
// test upravnik merge

using System;

namespace Model
{
   public class Bolnica
   {
      private Bolnica()
      {
         throw new NotImplementedException();
      }
      
      private String ime;
      private String adresa;
      private static Bolnica instanca;
      
      public static Bolnica GetInstance()
      {
         throw new NotImplementedException();
      }
      
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
      public Upravnik upravnik;
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
      public Bolnica bolnicaB;
   
   }
}