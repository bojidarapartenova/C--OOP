﻿using MilitaryElite.Interfaces;

namespace MilitaryElite.Models;

public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        Corps = TryParseCorps(corps);
    }

    public Corps Corps { get; private set; }

    public Corps TryParseCorps(string corpsStr)
    {
        bool parsed = Enum.TryParse(corpsStr, out Corps corps);
        if (!parsed)
        {
            throw new ArgumentException("Invalid corps!");
        }

        return corps;
    }
}
