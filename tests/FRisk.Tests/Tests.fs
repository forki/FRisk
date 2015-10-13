module FRisk.Tests

open FRisk
open NUnit.Framework

[<Test>]
let ``logReturns returns 2 elements`` () =
  let result = Volatility.logReturns [| 100.25; 101.20; 101.01 |]
  printfn "%A" result
  Assert.AreEqual(2, result.Length)
