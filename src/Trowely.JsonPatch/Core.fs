namespace Trowely.JsonPatch

module Core =

    type JsonPatchAction = Add 
                            | Remove 
                            | Replace 
                            | Copy 
                            | Move 
                            | Test
