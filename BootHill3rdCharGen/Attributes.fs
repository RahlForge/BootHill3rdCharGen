module Attributes

open Dice
open System

type BHAttrData = { Rolls:int list; Bonus:int; Score:int }
type BHAttr = { Name:string; AttrData:BHAttrData }

let attrBonus roll =
    match roll with
    | 2 | 3 | 4 | 5 -> 5
    | 6 | 7 | 8 | 9 | 10  -> 3
    | 11 | 12 | 13 | 14 -> 2
    | 15 | 16 | 17 -> 1
    | _ -> 0

let calcAttrScore roll bonus divBy2 = 
    let total = List.sum roll + bonus
    match divBy2 with
    |false -> total
    |_ -> (total + 1) / 2

let generateAttr divBy2 =
    let rolls = List.init 2 (fun _ -> rollDice 10)
    let bonus = List.sum rolls |> attrBonus
    let score = calcAttrScore rolls bonus divBy2    
    { Rolls=rolls; Bonus=bonus; Score=score }       

let getScore attr = attr.AttrData.Score
let getName attr = attr.Name
let getBonus attr = attr.AttrData.Bonus
let getRolls attr = attr.AttrData.Rolls

let newAttr name divBy2 = { Name=name; AttrData=generateAttr divBy2 }

// let setAttrName a =
//     match a with
//     | 0 -> "Strength"
//     | 1 -> "Coordination"
//     | 2 -> "Observation"
//     | 3 -> "Stature"
//     | _ -> "Luck"    

// let calcAttrScore roll bonus index = 
//     match index with
//     |index when index < 3 -> List.sum roll + bonus
//     |_ -> (List.sum roll + bonus + 1) / 2

// let printAttrCalc name roll bonus total index =
//     let printFormat =
//         match index with
//         |0|1|2 -> Printf.TextWriterFormat<_> "%s: %i (%A + %i)"
//         |_ -> Printf.TextWriterFormat<_> "%s: %i (%A + %i) / 2"
//     printfn printFormat name total roll bonus

// let printAttr attr =
//     printfn "%s: %i" attr.Name attr.Score

// let attrList = fun() ->
//     List.init 5 (fun i -> 
//         let roll = List.init 2 (fun _ -> rollDice 10)
//         let bonus = attrBonus (List.sum roll)
//         let total = calcAttrScore roll bonus i
//         let name = setAttrName i
//         // Uncomment next line to show attribute calculations
//         // printAttrCalc name roll bonus total i
//         newAttr name total)

// let attrTotal aList = 
//     let attrScores = 
//         aList |> List.map (fun a -> a.Score)
//     List.sum attrScores 