using System;
using System.Collections.Generic;
using System.Text;

namespace Toaster.Food
{
    public interface IToastable
    {
        public TimeSpan JustRight { get; }
        public TimeSpan MinimumTime { get; }
        public TimeSpan MaxiumTime { get; }
    }
}
