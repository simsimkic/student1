using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sims.Repository.Sequencer
{
    public interface ISequencer<T>
    {
        void Initialize(T initId);

        T GenerateId();
    }
}
