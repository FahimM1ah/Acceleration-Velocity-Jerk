using System;
using cAlgo.API;
using cAlgo.API.Collections;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;

namespace cAlgo
{
    [Indicator(IsOverlay = false, TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class AccelerationVelocityJerk : Indicator
    {
        [Parameter("Length", DefaultValue = 50)]
        public int Length { get; set; }

        [Output("Velocity", LineColor = "Red", PlotType = PlotType.Histogram, Thickness = 2)]
        public IndicatorDataSeries Velocity { get; set; }

        [Output("Acceleration", LineColor = "Cyan", PlotType = PlotType.Histogram, Thickness = 2)]
        public IndicatorDataSeries Acceleration { get; set; }

        [Output("Jerk", LineColor = "Purple", PlotType = PlotType.Histogram, Thickness = 2)]
        public IndicatorDataSeries Jerk { get; set; }

        protected override void Initialize()
        {
            // Initialize and create nested indicator components if needed
        }

        public override void Calculate(int index)
        {
            if (index < Length * 3)
                return;

            // Calculate Velocity
            double velocity = Bars.ClosePrices[index] - Bars.ClosePrices[index - Length];
            Velocity[index] = velocity;

            // Calculate Acceleration
            double acceleration = Velocity[index] - Velocity[index - Length];
            Acceleration[index] = acceleration;

            // Calculate Jerk
            double jerk = Acceleration[index] - Acceleration[index - Length];
            Jerk[index] = jerk;
        }
    }
}