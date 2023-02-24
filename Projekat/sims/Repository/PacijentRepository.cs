// File:    PacijentRepository.cs
// Created: 27 May, 2020 16:34:35
// Purpose: Definition of Class PacijentRepository

using Model;
using sims.Repository.Abstract;
using sims.Repository.CSV;
using sims.Repository.CSV.Stream;
using sims.Repository.Sequencer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Repository
{
    public class PacijentRepository : CSVRepository<Pacijent, long>,
         IPacijentRepository,
        IEagerCSVRepository<Pacijent, long>
    {
        private const string ENTITY_NAME = "Pacijent";
        public PacijentRepository(string entityName, ICSVStream<Pacijent> stream, ISequencer<long> sequencer) 
            : base(ENTITY_NAME, stream, sequencer)
        {
        }
        public Pacijent SetPacijent(Pacijent pacijent)
        {
            throw new NotImplementedException();
        }

        public Pacijent GetPacijentByJMBG(string jmbgPacijenta)
        {
            throw new NotImplementedException();
        }

        public bool RemovePacijent(Pacijent pacijent)
        {
            if (pacijent != null)
            {
                Delete(pacijent);
                return true;
            }
            else
                return false;
        }
        public Pacijent AddPacijent(Pacijent pacijent)
        {
            if (IsPacijentIDUnique(pacijent.IdPacijenta))
                return base.Create(pacijent);
            else
                throw new Exception();
        }
        private bool IsPacijentIDUnique(long pacijentID)
        => GetPacijentByID(pacijentID) == null;

        private Pacijent GetPacijentByID(long pacijentID)
        => _stream.ReadAll().SingleOrDefault(pacijent => pacijent.Equals(pacijentID));

        public Pacijent GetEager(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pacijent> GetAllEager()
        {
            throw new NotImplementedException();
        }

    }
}