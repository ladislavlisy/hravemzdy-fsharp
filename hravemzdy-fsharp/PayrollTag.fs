namespace PayrollLibrary

open System

type PayrollTag(c, n, ci) = 
    inherit CodeNameRefer(c, n)

    member x.Concept with get() : CodeNameRefer = ci
    new (cr : CodeNameRefer, ci) as this = PayrollTag(cr.Code, cr.Name, new CodeNameRefer()) then
        System.Console.WriteLine(this)
    new () as this = PayrollTag(0u, "", new CodeNameRefer()) then
        System.Console.WriteLine(this)
    
    member x.Title() = 
        x.Name
    member x.Description() = 
        x.Name
    member x.ConceptCode() = 
        x.Concept.Code
    member x.ConceptName() = 
        x.Concept.Name


    abstract InsuranceHealth : unit -> bool
    default x.InsuranceHealth() = 
        false
    abstract InsuranceSocial : unit -> bool
    default x.InsuranceSocial() = 
        false
    abstract TaxAdvance : unit -> bool
    default x.TaxAdvance() = 
        false
    abstract IncomeGross : unit -> bool
    default x.IncomeGross() = 
        false
    abstract IncomeNetto : unit -> bool
    default x.IncomeNetto() = 
        false
    abstract DeductionNetto : unit -> bool
    default x.DeductionNetto() = 
        false
