﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
    }
}