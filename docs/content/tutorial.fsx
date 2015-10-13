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

In order to calculate volatility asset returns are required.  I seem to remember the reason you can't use prices is because prices are lognormally distributed 
(although I'm not sure that is the crux of it) and because prices are related to each other, there is an element of autocorrelation and that stuffs things up 
for some reason I have to check on (TODO).  There are 2 ways to estimate volatility from historic prices.  They are as follows : 

* percentage price changes
* logarithmic price changes


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
