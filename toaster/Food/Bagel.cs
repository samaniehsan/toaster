using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public class Bagel : IToastable
    {
        public TimeSpan JustRight { get; } = TimeSpan.FromMinutes(10);
        public TimeSpan MinimumTime { get; } = TimeSpan.FromMinutes(5);
        public TimeSpan MaxiumTime { get; } = TimeSpan.FromMinutes(12);
    }
}
