module BHCharacters

open BHAttributes
open BHSkills

//type Skill = { Skill:BHSkill; BaseAttr:BHAttr; Bonus:int }
type BHCharacter = { Name:string; Attrs:BHAttr list } //; Skills:Skill list }

let newCharacter name attrs = { Name=name; Attrs=attrs } //; Skills=skills }

let createAttrs = fun() -> 
    [ 
        newAttr "Strength" false; 
        newAttr "Coordination" false; 
        newAttr "Observation" false; 
        newAttr "Stature" true; 
        newAttr "Luck" true
    ]

let printAttrs char = char.Attrs |> List.iter (fun a -> printfn "%s: %i" a.Name (getScore a))

let getAttrTotal attrs = List.sumBy (fun a -> a.AttrData.Score) attrs
let printAttrTotal attrs  = getAttrTotal attrs |> printfn "Total: %i"

//let newChar name attrs skills = { Name=name; Attributes=attrs; Skills=skills }

