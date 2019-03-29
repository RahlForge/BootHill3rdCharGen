module BootHill3rdCharGen

open System
open Attributes
open Skills
open BHChar

let printSeparator = fun() -> printfn "-----------------------------"
let printHeader header = printfn "\n--%s--" header

let printCharSheet character =
    printSeparator()
    printfn "Boot Hill Character Generator"
    printSeparator()
    printfn "Character Name: %s" character.Name
    printHeader "Attributes"
    printAttrs character
    // let attributes = attrList()
    // attributes |> List.iter printAttr
    // let theTotal = attrTotal attributes
    //printHeader "Skills"   
    //printfn "Attribute Total: %i, Number of Skills: %i" theTotal (initSkills theTotal)

let printGoodbye = fun() -> 
    printfn "\nGoodbye!"
    Console.ReadKey() |> ignore

let rec rerun name =
    let character = newCharacter name (createAttrs())
    printCharSheet character
    printf "\nPrint new sheet (y)? "
    let runAgain = Console.ReadLine()
    match runAgain with
    |"y"|"Y" -> 
        Console.Clear()
        rerun name
    |_ -> printfn "\nOk, let's go get your skills!"

[<EntryPoint>]
let main argv =
    printf "Enter a name for your character: "    
    Console.ReadLine() |> rerun
    printHeader "Work Skills"
    printSkillList workSkills
    printHeader "Weapon Skills"
    printSkillList weaponSkills
    printGoodbye()
    0 // return an integer exit code