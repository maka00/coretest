// Learn more about F# at http://fsharp.org

open System
open applib

[<EntryPoint>]
let main argv =
    "myself" |> Say.hello |> printfn "%s"
    0 // return an integer exit code
