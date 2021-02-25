using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public  class DefaultItem : IToastable
    {
        public TimeSpan JustRight { get; } = TimeSpan.FromMinutes(1);
        public TimeSpan MinimumTime { get; } = TimeSpan.FromSeconds(30);
        public TimeSpan MaxiumTime { get; } = TimeSpan.FromMinutes(2);
    }
}
