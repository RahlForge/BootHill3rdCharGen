// Learn more about F# at http://fsharp.org
open System
open Attributes
open Skills

let printSeparator = fun() -> printfn "-----------------------------"
let printHeader header = printfn "\n--%s--" header

let printCharSheet = fun() ->
    printSeparator()
    printfn "Boot Hill Character Generator"
    printSeparator()
    printHeader "Attributes"
    let attributes = attrList()
    attributes |> List.iter (fun a -> printAttr a)
    let theTotal = attrTotal attributes
    printHeader "Skills"   
    printfn "Attribute Total: %i, Number of Skills: %i" theTotal (initSkills theTotal)

let printGoodbye = fun() -> printfn "\nGoodbye!"

let rec rerun = fun() ->
    printCharSheet()
    printf "\nPrint new sheet (y)? "
    let runAgain = Console.ReadLine()
    match runAgain with
    |"y"|"Y" -> 
        Console.Clear()
        rerun()
    |_ -> printGoodbye()

[<EntryPoint>]
let main argv =
    rerun()
    0 // return an integer exit code

