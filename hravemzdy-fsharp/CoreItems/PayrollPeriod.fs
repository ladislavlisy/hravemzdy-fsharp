
namespace hravemzdyfsharp
open System

[<Class>]
type PayrollPeriod(year : uint32, month : Byte) = 
    new () as this = PayrollPeriod(0u, 0uy) then
        System.Console.WriteLine(this)