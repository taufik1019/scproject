using SC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Repositories.Interface
{
    public interface IMhsRepository
    {
        List<Mhs> Get();
        Mhs Get(int id);
        int Post(Mhs mhs);
        int Put(int id, Mhs mhs);
        int Delete(Mhs mhs);
    }
}
