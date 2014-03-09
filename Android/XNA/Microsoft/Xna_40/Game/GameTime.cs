using System;
using Microsoft.SPOT;

namespace Microsoft.Xna.Framework
{
    public class GameTime
    {
        public TimeSpan ElapsedGameTime { get; internal set; }
        public TimeSpan ElapsedRealTime { get; internal set; }
        public bool IsRunningSlowly { get; internal set; }
        public TimeSpan TotalGameTime { get; internal set; }
        public TimeSpan TotalRealTime { get; internal set; }

        public GameTime()
        {
        }

        public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime)
        {
            this.TotalRealTime = totalRealTime;
            this.ElapsedRealTime = elapsedGameTime;
            this.TotalGameTime = totalGameTime;
            this.ElapsedGameTime = elapsedGameTime;
        }

        public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly)
            : this(totalRealTime, elapsedRealTime, totalGameTime, elapsedGameTime)
        {
            this.IsRunningSlowly = isRunningSlowly;
        }


    }
}
