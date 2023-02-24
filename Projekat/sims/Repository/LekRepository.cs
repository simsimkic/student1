// File:    LekRepository.cs
// Created: 27 May, 2020 17:04:10
// Purpose: Definition of Class LekRepository

using Model;
using sims.Repository.Abstract;
using sims.Repository.CSV;
using sims.Repository.CSV.Stream;
using sims.Repository.Sequencer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Repository
{
    public class LekRepository : CSVRepository<Lek, long>,
          ILekRepository,
         IEagerCSVRepository<Pacijent, long>
    {
        private const string ENTITY_NAME = "Lek";
        public LekRepository(string entityName, ICSVStream<Lek> stream, ISequencer<long> sequencer) 
            : base(ENTITY_NAME, stream, sequencer)
        {
        }

        public bool RemoveLek(Lek lek)
        {
            if (lek != null)
            {
                Delete(lek);
                return true;
            }
            else
                return false;
        }
        public new Lek Create(Lek lek)
        {
            if (IsLekIdUnique(lek.IdLeka))
                return base.Create(lek);
            else
                throw new Exception();
        }

        private bool IsLekIdUnique(long lekId)
           => GetLekById(lekId) == null;

        private Lek GetLekById(long lekID)
            => _stream.ReadAll().SingleOrDefault(lek => lek.Equals(lekID));

        public IEnumerable<Pacijent> GetAllEager()
        {
            throw new NotImplementedException();
        }

        public Pacijent GetEager(long id)
        {
            throw new NotImplementedException();
        }
    }
}