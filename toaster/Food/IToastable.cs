using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public interface IToastable
    {
        public TimeSpan GetJustRight { get; }
        public TimeSpan GetMinimumTime { get; }
        public TimeSpan GetMaxiumTime { get; }
    }
}
