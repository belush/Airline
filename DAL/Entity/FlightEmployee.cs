﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class FlightEmployee
    {
        public Flight Flight { get; set; }
        public Employee Employee { get; set; }
    }
}