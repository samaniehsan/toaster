using System;
using System.Collections.Generic;
using System.Text;

namespace toaster
{
    public class Bagel : IToastable
    {
        public TimeSpan GetJustRight { get; } = TimeSpan.FromMinutes(10);
        public TimeSpan GetMinimumTime { get; } = TimeSpan.FromMinutes(5);
        public TimeSpan GetMaxiumTime { get; } = TimeSpan.FromMinutes(12);
    }
}
