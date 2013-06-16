
namespace hravemzdyfsharp
open System

[<Class>]
type PayrollName(c, n, t, d, vGroup, hGroup) = 
    inherit CodeNameRefer(c, n)
    static let VGRP_POS = "vgrp_pos"
    static let HGRP_POS = "hgrp_pos"
    member p.title = t
    member p.description = d
    member p.xmlGroups = Map.ofList [ VGRP_POS, vGroup; HGRP_POS, hGroup ]
    new (tag : CodeNameRefer, t, d, vGroup, hGroup) as this = PayrollName( tag.code, tag.name, t, d, vGroup, hGroup ) then
        System.Console.WriteLine(this)
    new () as this = PayrollName( 0u, "", "", "", "", "" ) then 
        System.Console.WriteLine(this)