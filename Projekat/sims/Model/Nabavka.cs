// File:    Nabavka.cs
// Created: 18 April, 2020 20:45:50
// Purpose: Definition of Class Nabavka

using System;

namespace Model
{
   public class Nabavka
   {
      private DateTime datum;
      private double kolicina;
      
      public Boolean Poruci()
      {
         throw new NotImplementedException();
      }
      
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
      public System.Collections.ArrayList oprema;
      
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
   
   }
}