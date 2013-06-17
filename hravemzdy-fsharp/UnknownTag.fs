namespace PayrollLibrary

open System

[<Class>]
type UnknownTag() = 
    inherit PayrollTag(PayTagRefs.REF_UNKNOWN, PayConceptRefs.REFCON_UNKNOWN)


