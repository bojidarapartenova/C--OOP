﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public interface IBuyer
    {
        string Name { get; set; }
        int Food { get ; set ; }

        void BuyFood();
    }
}
