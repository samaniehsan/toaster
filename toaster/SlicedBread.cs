using System;
using System.Collections.Generic;
using System.Text;

namespace toaster
{
    public class SlicedBread: IToastable
    {
        public TimeSpan GetJustRight { get; } = TimeSpan.FromMinutes(2);
        public TimeSpan GetMinimumTime { get; } = TimeSpan.FromMinutes(1);
        public TimeSpan GetMaxiumTime { get; } = TimeSpan.FromSeconds(3);
    }
}
