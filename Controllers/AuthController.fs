namespace NetcoreApiStarter.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc

[<Route("api/[controller]")>]
[<ApiController>]
type AuthController () =
    inherit ControllerBase()

    [<HttpGet>]
    member __.Get() =
        let creds = [|"username"; "password"|]
        ActionResult<string[]>(creds)

    [<HttpGet("{id}")>]
    member __.Get(id:int) =
        let value = "value"
        ActionResult<string>(value)

    [<HttpPost>]
    member __.Post([<FromBody>] value:string) =
        ()
