using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibrary.Persisters
{
    public interface Persister <T>
    {
        void Persist(T objToPersist);
    }
}
