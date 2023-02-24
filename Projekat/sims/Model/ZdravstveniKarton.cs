// File:    ZdravstveniKarton.cs
// Created: 18 April, 2020 19:31:07
// Purpose: Definition of Class ZdravstveniKarton

using System;

namespace Model
{
   public class ZdravstveniKarton
   {
      private String istorijaBolesti;
      private int brojKartona;
      
      public System.Collections.ArrayList uput;
      
      /// <summary>
      /// Property for collection of Uput
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Uput
      {
         get
         {
            if (uput == null)
               uput = new System.Collections.ArrayList();
            return uput;
         }
         set
         {
            RemoveAllUput();
            if (value != null)
            {
               foreach (Uput oUput in value)
                  AddUput(oUput);
            }
         }
      }
      
      /// <summary>
      /// Add a new Uput in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddUput(Uput newUput)
      {
         if (newUput == null)
            return;
         if (this.uput == null)
            this.uput = new System.Collections.ArrayList();
         if (!this.uput.Contains(newUput))
         {
            this.uput.Add(newUput);
            newUput.ZdravstveniKarton = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Uput from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveUput(Uput oldUput)
      {
         if (oldUput == null)
            return;
         if (this.uput != null)
            if (this.uput.Contains(oldUput))
            {
               this.uput.Remove(oldUput);
               oldUput.ZdravstveniKarton = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Uput from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllUput()
      {
         if (uput != null)
         {
            System.Collections.ArrayList tmpUput = new System.Collections.ArrayList();
            foreach (Uput oldUput in uput)
               tmpUput.Add(oldUput);
            uput.Clear();
            foreach (Uput oldUput in tmpUput)
               oldUput.ZdravstveniKarton = null;
            tmpUput.Clear();
         }
      }
      public Dijagnoza[] dijagnoza;
      public Pacijent pacijent;
   
   }
}