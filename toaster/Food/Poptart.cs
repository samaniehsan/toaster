using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public class Poptart : IToastable
    {
        public TimeSpan GetJustRight { get; } = TimeSpan.FromMinutes(1);
        public TimeSpan GetMinimumTime { get; } = TimeSpan.FromSeconds(30);
        public TimeSpan GetMaxiumTime { get; } = TimeSpan.FromSeconds(90);
    }
}
