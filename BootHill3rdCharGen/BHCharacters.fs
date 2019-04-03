module BHCharacters

open BHAttributes
open BHSkills
open System

//type Skill = { Skill:BHSkill; BaseAttr:BHAttr; Bonus:int }
type BHCharSkillData = { SkillPicks:int }
type BHCharacter = { Name:string; Attrs:BHAttribute list } //; Skills:Skill list }

let newCharacter name attrs = { Name=name; Attrs=attrs } //; Skills=skills }

let getCharacterName =
    printf "Enter a name for your character: "
    Console.ReadLine()

let createAttrs = fun() -> 
    [ 
        newAttr "Strength" false; 
        newAttr "Coordination" false; 
        newAttr "Observation" false; 
        newAttr "Stature" true; 
        newAttr "Luck" true
    ]
let printAttrs c = c.Attrs |> List.iter (fun a -> printfn "%s: %i" a.Name (getScore a))
let getAttrTotal c = c.Attrs |> List.sumBy (fun a -> a.AttrData.Score)
let printAttrTotal c = getAttrTotal c |> printfn "Total: %i"
let rec generateStats name =
    Console.Clear()
    let character = createAttrs() |> newCharacter name
    printAttrs character    
    printAttrTotal character
    character |> getAttrTotal |> getSkillPickCount |> printfn "You'll have %i Skill picks"
    printf "\nRegenerate stats (y)? "
    match Console.ReadLine() with
    |"y"|"Y" -> generateStats name
    |_ -> character

let printSeparator = fun() -> printfn "-----------------------------"

let printHeader header = printfn "\n--%s--" header

let printSkills character = 
    character |> getAttrTotal |> getSkillPickCount |> printfn "\nYou have %i Skill picks remaining. Choose from the following lists:" 
    printHeader "Work Skills"
    printSkillList workSkills
    printHeader "Weapon Skills"
    printSkillList weaponSkills

let printCharSheet character =
    Console.Clear()
    printSeparator()
    printfn "Boot Hill Character Generator"
    printSeparator()
    printfn "Character Name: %s" character.Name
    printHeader "Attributes"
    printAttrs character
    printSkills character

