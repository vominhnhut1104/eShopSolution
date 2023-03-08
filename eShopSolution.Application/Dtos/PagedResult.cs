﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Dtos
{
    public class PagedResult<T>
    {
        public List<T> Iterm { get; set; }  

        public int TotalRecord { get; set; }

    } 
}
