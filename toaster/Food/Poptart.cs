using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public class Poptart : IToastable
    {
        public TimeSpan JustRight { get; } = TimeSpan.FromMinutes(1);
        public TimeSpan MinimumTime { get; } = TimeSpan.FromSeconds(30);
        public TimeSpan MaxiumTime { get; } = TimeSpan.FromSeconds(90);
    }
}
