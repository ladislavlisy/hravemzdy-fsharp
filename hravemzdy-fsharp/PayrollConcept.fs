namespace PayrollLibrary

open System
open PayrollGlobal

type PayrollConcept(c, n, cc) = 
    inherit CodeNameRefer(c, n)

    static let TERM_BEG_FINISHED = 32u
    static let TERM_END_FINISHED =  0u

    static member CALC_CATEGORY_START  with get() = 0u
    static member CALC_CATEGORY_TIMES  with get() = 0u
    static member CALC_CATEGORY_AMOUNT with get() = 0u
    static member CALC_CATEGORY_GROSS  with get() = 1u
    static member CALC_CATEGORY_NETTO  with get() = 2u
    static member CALC_CATEGORY_FINAL  with get() = 9u

    member x.TagCode with get() = c
    member x.ConceptCode with get() = cc
    member x.TagPendingCodes with get() = null
    new (cr : CodeNameRefer, cc) as this = PayrollConcept(cr.Code, cr.Name, cc) then
        System.Console.WriteLine(this)
    new () as this = PayrollConcept(0u, "", 0u) then
        System.Console.WriteLine(this) 
    member x.Description() = 
        x.Name

    abstract PendingCodes : unit -> obj [] 
    default x.PendingCodes() =
        [| |]
    abstract SummaryCodes : unit -> obj [] 
    default x.SummaryCodes() =
        [| |]
    abstract CalcCategory : unit -> uint32 
    default x.CalcCategory() =
        PayrollConcept.CALC_CATEGORY_AMOUNT

    member x.InitValuesDecimal(values : Map<string, Object>, key : string) : decimal = 
        match values.TryFind(key) with
        | None -> 0M
        | _  -> PayrollGlobal.GetDecimalOrZeroValue(values.[key])
