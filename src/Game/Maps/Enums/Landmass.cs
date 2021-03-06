﻿using System.Collections.Generic;

namespace MRobot.Civilization.Game.Maps.Enums
{
    public enum BasicLandmass
    {
        Pangaea,
        Continents,
        Random
    }

    public enum Landmass
    {
        Pangaea,
        LargeContinents,
        SmallContinents,
        Islands,
        Random
    }

    public enum LandmassAlt
    {
        Random,
        WideContinents,
        NarrowContinents,
        Islands,
        SmallIslands
    }

    static partial class EnumDefinitions
    {
        public static IDictionary<object, string> BasicLandmassAsDict
        {
            get { return EnumDefinitions.GetEnumAsDict(typeof(BasicLandmass)); }
        }

        public static IDictionary<object, string> LandmassAsDict
        {
            get
            {
                return new Dictionary<object, string>()
                {
                    { Landmass.Pangaea,             "Pangaea" },
                    { Landmass.LargeContinents,     "Large Continents" },
                    { Landmass.SmallContinents,     "Small Continents" },
                    { Landmass.Islands,             "Islands" },
                    { Landmass.Random,              "Random" }
                };
            }
        }

        public static IDictionary<object, string> LandmassAltAsDict
        {
            get
            {
                return new Dictionary<object, string>()
                {
                    { LandmassAlt.Random,           "Random" },
                    { LandmassAlt.WideContinents,   "Wide Continents" },
                    { LandmassAlt.NarrowContinents, "Narrow Continents" },
                    { LandmassAlt.Islands,          "Islands" },
                    { LandmassAlt.SmallIslands,     "Small Islands" }
                };
            }
        }
    }
}
