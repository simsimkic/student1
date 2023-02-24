// File:    Recept.cs
// Created: 18 April, 2020 19:31:39
// Purpose: Definition of Class Recept

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Recept : IIdentifiable<long>
   {
      public string ImeLeka { get; set; }
        public long IdRecepta { get; set; }
        public string Terapija { get; set; }

        public Dijagnoza _Dijagnoza;
      
      /// <summary>
      /// Property for Dijagnoza
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Dijagnoza Dijagnoza
      {
         get
         {
            return _Dijagnoza;
         }
         set
         {
            if (this._Dijagnoza == null || !this._Dijagnoza.Equals(value))
            {
               if (this._Dijagnoza != null)
               {
                  Dijagnoza oldDijagnoza = this._Dijagnoza;
                  this._Dijagnoza = null;
                  oldDijagnoza.RemoveRecept(this);
               }
               if (value != null)
               {
                  this._Dijagnoza = value;
                  this._Dijagnoza.AddRecept(this);
               }
            }
         }
      }
        public Recept(long idRec)
        {
            IdRecepta = idRec; 

        }
        public Recept(string imeLeka, long idRecepta, string terapija, Dijagnoza dijagnoza)
        {
            ImeLeka = imeLeka;
            IdRecepta = idRecepta;
            Terapija = terapija;
            _Dijagnoza = dijagnoza;
        }

        public long GetId() => IdRecepta;

        public void SetId(long idRecepta) => IdRecepta = idRecepta;
    }
}