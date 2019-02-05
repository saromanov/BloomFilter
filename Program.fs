// Learn more about F# at http://fsharp.org

open System

let n = 10000

let hash x = 
    let h = 86813
    List.filter x
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
