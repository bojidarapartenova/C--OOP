﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public abstract class BaseHero
    {
        protected BaseHero(string name, int power)
        {
            Name = name;
            Power = power;
        }

        public string Name { get; protected set; }
        public int Power { get; protected set; }

        public virtual string CastAbility()
        {
            return $"{GetType().Name} - {Name} ";
        }
    }
}
