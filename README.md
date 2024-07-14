### Acceleration Velocity Jerk Indicator

This C# indicator calculates Velocity, Acceleration, and Jerk based on historical price data in cAlgo trading platform. Initially created in pinescript but converted to C# for usage in pinescript for a client.

- **Velocity**: Measures the rate of change of price over a specified period.
- **Acceleration**: Indicates how quickly the Velocity is changing.
- **Jerk**: Represents the rate of change of Acceleration.

#### Parameters
- **Length**: Defines the period length for calculating Velocity, Acceleration, and Jerk.

#### Outputs
- **Velocity**: Displayed as a histogram in red.
- **Acceleration**: Displayed as a histogram in cyan.
- **Jerk**: Displayed as a histogram in purple.
