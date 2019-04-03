module BootHill3rdCharGen

open System
open BHCharacters

let printGoodbye = fun() -> 
    printfn "\nGoodbye!"
    Console.ReadKey() |> ignore

[<EntryPoint>]
let main argv =
    
    let character = getCharacterName |> generateStats
    printCharSheet character
    printGoodbye()
    0 // return an integer exit code