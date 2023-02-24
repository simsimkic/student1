﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.CSV.Stream
{
    public interface ICSVStream<E>
    {
        void SaveAll(IEnumerable<E> entities);
        IEnumerable<E> ReadAll();
        void AppendToFile(E entity);
    }
}

