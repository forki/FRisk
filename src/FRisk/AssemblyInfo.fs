namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FRisk")>]
[<assembly: AssemblyProductAttribute("FRisk")>]
[<assembly: AssemblyDescriptionAttribute("Things I've F(orgotten about)Risk.")>]
[<assembly: AssemblyVersionAttribute("0.0.2")>]
[<assembly: AssemblyFileVersionAttribute("0.0.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.2"
