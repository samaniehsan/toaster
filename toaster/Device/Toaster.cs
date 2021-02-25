using System;
using System.Collections.Generic;
using System.Text;
using Toaster.Food;

namespace Toaster.Device
{

    public class Toaster
    {
        private class LeverStatusInfo
        {
            public DateTime BeginTime { get; set; }
            public TimeSpan Duration { get; set; }
        }

        LeverStatusInfo [] LeversStatus { get; set; }
        private ToasterSpecification Specificaiton { get; set; }
        public Toaster(ToasterSpecification specification)
        {
            this.Specificaiton = specification;
            LeversStatus = new LeverStatusInfo[this.Specificaiton.LeverCount];
        }


        private void InitStatus(uint lever)
        {
            if (LeversStatus[lever] == null)
            {
                LeversStatus[lever] = new LeverStatusInfo();
            }
        }
        public void SetLeverItem(uint lever, IToastable item)
        {
            InitStatus(lever);
            LeversStatus[lever].Duration = item.JustRight;
        }
        public void SetDuration(uint lever, TimeSpan duration)
        {
            if(this.Specificaiton.MaxDuration > duration)
            {
                throw new Exception($"Toaster can only run for {Specificaiton.MaxTime}");
            }
            InitStatus(lever);
            LeversStatus[lever].Duration = duration;
        }
        public void Start(uint lever)
        {
            InitStatus(lever);
            LeversStatus[lever].BeginTime = DateTime.UtcNow;
            if(this.Specificaiton.LeverToSlotMapping.TryGetValue(lever, out uint[] slots))
            {
                foreach(var slot in slots)
                {
                    TurnOnSlots(slot);
                }
            }
        }
        public void Stop(uint lever)
        {
            if (LeversStatus[lever] == null)
            {
                throw new Exception("was never started");
            }
            if (this.Specificaiton.LeverToSlotMapping.TryGetValue(lever, out uint[] slots))
            {
                foreach (var slot in slots)
                {
                    TurnOnSlots(slot);
                }
            }
            LeversStatus[lever] = null;
        }
        public void StopAll()
        {

            //reset to beginging
            LeversStatus = new LeverStatusInfo[this.Specificaiton.LeverCount];
        }

        public void TurnOnSlots(uint slot)
        {
            //todo
        }
        public void TurnOffSlots(uint slot)
        {
            //todo
        }
    }
}
