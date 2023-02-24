// File:    Oprema.cs
// Created: 18 April, 2020 20:29:07
// Purpose: Definition of Class Oprema

using sims.Repository.Abstract;
using System;

namespace Model
{
   public class Oprema : IIdentifiable<long>
    {
        
        public string ImeOpreme { get; set; }
        public string TipOpreme { get; set; }
        public int KolicinaOpreme { get; set; }
        public long IdOpreme { get; set; }

        public Oprema(long idopr)
        {
            IdOpreme = idopr;

        }
        public Oprema(string ime, string tip, int kol, long id)
        {
            ImeOpreme = ime;
            TipOpreme = tip;
            KolicinaOpreme = kol;
            IdOpreme = id;
        }

        public long GetId() => IdOpreme;

        public void SetId(long idOpr) => IdOpreme = idOpr;

    }
}