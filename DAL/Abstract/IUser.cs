﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IUser:IGeneric<User>
    {
        Task<IEnumerable<User>> GetUserList();
    }
}
