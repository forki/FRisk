namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FRisk")>]
[<assembly: AssemblyProductAttribute("FRisk")>]
[<assembly: AssemblyDescriptionAttribute("Things I've F(orgotten about)Risk.")>]
[<assembly: AssemblyVersionAttribute("0.0.6")>]
[<assembly: AssemblyFileVersionAttribute("0.0.6")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.6"
