open Suave
open Suave.Filters
open Suave.Successful
open Suave.Operators
open FSharp.Data.Sql

[<Literal>]
let resolutionPath = __SOURCE_DIRECTORY__ + "/libraries"

let app = 
    path "/" >=> OK "Hello"


let [<Literal>] connectionString = "Host=localhost;Database=amie;Username=amie;Password=decaponz"

type sql = SqlDataProvider<
              ConnectionString = connectionString,
              DatabaseVendor = Common.DatabaseProviderTypes.POSTGRESQL,
              IndividualsAmount = 1000,
              UseOptionTypes = true >
(*let ctx = sql.GetDataContext()*)


(*let leaf = *)

    (*query {*)
         (*for l in ctx.Public.Leaf do*)
             (*select l*)
             (*}*)
    (*|> Seq.toArray*)


[<EntryPoint>]
let main _ =
    printfn "Hello World from F#!"
    printfn  "%s" resolutionPath
    startWebServer defaultConfig app
    0 // return an integer exit code
