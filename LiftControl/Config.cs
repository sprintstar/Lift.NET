using System;
using System.Collections.Generic;
using System.Linq;
using static LiftControl.Config;

namespace LiftControl
{
    public class Config
    {
        public IList<ConfigShaft> Shafts { get; }

        public Config(params ConfigShaft[] shafts)
        {
            Shafts = shafts;
        }

        public class ConfigShaft
        {
            public IList<ConfigFloor> Floors { get; private set; }
            public string Name { get; private set; }

            public ConfigShaft(string name, IList<ConfigFloor> floors)
            {
                this.Name = name;
                this.Floors = floors;
            }
        }

        public class ConfigFloor
        {
            public int Level { get; internal set; }

            private ConfigFloor(int level)
            {
                Level = level;
            }

            public static IList<ConfigFloor> CreateRange(int from, int to)
            {
                return Enumerable
                    .Range(from, to - from)
                    .Select(f => new ConfigFloor(f))
                    .ToList();
            }
        }
    }
}
