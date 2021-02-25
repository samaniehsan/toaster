using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Device
{
    public class ToasterSpecification
    {
        public uint SlotCount { get; private set; }
        public uint LeverCount { get; private set; }
        public TimeSpan MaxDuration { get; set; } = TimeSpan.FromMinutes(15);
        public Dictionary<uint,  uint[]> LeverToSlotMapping { get; private set; }
    }
}
