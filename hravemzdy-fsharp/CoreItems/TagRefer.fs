
namespace hravemzdyfsharp
open System

[<Class>]
type TagRefer(periodBase : uint32, code : uint32, codeOrder : uint32) = 
    new () as this = TagRefer(0u, 0u, 0u) then
        System.Console.WriteLine(this)
