
namespace hravemzdyfsharp
open System

[<Class>]
type CodeNameRefer(code : uint32, name : string) = 
    new (c, n) as this = CodeNameRefer(c, n) then
        System.Console.WriteLine(this)
    new () as this = CodeNameRefer(0u, "") then
        System.Console.WriteLine(this)
