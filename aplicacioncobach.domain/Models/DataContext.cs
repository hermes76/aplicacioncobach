﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacioncobach.domain.Models
{
    public class DataContext :DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }      
    }
}
