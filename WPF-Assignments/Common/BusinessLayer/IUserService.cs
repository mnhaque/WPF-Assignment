﻿using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.BusinessLayer
{
    public interface IUserService
    {
        bool SaveUser(User user);
    }
}
