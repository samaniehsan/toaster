using System;
using System.Collections.Generic;
using System.Text;

namespace toaster
{
    public class Toaster
    {
        public uint SlotCount { get; private set; }
        public uint LeverCount { get; private set; }

        private Dictionary<uint,  uint> LevelToSlotMapping { get; set; }

        public void SettSlotItem(uint slot, Item item)
        {

        }
        public void SetDuration(uint lever, uint duration)
        {

        }
        public void Start(uint lever)
        {

        }
        public void Stop(uint lever)
        {

        }
        public void Stop()
        {

        }
    }
}
