namespace PayrollLibrary

open System

[<Class>]
type TagRefer(pb, c, co) = 
    member x.PeriodBase with get() = pb
    member x.Code with get() = c
    member x.CodeOrder with get() = co
    new () as this = TagRefer(0u, 0u, 0u) then
        System.Console.WriteLine(this)
