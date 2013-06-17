namespace PayrollLibrary

open System

type PayrollResult(c, cc, ci) = 
    member x.TagCode with get() = c
    member x.ConceptCode with get() = cc
    member x.Concept = ci
    new () as this = PayrollResult(0u, 0u, new PayrollConcept()) then
        System.Console.WriteLine(this)
    
    abstract SummaryFor : uint32 -> bool
    default x.SummaryFor(code) = 
        false
