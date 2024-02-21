﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.DI.ComputerComponent
{
    public interface IGraphicAPI : IProduct
    {
        string Name { get; set; }
        double Version { get; set; }
    }
}