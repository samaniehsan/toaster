using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Device
{
    public class ToasterSpecification
    {
        public uint SlotCount { get; private set; }
        public uint LeverCount { get; private set; }
        public TimeSpan MaxTime { get; set; } = TimeSpan.FromMinutes(15);
        private Dictionary<uint,  uint> LevelToSlotMapping { get; set; }
    }
}
