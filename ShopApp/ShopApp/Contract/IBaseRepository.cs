﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp.Utils;

namespace ShopApp.Contract
{
    public interface IBaseRepository<T>
    {
        T Get(object id);
        List<T> GetAll();
        ErrorCode Create(T t,out String errorMsg);
        ErrorCode Update(object id,T t, out String errorMsg);
        ErrorCode Delete(object id, out String errorMsg);
    }
}
