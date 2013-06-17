namespace PayrollLibrary

open System

[<Class>]
type PayrollName(c, n, t, d, vGroup, hGroup) = 
    inherit CodeNameRefer(c, n)

    static let VGRP_POS = "vgrp_pos"
    static let HGRP_POS = "hgrp_pos"

    member x.Title = t
    member x.Description = d
    member x.XmlGroups = Map.ofList [ VGRP_POS, vGroup; HGRP_POS, hGroup ]
    new (tag : CodeNameRefer, t, d, vGroup, hGroup) as this = PayrollName( tag.Code, tag.Name, t, d, vGroup, hGroup ) then
        System.Console.WriteLine(this)
    new () as this = PayrollName( 0u, "", "", "", "", "" ) then
        System.Console.WriteLine(this)

    member x.GetGroups() : Map<string, string> =
        x.XmlGroups
    member x.MatchVGroup(groupCode) : bool =
        match x.XmlGroups.TryFind(VGRP_POS) with
        | None -> x.XmlGroups.[VGRP_POS] = groupCode
        | _ -> false
    member x.MatchHGroup(groupCode) : bool =
        match x.XmlGroups.TryFind(HGRP_POS) with
        | None -> x.XmlGroups.[HGRP_POS] = groupCode
        | _ -> false
