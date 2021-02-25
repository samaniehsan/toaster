using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public class SlicedBread: IToastable
    {
        public TimeSpan JustRight { get; } = TimeSpan.FromMinutes(2);
        public TimeSpan MinimumTime { get; } = TimeSpan.FromMinutes(1);
        public TimeSpan MaxiumTime { get; } = TimeSpan.FromSeconds(3);
    }
}
