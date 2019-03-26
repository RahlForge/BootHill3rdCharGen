module Attributes

open Dice

type Attribute = { Name:string; Score:int }

let newAttr name score = { Name=name; Score=score }

let setAttrName a =
    match a with
    | 0 -> "Strength"
    | 1 -> "Coordination"
    | 2 -> "Observation"
    | 3 -> "Stature"
    | _ -> "Luck"

let attrBonus roll =
    match roll with
    | 2 | 3 | 4 | 5 -> 5
    | 6 | 7 | 8 | 9 | 10  -> 3
    | 11 | 12 | 13 | 14 -> 2
    | 15 | 16 | 17 -> 1
    | _ -> 0

let calcAttrScore roll bonus index = 
    match index with
    |index when index < 3 -> List.sum roll + bonus
    |_ -> (List.sum roll + bonus + 1) / 2

let printAttrCalc name roll bonus total index =
    let printFormat =
        match index with
        |0|1|2 -> Printf.TextWriterFormat<_> "%s: %i (%A + %i)"
        |_ -> Printf.TextWriterFormat<_> "%s: %i (%A + %i) / 2"
    printfn printFormat name total roll bonus

let printAttr attr =
    printfn "%s: %i" attr.Name attr.Score

let attrList = fun() ->
    List.init 5 (fun i -> 
        let roll = List.init 2 (fun _ -> rollDice 10)
        let bonus = attrBonus (List.sum roll)
        let total = calcAttrScore roll bonus i
        let name = setAttrName i
        // Uncomment next line to show attribute calculations
        // printAttrCalc name roll bonus total i
        newAttr name total)

let attrTotal aList = 
    let attrScores = 
        aList |> List.map (fun a -> a.Score)
    List.sum attrScores