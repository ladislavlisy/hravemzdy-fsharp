namespace PayrollLibrary

open System
open PayrollGlobal

[<Class>]
type SalaryMonthlyConcept(code,values) = 
    inherit PayrollConcept(PayConceptRefs.REFCON_SALARY_MONTHLY, code)

    new () as this = SalaryMonthlyConcept(0u, Map.empty<string, Object>) then
        System.Console.WriteLine(this)

    member x.AmountMonthly with get() : decimal = x.InitValuesDecimal(values, "amount_monthly")

    override x.PendingCodes() = 
        [| |]
    override x.SummaryCodes() = 
        [| |]
    override x.CalcCategory() = 
        PayrollConcept.CALC_CATEGORY_AMOUNT

    member x.Evaluate(period, tagConfig, results) : PayrollResult = 
        new PayrollResult()
