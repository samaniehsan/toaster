using System;
using System.Collections.Generic;
using System.Text;
using Toaster.Food;

namespace Toaster.Device
{
    public class Toaster
    {
        private ToasterSpecification Specificaiton { get; set; }
        public Toaster(ToasterSpecification specification)
        {
            this.Specificaiton = specification;
        }

        public void SettSlotItem(uint slot, IToastable item)
        {

        }
        public void SetDuration(uint lever, TimeSpan duration)
        {

        }
        public void Start(uint lever)
        {

        }
        public void Stop(uint lever)
        {

        }
        public void StopAll()
        {

        }
    }
}
