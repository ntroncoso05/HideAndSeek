using System;
using System.Collections.Generic;
using System.Text;

namespace HideAndSeekTests
{
    public class MockRandom : Random
    {
        public int ValueToReturn { get; set; } = 0;
        public override int Next() => ValueToReturn;
        public override int Next(int maxValue) => ValueToReturn;
        public override int Next(int minValue, int maxValue) => ValueToReturn;
    }
}
