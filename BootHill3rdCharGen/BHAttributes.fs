﻿module BHAttributes

open Dice
open System

type BHAttrData = { Rolls:int list; Bonus:int; Score:int }
type BHAttribute = { Name:string; AttrData:BHAttrData }

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