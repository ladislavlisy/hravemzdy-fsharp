namespace PayrollLibrary

open System

[<Class>]
type CodeNameRefer(c, n) = 
    member x.Code with get() = c
    member x.Name with get() = n
    new () as this = CodeNameRefer(0u, "") then
        System.Console.WriteLine(this)
