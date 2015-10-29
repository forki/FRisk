(*** hide ***)
// This block of code is omitted in the generated HTML documentation. Use 
// it to define helpers that you do not want to show in the documentation.
#I "../../bin"

(**
Welcome to FRisk
========================

Pronounced 'F Risk'.  It means F(orgotten) Risk.  It is basic. 

*)

(**
Black Scholes
----------

In order to develop any theoretical option pricing model the following are required:

1. Propose a series of possible prices at expiration for the underlying contract.
2. Assign an appropriate probability to each of those prices.
3. Maintain an arbitrage free underlying market.  Arbitrage free means that no profit can be made by either buying or selling a contract, all credits and debits, including the expected return must exactly cancel out.
4. From the prices and probabilities in steps 1-3 calculate the expected return for the option.
5. From the option's expected return deduct the carrying costs.

In 1973 Fischer Black and Myron Scholes introduced the first practical theoretical pricing model for options.  There have since been variations and those that fall under the Black-Scholes umbrella appear below:

* 1973 Black Scholes original.  For evaluating European options on non-dividend paying stocks only.
* 1973 Black and Scholes added a dividend component.
* 1976 Black modified the formula for evaluation options on futures contracts.
* 1983 Mark Garman and Steven Kohlhagen modified the formula for evaluation options on foreign currencies.

As previously stated these all fall under the umbrella of the Black Scholes option pricing model.
In order to calculate an option's theoretical value using Black-Scholes the following 5 minimum characteristics are required to be known:

1. The options's exercise price
2. The amount of time remaining until expiry
3. The current price of the underlying contract
4. The risk-free interest rate over the life of the option
5. The volatility of the underlying contract

The following assumptions are also important for the Black Scholes theoretical pricing model:

1. The market is _frictionless_.  In a frictionless market we assume:
        
        1. Traders can freely buy or sell the underlying contract with no restrictions
        2. All traders can borrow and lend money at the same rate
        3. Transaction costs are zero
        4. There are no tax considerations

The two most common considerations in a financial investment are the expected return and the carrying costs.



*)
