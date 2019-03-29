module BHChar

open Attributes
open Skills

//type Skill = { Skill:BHSkill; BaseAttr:BHAttr; Bonus:int }
type BHChar = { Name:string; Attrs:BHAttr list } //; Skills:Skill list }

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

//let newChar name attrs skills = { Name=name; Attributes=attrs; Skills=skills }

