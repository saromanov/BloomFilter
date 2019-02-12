// Learn more about F# at http://fsharp.org

open System

let n = 10000

let jenkins (s:string) =
    let h = 
        System.Text.Encoding.ASCII.GetBytes(s) |> Array.fold (fun ac b ->
            let ac = ac + (uint32 b)
            let ac = ac + (ac <<< 10)
            ac ^^^ (ac >>> 6)
        ) 0u
    let h = h + (h <<< 3)
    let h = h ^^^ (h <<< 11)
    h + (h <<< 15)

let square x = x * x

let bloom_filter n_bits n_hashes = 
    List.Filter n_bits n_hashes
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
