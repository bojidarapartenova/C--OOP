﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot: Identity
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id= id;
        }

        public string Model { get; set; }
    }
}
