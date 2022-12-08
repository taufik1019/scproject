﻿using SC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Repositories.Interface
{
    public interface IKeluhanRepository
    {
        List<Keluhan> Get();
        Keluhan Get(int id);
        int Post(Keluhan keluhan);
        int Put(int id, Keluhan keluhan);
        int Delete(Keluhan keluhan);

    }
}
