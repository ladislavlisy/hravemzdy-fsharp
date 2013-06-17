namespace PayrollLibrary

open System

module PayrollGlobal = 
    let GetDecimalOrZeroValue(o : Object) = match o with
                                            | :? decimal as dec -> dec
                                            | _ -> 0M
    
