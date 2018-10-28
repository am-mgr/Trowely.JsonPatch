namespace Trowely.JsonPatch

module Core =
    
    type JsonPatchAction = Add 
                            | Remove 
                            | Replace 
                            | Copy 
                            | Move 
                            | Test

    type JsonPatchModel<'a>() =
        member __.OP = "no-op"
        member __.Apply(model: 'a) = printfn "%s: %A" __.OP model 