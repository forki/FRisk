namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FRisk")>]
[<assembly: AssemblyProductAttribute("FRisk")>]
[<assembly: AssemblyDescriptionAttribute("Things I've F(orgotten about)Risk.")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
