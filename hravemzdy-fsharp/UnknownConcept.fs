namespace PayrollLibrary

open System

[<Class>]
type UnknownConcept() = 
    inherit PayrollConcept(PayConceptRefs.REFCON_UNKNOWN, uint32 PayTags.TAG_UNKNOWN)


