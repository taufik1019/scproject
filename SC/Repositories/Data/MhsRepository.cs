using SC.Context;
using SC.Models;
using SC.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Repositories.Data
{
    public class MhsRepository : IMhsRepository
    {
        MyContext myContext;

        public MhsRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public int Delete(Mhs mhs)
        {
            throw new NotImplementedException();
        }

        public List<Mhs> Get()
        {
            var data = myContext.Mhs.ToList();
            return data;
        }

        public Mhs Get(int id)
        {
            var data = myContext.Mhs.Where(x => x.Id.Equals(id)).FirstOrDefault();
            return data;
        }

        public int Post(Mhs mhs)
        {
            myContext.Mhs.Add(mhs);
            var result = myContext.SaveChanges();
            if (result > 0)
                return result;
            return 0;
        }

        public int Put(int id, Mhs mhs)
        {
            var data = myContext.Mhs.Find(id);
            data.Alamat = mhs.Alamat;
            data.Image = mhs.Image;
            myContext.Mhs.Update(data);
            var result = myContext.SaveChanges();
            return result;
        }

        public int Remove(Mhs mhs)
        {
            myContext.Mhs.Remove(mhs);
            var result = myContext.SaveChanges();
            return result;
        }
    }
}
