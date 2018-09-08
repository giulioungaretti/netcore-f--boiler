open Suave
open Suave.Filters
open Suave.Successful
open Suave.Operators

let app = 
    path "/" >=> OK "Hello"


[<EntryPoint>]
let main _ =
    printfn "Hello World from F#!"
    startWebServer defaultConfig app
    0 // return an integer exit code