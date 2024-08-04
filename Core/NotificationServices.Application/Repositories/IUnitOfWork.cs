﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationServices.Application.Repositories
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();

    }
}
