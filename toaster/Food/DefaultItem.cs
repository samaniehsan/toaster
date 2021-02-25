using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public  class DefaultItem : IToastable
    {
        public TimeSpan GetJustRight { get; } = TimeSpan.FromMinutes(1);
        public TimeSpan GetMinimumTime { get; } = TimeSpan.FromSeconds(30);
        public TimeSpan GetMaxiumTime { get; } = TimeSpan.FromMinutes(2);
    }
}
