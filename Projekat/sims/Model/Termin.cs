// File:    Termin.cs
// Created: 18 April, 2020 19:03:45
// Purpose: Definition of Class Termin

using sims.Repository.Abstract;
using System;
using System.Windows.Controls;

namespace Model
{
   public class Termin : IIdentifiable<long>
   {
      public string TipTermina { get; set; }
      public DateTime VremeTermina { get; set; }
      public Boolean Hitno { get; set; }
      public string StanjeTermina { get; set; }
      public long IdTermina { get; set; }
      public Prostorija _Prostorija { get; set; }
      public Lekar _Lekar { get; set; }
      public Pacijent _Pacijent { get; set; }

        public Termin(long idTermina)
        {
            IdTermina = idTermina;
        }
        public Termin(string tipTermina, DateTime vremeTermina, Boolean hitno, string stanjeTermina, long idTermina, Prostorija prostorija, Lekar lekar, Pacijent pacijent)
        {
            TipTermina = tipTermina;
            VremeTermina = vremeTermina;
            Hitno = hitno;
            StanjeTermina = stanjeTermina;
            IdTermina = idTermina;
            _Prostorija = prostorija;
            _Lekar = lekar;
            _Pacijent = pacijent;
        }

        public long GetId() => IdTermina;

        public void SetId(long idRecepta) => IdTermina = IdTermina;

        public Boolean ZakazivanjeTermin()
      {
         throw new NotImplementedException();
      }

 


        /// <summary>
        /// Property for Pacijent
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Pacijent Pacijent
      {
         get
         {
            return _Pacijent;
         }
         set
         {
            if (this._Pacijent == null || !this._Pacijent.Equals(value))
            {
               if (this._Pacijent != null)
               {
                  Pacijent oldPacijent = this._Pacijent;
                  this._Pacijent = null;
                  oldPacijent.RemoveTermin(this);
               }
               if (value != null)
               {
                  this._Pacijent = value;
                  this._Pacijent.AddTermin(this);
               }
            }
         }
      }
   
   }
}