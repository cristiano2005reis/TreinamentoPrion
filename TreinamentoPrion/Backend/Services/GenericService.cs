﻿using Backend.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class GenericService<T> : IDisposable where T : class
    {
        private GenericRepository<T> repository;



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}