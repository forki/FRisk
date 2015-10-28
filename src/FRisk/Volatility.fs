namespace FRisk

/// This is the volatility module which contains functions to calculate volatility and related measures
///
module Volatility = 
  
  /// Returns the log returns given an array of prices (presumed)
  ///
  /// ## Parameters
  ///  - `prices` - an array of prices, presumed to be regularly spaced but it doesn't really matter for this function
  let logReturns (prices : double[]) = 
        prices
            |> Array.toSeq
            |> Seq.skip(1)
            |> Seq.mapi(fun i p -> log(p / prices.[i]))     // 1. log returns
            |> Seq.toArray

  /// Returns the standard deviation of an array of levels
  ///
  /// ## Parameters
  ///  - `levels` - an array of levels, possibly returns, possibly prices
  let standardDeviation (levels : float[]) = 
    
    let meanReturn = Array.average levels // 1. mean of the levels
    
    // I know I could do this more discretely but I am spelling it out so I don't forget
    let squaredDeviations = 
        levels
            |> Seq.map(fun r -> r - meanReturn)     // 2. deviation from mean
            |> Seq.map(fun d -> d * d)  // 3. squared deviation
    
    let sumSquaredDeviations = Seq.sum squaredDeviations     // 4. sum squared deviations
    sqrt (sumSquaredDeviations / float (Seq.length levels))     // 5. the square root of the sum of the squared deviations divided by the number of levels in other words the square root of the average squared deviation

  /// Returns the periodic volatility for some standard deviation
  /// It is presumed to scale the daily standard deviation but it is up to the caller to ensure this.
  ///
  /// ## Parameters
  ///  - `stdev` - the standard deviation of some collection of levels, presumed to be daily returns
  ///  - `periodDays' - the number of trading days in the period you want to convert to, mostly this is annualized and it will be some number near to 252
  let periodicVolatility (stdev : float) (periodDays : double) = 
    stdev * sqrt periodDays     // 

