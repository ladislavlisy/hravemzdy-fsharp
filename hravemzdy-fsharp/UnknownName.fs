namespace PayrollLibrary

open System

[<Class>]
type UnknownName() = 
    inherit PayrollName(PayTagRefs.REF_UNKNOWN,"Unknown", "Unknown",PayNameGroups.VPAYGRP_UNKNOWN, PayNameGroups.HPAYGRP_UNKNOWN)


