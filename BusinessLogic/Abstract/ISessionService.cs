﻿using BusinessLogic.Dtos;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
    public interface ISessionService
    {
        Task<IEnumerable<SessionListDto>> GetSessionListAsync();
    }
}