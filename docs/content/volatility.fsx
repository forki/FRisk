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
Volatility
----------

This module contains functions regarding historic volatility.

In order to calculate volatility asset returns are required.  Asset returns are normally distributed while asset prices are lognormally distributed.  There are 2 ways to estimate volatility from historic prices.  They are as follows : 

* percentage price changes or discrete returns
* logarithmic price changes or continuous returns

For short time periods <=1d then continuous returns are practically equivalent to continous returns.  

*)

(**
Log Returns.  I understand this.  I don't have much more to add.  I don't know why I am using arrays in and out as opposed to one of the other memory structures, I should work out why
or work out a policy and stick with it (TODO).

*)

#r "FRisk.dll"
open FRisk

let returns = Volatility.logReturns [| 100.25; 101.20; 101.01 |]


(**
Some more info
*)
